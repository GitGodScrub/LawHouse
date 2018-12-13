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
using BrightIdeasSoftware;
using BusinessLogic;
using DataClassLib;

namespace GUI
{
    public partial class UnifiedGuiForm : Form
    {
        public UnifiedGuiForm()
        {
            InitializeComponent();

            //Denne kode er til at oprette sag
            txt_Sag_StartDato.Text = DateTime.Now.ToString("dd-MM-yyyy");
            // txt_Sag_StartDato.Text = DateTime.Today.ToString("dd-MM-yyyy-hh-mm-ss ", CultureInfo.InvariantCulture);
            // txt_Sag_StartDato.Text = DateTime.UtcNow.ToString("hh-mm-ss");
            Datetimepicker_Sag_slutdato.Format = DateTimePickerFormat.Custom;
            Datetimepicker_Sag_slutdato.MinDate = DateTime.Today;
            Datetimepicker_Sag_slutdato.CustomFormat = " ";

            Sag_drop_YdelseTypeNr.DataSource = Controller.GetAllYdelseType();
            Sag_drop_YdelseTypeNr.DisplayMember = "YdelsesNavn";
            YdelseType ydelseType = (YdelseType)Sag_drop_YdelseTypeNr.SelectedItem;
            Sag_drop_YdelseTypeNr.ValueMember = "YdelsesTypeNr";
            Sag_drop_MedarbejderNr.DataSource = Controller.GetAllAdvokatFromYdelse(ydelseType.YdelsesTypeNr);
            Sag_drop_MedarbejderNr.DisplayMember = "Navn";
            Sag_drop_MedarbejderNr.ValueMember = "AdvokatId";
            Sag_drop_MedarbejderNr.SelectedIndex = -1;

            //Denne kode er til oversigt over sag 
            theObjectListView.SetObjects(Controller.GetAllKlient());
            combobox_hvad_type.DataSource = Controller.GetAllItems();
            combobox_hvad_type.DisplayMember = "What_type";
        } //Startup

        private void UnifiedGuiForm_Load(object sender, EventArgs e)//DO NOT (?) delete dis
        {

        }

        
    }
}

