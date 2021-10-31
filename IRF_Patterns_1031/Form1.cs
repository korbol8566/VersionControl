using IRF_Patterns_1031.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Patterns_1031
{
    public partial class Form1 : Form
    {
        List<Ball> list_balls = new List<Ball>();
        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var Ball = Factory.CreateNew();
            list_balls.Add(Ball);
            Ball.Left = -Ball.Width;
            panel1.Controls.Add(Ball);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in list_balls)
            {
                ball.MoveBall();
                if (ball.Left>maxPosition) maxPosition = ball.Left;
            }
            if (maxPosition>1000)
            {
                var oldestBall = list_balls[0];
                panel1.Controls.Remove(oldestBall);
                list_balls.Remove(oldestBall);
            }
        }
    }
}
