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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace IRF_SOAP_MNB_1024
{
    public partial class Form1 : Form
    {
        //névtér
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<string> Currencies = new BindingList<string>();

        //var result;
        public Form1()
        {
            InitializeComponent();
            //GetCurrencies();
            RefreshData();
            
        }
        //8
        //private void GetCurrencies()
        //{
        //    //kérdezd le az MNB szolgáltatásból az elérhető valuták listáját

        //    var mnbService2=new MNBArfolyamServiceSoapClient();
        //    var request2 = new GetCurrenciesRequestBody()
        //    {
        //        // mnb currencies get
        //    };
        //    var response2 = mnbService2.GetCurrencies(request2);
        //    var result2 = response2.GetCurrenciesResult;

        //    var xml2 = new XmlDocument();
        //    xml2.LoadXml(result2);
        //    foreach (XmlElement element in xml2.DocumentElement)
        //    {
        //        Currencies.Add(result2);
        //    }
        //}

        private void RefreshData()
        {
            Rates.Clear();

            WebserviceCall();
            //XMLProcess();
            ShowData();

            dataGridView1.DataSource = Rates;
            chartRateData.DataSource = Currencies;

            
        }

        public void WebserviceCall()
        {
            //kell előtte az a namespace: using IRF_SOAP_MNB_1024.MNBServiceReference;
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                //8
                //currencyNames = comboBox1.SelectedItem.ToString(),                
                //startDate = dateTimePicker1.Value.ToShortDateString(),
                //endDate= dateTimePicker1.Value.ToShortDateString()

                //3
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"

            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
        }

        //private void XMLProcess(var result)
        //{
        //    // using system.xml
        //    var xml = new XmlDocument();
        //    //meg kéne kapnia a fenti result var-t fml,(Ehhez megfelelő paraméterek és visszatérési értékek létrehozásával át kell adnod a korábbi result-ot ennek a függvénynek.)
        //    xml.LoadXml(result);

        //    foreach (XmlElement element in xml.DocumentElement)
        //    {
        //        var rate = new RateData();
        //        Rates.Add(rate);

        //        //date
        //        rate.Date = DateTime.Parse(element.GetAttribute("date"));

        //        //valuta
        //        var childElement = (XmlElement)element.ChildNodes[0];
        //        if (childElement == null) continue;
        //        rate.Currency = childElement.GetAttribute("curr");

        //        //érték
        //        var unit = decimal.Parse(childElement.GetAttribute("unit"));
        //        var value = decimal.Parse(childElement.InnerText);
        //        if (unit != 0) rate.Value = value / unit;
        //    }
        //}

        private void ShowData()
        {
            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line; //adatsor típusa, behivatkozandó
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
