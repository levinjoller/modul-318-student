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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //Speichert den in string convertierten Inhalt der Eingabe in Variablen ab
            string startStation = txtStartstation.Text;
            string endStation = txtEndstation.Text;
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            //Die Zeitzone wird im Moment noch manuell mit +1 angepasst
            string time = (nbrHour.Value + 1) + ":" + nbrMinute.Value;

            //Erstellte ein Objekt der Klasse Transport nach Vorgaben der Struktur ITransport
            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();
            try
            {
                //Erstellt eine Liste welche Objekte der Klasse Station beinhaltet, welche das Wort (Parameter) im Namen der Station enthält
                List<SwissTransport.Station> start = StationConnetions.GetStations(startStation).StationList;
                List<SwissTransport.Station> end = StationConnetions.GetStations(endStation).StationList;

                //Erstellt eine Liste welche Objekte der Klasse Connection beinhaltet, welche die Verbindungen zwischen zwei Stationen darstellt
                List<SwissTransport.Connection> startEndConnection = StationConnetions.GetConnectionsByDateTime(startStation, endStation, date, time).ConnectionList;

                dgvOutput.Rows.Clear();

                if (startEndConnection.Count != 0)
                {
                    foreach (SwissTransport.Connection connection in startEndConnection)
                    {
                        dgvOutput.Rows.Add(connection.From.Station.Name, TimeStampToTime(connection.From.DepartureTimestamp),
                            connection.From.Platform, TimeStampToTime(connection.To.ArrivalTimestamp), connection.To.Station.Name);
                    }
                }
                else
                {
                    MessageBox.Show("Keine Verbindung gefunden.\nÜberprüfen Sie Ihre Eingabe.");
                }
            }
            catch
            {
                MessageConnectionError();
            }

        }

        private void txtElementText_SelectedIndexChanged(object sender, EventArgs e)
        {
            string startStation = txtStartstation.Text;
            string endStation = txtEndstation.Text;

            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();

            //Bestimmt von welcher Textbox aus ich die Daten eingebe, um Performace zu sparen
            if (sender == txtStartstation)
            {
                try
                {
                    List<SwissTransport.Station> start = StationConnetions.GetStations(startStation).StationList;

                    lstStartstation.Items.Clear();

                    foreach (SwissTransport.Station station in start)
                    {
                        if (station.Name != null)
                        {
                            lstStartstation.Items.Add(station.Name);
                        }
                    }
                }
                catch
                {
                    MessageConnectionError();
                }
            }
            else if(sender == txtStation)
            {
                string station = txtStation.Text;

                SwissTransport.Transport stationConnetions = new SwissTransport.Transport();
                try
                {
                    List<SwissTransport.Station> stationList = stationConnetions.GetStations(station).StationList;

                    lstSuggestionsStation.Items.Clear();

                    foreach (SwissTransport.Station oneStation in stationList)
                    {
                        if(oneStation.Name != null)
                        {
                            lstSuggestionsStation.Items.Add(oneStation.Name);
                        }
                    }
                }
                catch
                {
                    MessageConnectionError();
                }
            }
            else
            {
                try
                {
                    List<SwissTransport.Station> end = StationConnetions.GetStations(endStation).StationList;

                    lstEndstation.Items.Clear();

                    foreach (SwissTransport.Station station in end)
                    {
                        if (station.Name != null)
                        {
                            lstEndstation.Items.Add(station.Name);
                        }
                    }
                }
                catch
                {
                    MessageConnectionError();
                }
            }
        }

        private void LstEndstation_Click(object sender, EventArgs e)
        {
            if(lstEndstation.Items.Count != 0)
            {
                txtEndstation.Text = lstEndstation.SelectedItem.ToString();
            }
        }

        private void LstStartstation_Click(object sender, EventArgs e)
        {
            if(lstStartstation.Items.Count != 0)
            {
                txtStartstation.Text = lstStartstation.SelectedItem.ToString();
            }
        }

        private void BtnSuggestionDelete_Click(object sender, EventArgs e)
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

        private void ClearAllTabOne()
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

        private void ClearAllTabTwo()
        {
            txtStation.Clear();
            dgvOutputStation.Rows.Clear();
            lstSuggestionsStation.Items.Clear();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            nbrHour.Value = DateTime.Now.Hour;
            nbrMinute.Value = DateTime.Now.Minute;
        }

        private void BtnSearchStation_Click(object sender, EventArgs e)
        {
            string station = txtStation.Text;

            SwissTransport.Transport StationConnetions = new SwissTransport.Transport();
            try
            {
                List<SwissTransport.Station> stationList = StationConnetions.GetStations(station).StationList;
                if (stationList.Count != 0)
                {
                    //Enthält das erste Objekt der Klasse Station von der Liste stationList
                    SwissTransport.Station UsedStation = stationList[0];

                    //Erstellt eine Liste welche Objekte der Klasse StationBoard beinhaltet, welche mit dem Namen und der Id der UsedStation übereinstimmen
                    List<SwissTransport.StationBoard> EntriesConnections = StationConnetions.GetStationBoard(UsedStation.Name, UsedStation.Id).Entries;

                    //Enthält das Objekt der Klasse Station, welches mit dem Namen und der Id der UsedStation übereinstimmt
                    SwissTransport.Station EntriesStation = StationConnetions.GetStationBoard(UsedStation.Name, UsedStation.Id).Station;

                    dgvOutputStation.Rows.Clear();

                    if (EntriesConnections.Count != 0)
                    {
                        foreach (SwissTransport.StationBoard stationBoard in EntriesConnections)
                        {
                            dgvOutputStation.Rows.Add(EntriesStation.Name, stationBoard.To, stationBoard.Stop.Departure.ToShortTimeString(), stationBoard.Category, stationBoard.Number);
                        }
                    }
                    else
                    {
                        MessageError();
                    }
                }
                else
                {
                    MessageError();
                }
            }
            catch
            {
                MessageConnectionError();
            }
        }

        //Enthält die Ausgabe bei einer fehlerhaften Eingabe
        private void MessageError()
        {
            MessageBox.Show("Keine Anschlüsse gefunden.\nÜberprüfen Sie Ihre Eingabe.");
        }

        //Enthält die Ausgabe, wenn die Daten über die API nicht geholt werden konnten.
        private void MessageConnectionError()
        {
            MessageConnectionError();
        }

        private void TbcChangeView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bestimmen auf welcher Ansicht der Benutzer ist, um den AcceptButton und den CancelButton zu setzen
            if(tbcChangeView.SelectedTab == sdStation)
            {
                AcceptButton = btnSearchStation;
                CancelButton = btnSuggestionsDeleteTab2;
                txtStation.Focus();
            }
            else
            {
                AcceptButton = btnSearch;
                CancelButton = btnSuggestionDelete;
                txtStartstation.Focus();
            }
        }

        private void BtnSuggestionsDeleteTab2_Click(object sender, EventArgs e)
        {
            ClearAllTabTwo();
        }

        private void LstSuggestionsStation_Click(object sender, EventArgs e)
        {
            if (lstSuggestionsStation.Items.Count != 0)
            {
                txtStation.Text = lstSuggestionsStation.SelectedItem.ToString();
            }
        }
    }
}
