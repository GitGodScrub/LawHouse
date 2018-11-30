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
using System.Globalization;

namespace GUI
{
    public partial class OpretYdelse : Form
    {
        public OpretYdelse()
        {
            InitializeComponent();
            txt_startdato.Text = DateTime.Today.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controller.CreateYdelse(txt_startdato.Text, txt_beskrivelse.Text, txt_Pris.Text, txt_timer.Text, Convert.ToInt32(txt_sagsNr.Text), Convert.ToInt32(txt_advokatId.Text));
            MessageBox.Show("Test");
           
        }
    }
}
