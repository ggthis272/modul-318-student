using System;
using System.Net.Mail;
using System.Web;
using System.Windows.Forms;

namespace SwissTransportGUI
{
    public partial class VerbindungenControl : UserControl
    {
        private GUIFunctions _GUIFunctions = GUIFunctions.GetInstance();
        public Button AcceptButton { get { return btnSearch; } }
        public VerbindungenControl()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            timePicker.Value = DateTime.Now;
            lvConnections.Columns.Add("Von:", 150);
            lvConnections.Columns.Add("Gleis:", 70);
            lvConnections.Columns.Add("Abfahrt:", 60);
            lvConnections.Columns.Add("Nach:", 150);
            lvConnections.Columns.Add("Ankunft:", 60);
            lvConnections.Columns.Add("Dauer:", 70);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //DateTime aus den 2 DateTimePicker zu einem DateTime zusammenfügen.
            DateTime dtDate = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timePicker.Value.Hour, timePicker.Value.Minute, 0);
            _GUIFunctions.DisplayConnections(lvConnections, cbVon.Text, cbNach.Text, dtDate);
        }

        private async void CbVon_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbVon);
        }

        private async void CbNach_TextChanged(object sender, EventArgs e)
        {
            await _GUIFunctions.SearchStationsHelper(cbNach);
        }

        private void BtnSwap_Click(object sender, EventArgs e)
        {
            _GUIFunctions.SwapConnectionPoints(cbVon, cbNach);
        }

        private void Ebutton_Click(object sender, EventArgs e)
        {
            string allah = lvConnections.Items.ToString();
            if (ETextbox.Text == "")
                MessageBox.Show("Bitte geben Sie eine Email-Adresse ein!");
            else
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("marco_rocchinotti@hotmail.com"); //Absender
                    mail.To.Add(new MailAddress(Convert.ToString(this.ETextbox))); //Empfänger
                    mail.Subject = "Fahrplan";
                    mail.Body = "Die Liste - " + allah;
                    mail.IsBodyHtml = true;
                    SmtpClient SmtpServer = new SmtpClient();//SMTP Server
                    SmtpServer.Host = "smtp.live.com";
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("marco_rocchinotti@hotmail.com", "Tsec1810");//Anmeldedaten für den SMTP Server
                    SmtpServer.EnableSsl = true;
                    SmtpServer.Send(mail);//Senden
                    MessageBox.Show("Email versendet");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lblVon_Click(object sender, EventArgs e)
        {

        }

        private void lblDatum_Click(object sender, EventArgs e)
        {

        }

        private void cbVon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

