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
using wwek06.Entities;
using wwek06.MnbServiceReference;

namespace wwek06
{
    public partial class Form1 : Form
    {
        RateData context = new RateData();
        BindingList<RateData> Rates = new BindingList<RateData>();
        BindingList<Currency> Currencies = new BindingList<Currency>();
        
        public Form1()
        {
            InitializeComponent();
            GetCurrencies();
            LoadCurrencies();
            RefreshData();
        }

        private void LoadCurrencies()
        {
           
        }

        private void GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();
            var request = new GetCurrenciesRequestBody()
            {

                
            };

            var response = mnbService.GetCurrencies(request);
            var result = response.GetCurrenciesResult;


            var xml = new XmlDocument();
            xml.LoadXml(result);

            
            foreach (XmlElement element in xml.DocumentElement)
            {
                // Létrehozzuk az adatsort és rögtön hozzáadjuk a listához
                // Mivel ez egy referencia típusú változó, megtehetjük, hogy előbb adjuk a listához és csak később töltjük fel a tulajdonságait
                var currency = new Currency();
               
                Currencies.Add(currency);

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                currency.CValue = childElement.GetAttribute("curr");


               
            }
        }

        private void RefreshData()
        {
            Rates.Clear();
            CallWebservice();
            comboBox1.DataSource = Currencies;
            dataGridView1.DataSource = Rates;
            CreateXml();
            ShowData();
        }

        private void CallWebservice()
        {
        
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                /*currencyNames = "EUR",
                //comboBox1.SelectedItem.ToString(),
                startDate = (dateTimePicker1.Value).ToString(),
                endDate = (dateTimePicker2.Value).ToString()*/
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);

         
            var result = response.GetExchangeRatesResult;

            var xml = new XmlDocument();
            xml.LoadXml(result);
            foreach (XmlElement element in xml.DocumentElement)
            {

                var rate = new RateData();
                Rates.Add(rate);

                rate.Date = DateTime.Parse(element.GetAttribute("date"));

                var childElement = (XmlElement)element.ChildNodes[0];
                if (childElement == null)
                    continue;
                rate.Currency = childElement.GetAttribute("curr");

                var unit = decimal.Parse(childElement.GetAttribute("unit"));
                var value = decimal.Parse(childElement.InnerText);
                if (unit != 0)
                    rate.Value = value / unit;
            }
        }

        private void ShowData()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
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

        private void CreateXml()
        {
            

        }

        private void Webservice()
        {
           
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
