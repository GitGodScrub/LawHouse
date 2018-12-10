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
            List<string> tabsToHideAtStartup = new List<string>();
            tabsToHideAtStartup.Add("Opret_sag");
            tabsToHideAtStartup.Add("Opret_advokat");
            tabsToHideAtStartup.Add("Opret_klient");
            tabsToHideAtStartup.Add("Opret_ydelse");
            tabsToHideAtStartup.Add("tabOversigt");
            hideTabs(tabsToHideAtStartup);

        }
        //
        //TabControler = dynamicTabControl
        //ObjectListView myObjectListView;
        //
        private void ExperimentalForm_Load(object sender, EventArgs e) //idk what this does lol
        {

        }
        
        private void hideTabs(List<string> tabsToHide)
        {
            foreach (string tabKey in tabsToHide)
            {
                dynamicTabControl.TabPages.RemoveByKey(tabKey);
            }
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
    }
}
