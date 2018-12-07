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
    public partial class ExperimentalForm : Form
    {
        private List<string> tabsToHideAtStartup;
        public ExperimentalForm()
        {
            InitializeComponent();//Her oprettes formen

            tabsToHideAtStartup = new List<string>();
            tabsToHideAtStartup.Add("Opret_sag");
            tabsToHideAtStartup.Add("Opret_advokat");
            tabsToHideAtStartup.Add("Opret_klient");
            tabsToHideAtStartup.Add("Opret_ydelse");
            tabsToHideAtStartup.Add("tabDebugTab");
            hideTabs(tabsToHideAtStartup);

        }
        //
        //TabControler = dynamicTabControl
        //
        //
        private void ExperimentalForm_Load(object sender, EventArgs e)
        {
            
        }

        // ObjectListView myObjectListView;
        private void buttomAddNewObject_Click(object sender, EventArgs e)
        {
            TabPage toSwitchTo = null;
            switch (dynamicTabControl.SelectedTab.Name)
            {
                case "Sag":
                    dynamicTabControl.TabPages.Insert(dynamicTabControl.TabPages.Count, tabOpretSag);
                    toSwitchTo = tabOpretSag;
                    break;
                case "Advokat":
                    dynamicTabControl.TabPages.Insert(dynamicTabControl.TabPages.Count, tabOpretAdvokat);
                    toSwitchTo = tabOpretAdvokat;
                    break;
                case "Klient":
                    dynamicTabControl.TabPages.Insert(dynamicTabControl.TabPages.Count, tabOpretKlient);
                    toSwitchTo = tabOpretKlient;
                    break;
                case "Ydelse":
                    dynamicTabControl.TabPages.Insert(dynamicTabControl.TabPages.Count, tabOpretYdelse);
                    toSwitchTo = tabOpretYdelse;
                    break;
            }
            dynamicTabControl.TabPages.Insert(dynamicTabControl.TabPages.Count, tabOpretSag); //Debug
            toSwitchTo = tabOpretSag;//debug
            dynamicTabControl.SelectedTab = toSwitchTo;
        }

        private void hideTabs(List<string> tabsToHide)
        {
            foreach (string tabKey in tabsToHide)
            {
                dynamicTabControl.TabPages.RemoveByKey(tabKey);
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
        }//Ved ikke om den faktisk gemmer, eller om den bare refresher

        private void buttomRefresh_Click(object sender, EventArgs e)
        {
            //reload current objectViewList
        }

        private void myObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dropdownCombobox_SelectedIndexChanged(object sender, EventArgs e) //Daniella(?)
        {
            ListItems listItem = (ListItems)dropdownCombobox.SelectedItem;
            switch (listItem.What_type)
            {

                case "Klient":
                    myObjectListView.SetObjects(Controller.GetAllKlient());
                    foreach (var item in myObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    KlientNr.IsVisible = true;
                    Navn.IsVisible = true;
                    Adresse.IsVisible = true;
                    TelefonNr.IsVisible = true;
                    break;

                case "Sag":
                    myObjectListView.SetObjects(Controller.GetAllSag());
                    foreach (var item in myObjectListView.AllColumns)
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
                    myObjectListView.SetObjects(Controller.GetAllAdvokat());
                    foreach (var item in myObjectListView.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    MedarbejderNr.IsVisible = true;
                    Advokat_navn.IsVisible = true;
                    break;
                case "Ydelse":
                    myObjectListView.SetObjects(Controller.GetAllYdelses());
                    foreach (var item in myObjectListView.AllColumns)
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
            myObjectListView.RebuildColumns();
        }//Har ikke nærlæst denne

    }
    public partial class ExperimentalForm //Daniella unlese othervise noted
    {
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
    }
}
