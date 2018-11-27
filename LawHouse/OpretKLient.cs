using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace GUI
{
    public partial class OpretKLient : Form
    {
        public OpretKLient()
        {
            InitializeComponent();
        }

     
        

        private void Btn_CreateKLient_Click(object sender, EventArgs e)
        {
            string navn = Txt_navn.Text;
            string Adresse = Txt_Adresse.Text;
            string TelefonNr = Txt_TelefonNr.Text;
            Controller.CreateKlient(navn, Adresse, TelefonNr);
            MessageBox.Show("Oprettet");
            Txt_navn.Clear();
            Txt_Adresse.Clear();
            Txt_TelefonNr.Clear();
        }
    }
}
