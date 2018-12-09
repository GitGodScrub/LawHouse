using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using DataClassLib;

namespace GUI
{
    public partial class ExperimentalForm //Daniella unlese othervise noted
    {
        /*
        //Kode til Opret*

        //Koden under til opret advokat
        private void btn_CreateAdvokat_Click(object sender, EventArgs e)
        {
            string navn = txt_Advokat_AdvokatNavn.Text;
            Controller.CreateAdvokat(navn);
            MessageBox.Show("Oprettet.");
            txt_Advokat_AdvokatNavn.Clear();
        }
        private void btn_AddSpecialToAdvokat_Click(object sender, EventArgs e)
        {
            string specialeNavn = txt_Advokat_SpecialeNavn.Text;
            int advokatId = Convert.ToInt32(txt_Advokat_AdvokatId.Text);
            Controller.AddSpecialToAdvokat(specialeNavn, advokatId);
            MessageBox.Show("Speciale tilføjet.");
            txt_Advokat_SpecialeNavn.Clear();
            txt_Advokat_AdvokatId.Clear();
        }

        //Koden under er til Klient
        private void btn_OpretKlient(object sender, EventArgs e)
        {
            string navn = Txt_Klient_navn.Text;
            string Adresse = Txt_Klient_Adresse.Text;
            string TelefonNr = Txt_Klient_TelefonNr.Text;
            Controller.CreateKlient(navn, Adresse, TelefonNr);
            MessageBox.Show("Oprettet");
            Txt_Klient_navn.Clear();
            Txt_Klient_Adresse.Clear();
            Txt_Klient_TelefonNr.Clear();
        }
        private void btn_opret_ydelse(object sender, EventArgs e)
        {
            Controller.CreateYdelse(txt_ydelse_startdato.Text, txt_ydelse_beskrivelse.Text, txt_ydelse_Pris.Text, txt_ydelse_timer.Text, Convert.ToInt32(txt_ydelse_sagsNr.Text), Convert.ToInt32(txt_ydelse_AdvokatID.Text));
            MessageBox.Show("Ydelsen er nu oprettet");
        }

        //Tab index 1 //Hvad der sker når man klikker på tabs'ne
        //Opret sag kode(?)
        private void btn_Create_Click(object sender, EventArgs e)
        {
            Controller.CreateSag(txt_Sag_titel.Text, txt_Sag_StartDato.Text, Datetimepicker_Sag_slutdato.Text, txt_Sag_kørsel.Text, txt_Sag_time.Text, txt_Sag_SagsBeskrivelse.Text, txt_Sag_InterneNoter.Text, Convert.ToInt32(txt_Sag_KlientNr.Text), (int)Sag_drop_MedarbejderNr.SelectedValue, (int)Sag_drop_YdelseTypeNr.SelectedValue);
            MessageBox.Show("Sagen er nu oprette, du kan finde den i sags oversigt");
        }
        */
    }//Har ikke nærlæst denne
}
