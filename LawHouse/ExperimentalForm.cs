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
    public partial class ExperimentalForm : Form //GUI Remake, by Julius
    {
        public ExperimentalForm()
        {
            InitializeComponent();//Her oprettes formen
            List<string> tabsToHideAtStartup = new List<string>();
            tabsToHideAtStartup.Add("tabOpretSag");
            tabsToHideAtStartup.Add("tabOpretAdvokat");
            tabsToHideAtStartup.Add("tabOpretKlient");
            tabsToHideAtStartup.Add("tabOpretYdelse");
            hideTabs(tabsToHideAtStartup);
        }
        private void ExperimentalForm_Load(object sender, EventArgs e) //idk what this does lol
        {
            comboboxOversigt.DataSource = Controller.GetAllItems();
            comboboxOversigt.DisplayMember = "What_type";
            /*
            this.myObjectListView = GetMyObjectListView("myObjectListView");
            this.comboboxOversigt = GetCombobox("comboboxOversigt");
            this.buttomAddNewObject = GetButtomAddNewObjectButton("buttomAddNewObject");
            this.buttomRefresh = GetButtomRefresh("buttomRefresh");
            this.buttomSave = GetButtomSave("buttomSave");
            this.buttonAnnuller = GetButtonAnnuller("buttonAnnuller");
            this.buttonHelpMe = GetButtonHelpMe("buttonHelpMe");
            */
        }
        
        private void hideTabs(List<string> tabsToHide)
        {
            foreach (string tabKey in tabsToHide)
            {
                dynamicTabControl.TabPages.RemoveByKey(tabKey);
            }
        } 
        private ListItems oversigtGetSelectedItem()//Daniella //It just works, okay?
        {
            ListItems toReturn = (ListItems)comboboxOversigt.SelectedItem;
            return toReturn;
        }
        private void CommitObjectViewListChanges()//Daniella
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
                    Controller.UpdateKlient(item);
                }
            }
        }

        private void OversigtHideAllColums()//Daniella
        {
            foreach (var item in myObjectListView.AllColumns)
            {
                item.IsVisible = false;
            }
        }
        private void OversigtRefresh() //Daniella //Denne reloader 
        {
            ListItems currentSelected = (ListItems)oversigtGetSelectedItem();
            switch (currentSelected.What_type)
            {
                case "Klient":
                    myObjectListView.SetObjects(Controller.GetAllKlient());
                    OversigtHideAllColums();
                    KlientNr.IsVisible = true;
                    Navn.IsVisible = true;
                    Adresse.IsVisible = true;
                    TelefonNr.IsVisible = true;
                    break;
                case "Sag":
                    myObjectListView.SetObjects(Controller.GetAllSag());
                    OversigtHideAllColums();
                    SagsNr.IsVisible = true;
                    Arbejdstitel.IsVisible = true;
                    StartDato.IsVisible = true;
                    SlutDato.IsVisible = true;
                    TimeEstimat.IsVisible = true;
                    SagsBeskrivelse.IsVisible = true;
                    InterneNoter.IsVisible = true;
                    KlientNr.IsVisible = true;
                    MedarbejderNr.IsVisible = true;
                    YdelsesTypeNr.IsVisible = true;
                    break;
                case "Advokat":
                    myObjectListView.SetObjects(Controller.GetAllAdvokat());
                    OversigtHideAllColums();
                    MedarbejderNr.IsVisible = true;
                    Advokat_navn.IsVisible = true;
                    break;
                case "Ydelse":
                    myObjectListView.SetObjects(Controller.GetAllYdelses());
                    OversigtHideAllColums();
                    YdelsesNr.IsVisible = true;
                    StartDato.IsVisible = true;
                    YdelseBeskrivelse.IsVisible = true;
                    Pris.IsVisible = true;
                    Timer.IsVisible = true; //Fuck
                    SagsNr.IsVisible = true;
                    AdvokatID.IsVisible = true;
                    break;
            }
            myObjectListView.RebuildColumns();
        }
    }
}
