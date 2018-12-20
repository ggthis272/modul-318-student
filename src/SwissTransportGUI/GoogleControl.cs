using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class GoogleControl : UserControl
    {
        Transport transport = new Transport();
        Coordinate coordinate = new Coordinate();
        public GoogleControl()
        {
            InitializeComponent();
        }

        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);
            return date3.ToString("dd.MM.yyyy");
        }
        private string Get_Time(string time1) //Zeit kommt so 13:25:00 und die letzen 2 Stellen :00 werden hier gelöscht.
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);
            return time2;
        }
        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            WEB_google_maps.Navigate(url);
        }
            private void Get_Stations(string text, ListBox listBox)
            {
                if (text.Length >= 3)
                {
                    listBox.Items.Clear();
                    Stations stations = transport.GetStations(text);
                    foreach (Station station in stations.StationList)
                    {
                        listBox.Items.Add(station.Name);
                        listBox.Visible = true;
                        listBox.BringToFront();
                    }
                }
            }


            public IButtonControl AcceptButton { get; internal set; }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TXT_station.Text != string.Empty)
            {
                Stations stations = transport.GetStations(TXT_station.Text);
                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Ort ein!");
            }
        }

        private void TXT_station_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(TXT_station.Text, LBX_station);

        }
    }
}
