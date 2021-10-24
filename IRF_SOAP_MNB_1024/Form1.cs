using IRF_SOAP_MNB_1024.Entities;
using IRF_SOAP_MNB_1024.MNBServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IRF_SOAP_MNB_1024
{
    public partial class Form1 : Form
    {
        //névtér
        BindingList<RateData> Rates = new BindingList<RateData>();
        string result { get; set; }

        public Form1()
        {
            InitializeComponent();
            WebserviceCall();
            XMLProcess();

            dataGridView1.DataSource = Rates;
        }       

        private void WebserviceCall()
        {
            //kell előtte az a namespace: using IRF_SOAP_MNB_1024.MNBServiceReference;
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }

        private void XMLProcess()
        {
            // using system.xml
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement element in xml.DocumentElement)
            {
                var rate = new RateData();
                Rates.Add(rate);

                //date
                rate.Date = DateTime.Parse(element.GetAttribute("date"));
                //valuta
                var childElement = (XmlElement)element.ChildNodes[0];
                rate.Currency = childElement.GetAttribute("curr");

                //érték
                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0) rate.Value = value / unit;
            }
        }
    }
}
