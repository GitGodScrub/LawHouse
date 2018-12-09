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
        private void buttomRefresh_Click(object sender, EventArgs e)
        {
            //reload current objectViewList
        }

        private void myObjectListView_SelectedIndexChanged(object sender, EventArgs e)//  ?
        {

        }

        //Daniella's kommentarer  //Har ikke nærlæst disse
        //Koden under er ikke noget der har med nogle funktionelle krav at gøre, 
        //det er lavt så man kan skifte visningen af kolonner, alt efter om det er sag, klient osv.
        //Der er tilføjet en ekstra kolonne, fordi man ikke kan skjule den primære kolonnen
        private void buttomSave_Click(object sender, EventArgs e)// Daniella
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
        //Har ikke nærlæst denne
        private void dropdownCombobox_SelectedIndexChanged(object sender, EventArgs e) //Daniella?
        {
            /*
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
            */
        }//Har ikke nærlæst denne
    }
}
