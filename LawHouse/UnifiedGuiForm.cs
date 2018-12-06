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
using DataAccess;
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


        //Tab index 1 //Hvad der sker når man klikker på tabs'ne
        private void btn_Create_Click(object sender, EventArgs e)
        {
            Controller.CreateSag(txt_Sag_titel.Text, txt_Sag_StartDato.Text, Datetimepicker_Sag_slutdato.Text, txt_Sag_kørsel.Text, txt_Sag_time.Text, txt_Sag_SagsBeskrivelse.Text, txt_Sag_InterneNoter.Text, Convert.ToInt32(txt_Sag_KlientNr.Text), (int)Sag_drop_MedarbejderNr.SelectedValue, (int)Sag_drop_YdelseTypeNr.SelectedValue);
            MessageBox.Show("Sagen er nu oprette, du kan finde den i sags oversigt");
        }

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
        //Koden under er ikke noget der har med nogle funktionelle krav at gøre, 
        //det er lavt så man kan skifte visningen af kolonner, alt efter om det er sag, klient osv.
        //Der er tilføjet en ekstra kolonne, fordi man ikke kan skjule den primære kolonnen
        private void btn_Update_Click(object sender, EventArgs e)//Daniella (?)
        {
            foreach (object item in theObjectListView.Objects)
            {

                if (item is Sag)
                {
                    Controller.UpdateSag(item);

                }
                else if (item is Advokat)
                {
                    Controller.UpdateAdvokat(item);
                }
                else if (item is Ydelse)
                {
                    Controller.UpdateYdelse(item);
                }
                else if (item is Klient)
                {
                    Controller.UpdateKLient(item);
                }

            }
            MessageBox.Show("færdig");
        }
        private void combobox_hvad_type_SelectedIndexChanged(object sender, EventArgs e) //Daniella(?)
        {
            ListItems listItem = (ListItems)combobox_hvad_type.SelectedItem;
            switch (listItem.What_type)
            {

                case "Klient":
                    theObjectListView.SetObjects(Controller.GetAllKlient());
                    foreach (var item in theObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    KlientNr.IsVisible = true;
                    Navn.IsVisible = true;
                    Adresse.IsVisible = true;
                    TelefonNr.IsVisible = true;
                    break;

                case "Sag":
                    theObjectListView.SetObjects(Controller.GetAllSag());
                    foreach (var item in theObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    SagsNr.IsVisible = true;
                    Arbejdstitel.IsVisible = true;
                    StartDate.IsVisible = true;
                    Slutdate.IsVisible = true;
                    TimeEstimat.IsVisible = true;
                    SagsBeskrivelse.IsVisible = true;
                    InterneNoter.IsVisible = true;
                    KlientNr.IsVisible = true;
                    MedarbejderNr.IsVisible = true;
                    YdelsesTypeNr.IsVisible = true;
                    break;
                case "Advokat":
                    theObjectListView.SetObjects(Controller.GetAllAdvokat());
                    foreach (var item in theObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    MedarbejderNr.IsVisible = true;
                    Advokat_navn.IsVisible = true;
                    break;
                case "Ydelse":
                    theObjectListView.SetObjects(Controller.GetAllYdelses());
                    foreach (var item in theObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    YdelsesNr.IsVisible = true;
                    StartDate.IsVisible = true;
                    YdelseBeskrivelse.IsVisible = true;
                    Pris.IsVisible = true;
                    Timer.IsVisible = true;
                    SagsNr.IsVisible = true;
                    AdvokatID.IsVisible = true;
                    break;
            }
            theObjectListView.RebuildColumns();
        }
        private void UnifiedGuiForm_Load(object sender, EventArgs e)//DO NOT (?) delete dis
        {

        }

        //Juilus Herunder

        // ObjectListView myObjectListView;
        private void buttomAddNewObject_Click(object sender, EventArgs e) //virker ikke da den skal skifte til en ikke-eksisterende tab
        {
            string[] tabsToHide = new string[0]; //Debug
            hideTabs(tabsToHide); //Debug
            TabPage toSwitchTo = null;
            switch (DynamicTabControl.SelectedTab.Name)
            {
                case "Sag":
                    toSwitchTo = Opret_sag;
                    break;
                case "Advokat":
                    toSwitchTo = Opret_advokat;
                    break;
                case "Klient":
                    toSwitchTo = Opret_klient;
                    break;
                case "Ydelse":
                    toSwitchTo = Opret_ydelse;
                    break;
            }
            toSwitchTo = Opret_sag;//debug
            DynamicTabControl.SelectedTab = toSwitchTo;
        }

        private void hideTabs(string[] tabsToHide)
        {
            //
            tabsToHide = new string[4];
            tabsToHide[0] = "Opret_sag";
            tabsToHide[1] = "Opret_advokat";
            tabsToHide[2] = "Opret_klient";
            tabsToHide[3] = "Opret_ydelse";
            // Temp. Debug
            foreach (string tabKey in tabsToHide)
            {
                DynamicTabControl.TabPages.RemoveByKey(tabKey);
            }
        }

        private void buttonHelpMe_Click(object sender, EventArgs e)
        {
            //open help for current page
        }

        private void buttonAnnuller_Click(object sender, EventArgs e)
        {
            //Discard changes
        }

        private void buttomSave_Click(object sender, EventArgs e)//stjålet fra btn_Update_Click / Daniella
        {
            foreach (object item in myObjectListView.Objects)
            {
                if (item is Sag)
                {
                    Controller.UpdateSag(item);

                }
                else if (item is Advokat)
                {
                    Controller.UpdateAdvokat(item);
                }
                else if (item is Ydelse)
                {
                    Controller.UpdateYdelse(item);
                }
                else if (item is Klient)
                {
                    Controller.UpdateKLient(item);
                }
            }
            MessageBox.Show("Færdig");
        }

        private void buttomRefresh_Click(object sender, EventArgs e)
        {
            //reload current objectViewList
        }

        private void myObjectListView_SelectedIndexChanged(object sender, EventArgs e)//delete dis (?)
        {

        }
    }
}

