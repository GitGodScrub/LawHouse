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
    public partial class CreateAdvokatTester : Form
    {
        public CreateAdvokatTester()
        {
            InitializeComponent();
        }

        private void btn_AddSpecialToAdvokat_Click(object sender, EventArgs e)
        {
                    string specialeNavn = txt_SpecialeNavn.Text;
                    int advokatId = Convert.ToInt32(txt_AdvokatId.Text);
                    Controller.AddSpecialToAdvokat(specialeNavn, advokatId);
                    MessageBox.Show("Speciale tilføjet.");
                    txt_SpecialeNavn.Clear();
                    txt_AdvokatId.Clear();
        }
        private void btn_CreateAdvokat_Click(object sender, EventArgs e)
        {
                    string navn = txt_AdvokatNavn.Text;
                    Controller.CreateAdvokat(navn);
                    MessageBox.Show("Oprettet.");
                    txt_AdvokatNavn.Clear();
        }

      
    }
}
