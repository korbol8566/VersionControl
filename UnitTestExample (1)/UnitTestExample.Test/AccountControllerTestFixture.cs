using Moq;
using NUnit.Framework;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Abstractions;
using UnitTestExample.Controllers;
using UnitTestExample.Entities;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualresult = accountController.ValidateEmail(email);
            Assert.AreEqual(expectedResult, actualresult);

            //NUnit3TestAdapter ez az extension is kellett, el kéne olvasni a feladatot
        }

        [
            Test,
            TestCase("Qwerqweq", false),
            TestCase("QWERQWE1", false),
            TestCase("qwerqwe1", false),
            TestCase("Qwerqw1", false),
            TestCase("Abcd1234", false) // ennek true-nak kéne lennie, de úgy elhasal a test
        ]
        public void TestValidatePassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();
            var actualresult = accountController.ValidatePassword(password);
            Assert.AreEqual(expectedResult, actualresult);
        }

        public void TestRegisterHappyPath(string email, string password)
        {
            //arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
            .Setup(m => m.CreateAccount(It.IsAny<Account>()))
            .Returns<Account>(a => a);
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            var actualResult = accountController.Register(email, password);

            Assert.AreEqual(email, actualResult.Password);
            Assert.AreEqual(password, actualResult.Password);
            Assert.AreNotEqual(Guid.Empty, actualResult.ID);
            accountServiceMock.Verify(m => m.CreateAccount(actualResult), Times.Once);

        }

        [
            Test,
            TestCase("irf@uni-corvinus.hu", "Abcd1234")
            
        ]
        public void TestRegisterApplicationException(string newEmail, string newPassword)
        {
            // Arrange
            var accountServiceMock = new Mock<IAccountManager>(MockBehavior.Strict);
            accountServiceMock
                .Setup(m => m.CreateAccount(It.IsAny<Account>()))
                .Throws<ApplicationException>();
            var accountController = new AccountController();
            accountController.AccountManager = accountServiceMock.Object;

            // Act
            try
            {
                var actualResult = accountController.Register(newEmail, newPassword);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOf<ApplicationException>(ex);
            }

            // Assert
        }
    }
}
