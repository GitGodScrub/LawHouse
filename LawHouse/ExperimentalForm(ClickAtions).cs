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
    public partial class ExperimentalForm
    {
        //When the user clicks something on the GUI, the event is handled here
        private void buttomAddNewObject_Click(object sender, EventArgs e)//original by Daniella, new by Julius
        {
            TabPage toSwitchTo = null;
            ListItems currentSelected = oversigtGetSelectedItem();
            switch (currentSelected.What_type)
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
            dynamicTabControl.SelectedTab = toSwitchTo;
        }
        private void buttonHelpMe_Click(object sender, EventArgs e) //open help for current page //ikke lavet
        {

        }
        private void buttonAnnuller_Click(object sender, EventArgs e)
        {
            buttomRefresh_Click(null, null);//Lol, virkelig dårlig kodestil
        }
        private void buttomRefresh_Click(object sender, EventArgs e)
        {
            if (comboboxOversigt.SelectedItem != null)
            {
                OversigtRefresh();
            }
            else
            {
                myObjectListView.RebuildColumns();
            }
        }
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
                    Controller.UpdateKlient(item);
                }
            }
        }
        private void comboboxOversigt_SelectedIndexChanged(object sender, EventArgs e) //Daniella //Denne bliver kaldt når man vælger en valgmuglighed
        {
            OversigtRefresh();
        }

    }
}
