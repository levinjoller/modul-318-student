using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OEV_Applikation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            string startStation = txtStartstation.Text;
            string endStation = txtEndstation.Text;
            string datum = dtpDatum.Value.ToString();

            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();

            List<SwissTransport.Station> start = StationConnetions.GetStations(startStation).StationList;
            List<SwissTransport.Station> end = StationConnetions.GetStations(endStation).StationList;

            List<SwissTransport.Connection> startEndConnection = StationConnetions.GetConnections(startStation, endStation).ConnectionList;
            if (startEndConnection != null)
            {
                foreach (SwissTransport.Connection connection in startEndConnection)
                {
                    lstAusgabe.Items.Add(connection.From.Departure + connection.To.Arrival + "\t" + connection.To.Platform);

                }

            }






            //foreach (SwissTransport.Station station in start)
            //{
            //    lstAusgabe.Items.Add(station.Name);
            //}





            //MessageBox.Show(Convert.ToString(StationConnetions.GetStations(startStation)));
            //lstAusgabe.Items.Add

            //MessageBox.Show(datum);

        }

        private void btnVorschlaege_Click(object sender, EventArgs e)
        {
            string startStation = txtStartstation.Text;
            string endStation = txtEndstation.Text;

            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();

            List<SwissTransport.Station> start = StationConnetions.GetStations(startStation).StationList;
            List<SwissTransport.Station> end = StationConnetions.GetStations(endStation).StationList;

            lstStartstation.Items.Clear();
            lstEndstation.Items.Clear();

            foreach (SwissTransport.Station station in start)
            {
                lstStartstation.Items.Add(station.Name);
            }

            foreach (SwissTransport.Station station in end)
            {
                lstEndstation.Items.Add(station.Name);
            }


        }

        private void lstEndstation_Click(object sender, EventArgs e)
        {
            if(lstEndstation.Items.Count != 0)
            {
                txtEndstation.Text = lstEndstation.SelectedItem.ToString();
            }
        }

        private void lstStartstation_Click(object sender, EventArgs e)
        {
            if(lstStartstation.Items.Count != 0)
            {
                txtStartstation.Text = lstStartstation.SelectedItem.ToString();
            }
        }

        private void btnAuswahlDelete_Click(object sender, EventArgs e)
        {
            txtEndstation.Clear();
            txtStartstation.Clear();
            lstStartstation.Items.Clear();
            lstEndstation.Items.Clear();
            lstAusgabe.Items.Clear();
            dtpDatum.ResetText();
        }
    }
}
