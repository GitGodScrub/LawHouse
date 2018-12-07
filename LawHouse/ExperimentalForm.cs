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
        public ExperimentalForm()
        {
            InitializeComponent();//Her oprettes formen

            List<string> tabsToHide = new List<string>();
            tabsToHide.Add("Opret_sag");
            tabsToHide.Add("Opret_advokat");
            tabsToHide.Add("Opret_klient");
            tabsToHide.Add("Opret_ydelse");
            tabsToHide.Add("tabDebugTab");
            hideTabs(tabsToHide);

        }
        //
        //TabControler = dynamicTabControl
        //
        //
        private void ExperimentalForm_Load(object sender, EventArgs e)
        {
            
        }

        // ObjectListView myObjectListView;
        private void buttomAddNewObject_Click(object sender, EventArgs e) //virker ikke da den skal skifte til en ikke-eksisterende tab
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
        }

        private void buttomRefresh_Click(object sender, EventArgs e)
        {
            //reload current objectViewList
        }

        private void myObjectListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
