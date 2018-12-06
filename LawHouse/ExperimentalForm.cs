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
            InitializeComponent();
        }

        private void ExperimentalForm_Load(object sender, EventArgs e)
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
                    //toSwitchTo = Opret_sag;
                    break;
                case "Advokat":
                    //toSwitchTo = Opret_advokat;
                    break;
                case "Klient":
                    //toSwitchTo = Opret_klient;
                    break;
                case "Ydelse":
                    //toSwitchTo = Opret_ydelse;
                    break;
            }
            //toSwitchTo = Opret_sag;//debug
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
