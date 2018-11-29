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

namespace GUI
{
    public partial class New_case : Form
    {

        public New_case()
        {
            InitializeComponent();
            StartDato.Text = DateTime.Today.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);       
            Slutdato.Format = DateTimePickerFormat.Custom;
            Slutdato.MinDate = DateTime.Today;

            txt_YdelseTypeNr.DataSource = Controller.GetAllYdelseType();
            txt_YdelseTypeNr.DisplayMember = "YdelsesNavn";
            YdelseType ydelseType = (YdelseType)txt_YdelseTypeNr.SelectedItem;
            txt_YdelseTypeNr.ValueMember = "YdelsesTypeNr";
            txt_MedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
            txt_MedarbejderNr.DisplayMember= "Navn";
            txt_MedarbejderNr.ValueMember = "AdvokatId";
            txt_MedarbejderNr.SelectedIndex = -1;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {            
            Controller.CreateSag(txt_titel.Text, StartDato.Text, Slutdato.Text, txt_kørsel.Text, txt_time.Text,  txt_SagsBeskrivelse.Text , txt_InterneNoter.Text,Convert.ToInt32( txt_KlientNr.Text), (int)txt_MedarbejderNr.SelectedValue, (int)txt_YdelseTypeNr.SelectedValue);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Overblik overblik = new Overblik();
            overblik.Show();
        }

        private void btn_GoToFormCreateAdvokat_Click(object sender, EventArgs e)
        {
            CreateAdvokatTester advokatTester = new CreateAdvokatTester();
            advokatTester.Show();
        }

        private void Btn_CreateKlient_Click(object sender, EventArgs e)
        {
            OpretKLient KlientTester = new OpretKLient();
            KlientTester.Show();
        }

        private void txt_YdelseTypeNr_SelectedIndexChanged(object sender, EventArgs e)
        {
            YdelseType ydelseType = (YdelseType)txt_YdelseTypeNr.SelectedItem;
            txt_MedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
            txt_MedarbejderNr.SelectedIndex = -1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Ydelse ydelse = new Ydelse();
            ydelse.Show();
        }
    }
}
