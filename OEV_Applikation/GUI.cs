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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Speichert den in string convertierten Inhalt der Eingabe in Variablen ab
            string startStation = txtStartstation.Text;
            string endStation = txtEndstation.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = nbrHour.Value + ":" + nbrMinute.Value;

            //Erstellte ein Objekt der Klasse Transport nach Vorgaben der Struktur ITransport
            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();

            //Erstellt eine Liste welche Objekte der Klasse Station beinhaltet, welche das Wort (Parameter) im Namen der Station enthält
            List<SwissTransport.Station> start = StationConnetions.GetStations(startStation).StationList;
            List<SwissTransport.Station> end = StationConnetions.GetStations(endStation).StationList;

            //Erstellt eine Liste welche Objekte der Klasse Connection beinhaltet, welche die Verbindungen zwischen zwei Stationen darstellt
            List<SwissTransport.Connection> startEndConnection = StationConnetions.GetConnectionsByDateTime(startStation, endStation, date, time).ConnectionList;

            dgvOutput.Rows.Clear();

            if (startEndConnection != null)
            {
                foreach (SwissTransport.Connection connection in startEndConnection)
                {
                    dgvOutput.Rows.Add(connection.From.Station.Name, TimeStampToTime(connection.From.DepartureTimestamp), 
                        connection.From.Platform, TimeStampToTime(connection.To.ArrivalTimestamp), connection.To.Station.Name);

                }

            }

        }

        private void btnSuggestion_Click(object sender, EventArgs e)
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

        private void btnSuggestionDelete_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public string TimeStampToTime(string response)
        {
            //https://coderwall.com/p/e8rzuq/how-to-convert-a-unix-timestamp-to-a-net-system-datetime-object

            double h = Convert.ToDouble(response);
            System.DateTime s = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            s = s.AddSeconds(h);
            string k = s.ToString("H:mm");
            return k;
        }

        public void ClearAll()
        {
            txtEndstation.Clear();
            txtStartstation.Clear();
            lstStartstation.Items.Clear();
            lstEndstation.Items.Clear();
            dgvOutput.Rows.Clear();
            dtpDate.ResetText();
            nbrHour.Value = DateTime.Now.Hour;
            nbrMinute.Value = DateTime.Now.Minute;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nbrHour.Value = DateTime.Now.Hour;
            nbrMinute.Value = DateTime.Now.Minute;
        }
    }
}
