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
            ClearAllTabOne();
        }

        /// <summary>
        /// Wandelt den unix-Timestamp in System.DateTime
        /// </summary>
        /// <param name="unixTime">Übergabe des unix-Timestamps</param>
        /// Gibt die umgewandelte Zeit in {Hour:Minute} als string zurück
        /// <returns></returns>
        public string TimeStampToTime(string unixTime)
        {
            //https://coderwall.com/p/e8rzuq/how-to-convert-a-unix-timestamp-to-a-net-system-datetime-object
            double h = Convert.ToDouble(unixTime);
            System.DateTime s = new System.DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            s = s.AddSeconds(h);
            string k = s.ToString("H:mm");
            return k;
        }

        /// <summary>
        ///Bereinigt alle Eingabe- und Ausgabeelemente im 1.Tab
        /// </summary>
        public void ClearAllTabOne()
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

        /// <summary>
        /// Bereinigt alle Eingabe- und Ausgabeelemente im 2.Tab
        /// </summary>
        public void ClearAllTabTwo()
        {
            txtStation.Clear();
            dgvOutputStation.Rows.Clear();
            lstSuggestionsStation.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nbrHour.Value = DateTime.Now.Hour;
            nbrMinute.Value = DateTime.Now.Minute;
        }

        private void btnSearchStation_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();
            List<SwissTransport.Station> stationList = StationConnetions.GetStations(station).StationList;

            //Enthält das erste Objekt der Klasse Station von der Liste stationList
            SwissTransport.Station UsedStation = stationList[0];

            //Erstellt eine Liste welche Objekte der Klasse StationBoard beinhaltet, welche mit dem Namen und der Id der UsedStation übereinstimmen
            List<SwissTransport.StationBoard> EntriesConnections = StationConnetions.GetStationBoard(UsedStation.Name, UsedStation.Id).Entries;

            //Enthält das Objekt der Klasse Station, welches mit dem Namen und der Id der UsedStation übereinstimmt
            SwissTransport.Station EntriesStation = StationConnetions.GetStationBoard(UsedStation.Name, UsedStation.Id).Station;

            foreach(SwissTransport.StationBoard stationBoard in EntriesConnections)
            {
                dgvOutputStation.Rows.Add(EntriesStation.Name, stationBoard.To, stationBoard.Stop.Departure.ToShortTimeString(), stationBoard.Category, stationBoard.Number);
            }
        }

        private void tbcChangeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bestimmen auf welcher Ansicht der Benutzer ist, um den AcceptButton zu setzen
            if(tbcChangeView.SelectedTab == sdStation)
            {
                this.AcceptButton = btnSearchStation;
            }
            else
            {
                this.AcceptButton = btnSearch;
            }

        }

        private void btnSuggestionsDeleteTab2_Click(object sender, EventArgs e)
        {
            ClearAllTabTwo();
        }
    }
}
