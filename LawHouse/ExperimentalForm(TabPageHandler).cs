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
using BusinessLogic;
using DataAccess;
using DataClassLib;

namespace GUI
{
    public partial class ExperimentalForm //Julius //skal også indlæse relevant data
    {
        public void makeNewTabPageController()
        {
            List<string> keyOfNewTabs = new List<string>
            {
                "Sag", "Advokat", "Klient", "Ydelse"
            };
            Dictionary<string, string> tabsToAdd = ReturnTabsToAdd(keyOfNewTabs);

            foreach (string currentKey in keyOfNewTabs)
            {
                string currentValue = tabsToAdd[currentKey];
                TabPage newPage = LoadNewTabPageFromTemplate(currentKey, currentValue);
                ReplaceTabPage(newPage);
            }
        }
        private Dictionary<string, string> ReturnTabsToAdd(List<String> tabsToAdd)
        {
            Dictionary<string, string> dictionaryOfNewTabs;
            dictionaryOfNewTabs = new Dictionary<string, string>();
            foreach (string Key in tabsToAdd)
            {
                dictionaryOfNewTabs.Add(("tab" + Key), Key);
            }
            return dictionaryOfNewTabs;
        }
        private void ReplaceTabPage(TabPage newPage)
        {
            int targetLocation;
            try
            {
                targetLocation = dynamicTabControl.TabPages.IndexOfKey(newPage.Name);
                dynamicTabControl.TabPages.RemoveByKey(newPage.Name);
            }
            catch (Exception e)
            {
                targetLocation = dynamicTabControl.TabPages.Count;
                throw new Exception("No tab found by that name, making new tab");
            }
            dynamicTabControl.TabPages.Insert(targetLocation, newPage);
        }
        private TabPage LoadNewTabPageFromTemplate(string TabName, string TabText)
        {
            TabPage newTabPage = new TabPage();
            newTabPage.Name = TabName;
            newTabPage.Text = TabText;
            TabBuilderHelper(newTabPage);
            //newTabPage.TabIndex = 10; //ved ikke hvad denne gør
            return newTabPage;
        }
        private void TabBuilderHelper(TabPage newTabPage)
        {
            /*
            string currentPageName = Convert.ToString(newTabPage.Name);
            newTabPage.Controls.Add(GetItem(currentPageName, "buttonHelpMe"));
            newTabPage.Controls.Add(GetItem(currentPageName, "buttomAddNewObject"));
            newTabPage.Controls.Add(GetItem(currentPageName, "buttonAnnuller"));
            newTabPage.Controls.Add(GetItem(currentPageName, "buttomSave"));
            newTabPage.Controls.Add(GetItem(currentPageName, "dropdownCombobox"));
            newTabPage.Controls.Add(GetItem(currentPageName, "buttomRefresh"));
            newTabPage.Controls.Add(GetItem(currentPageName, "myObjectListView"));
            */
            newTabPage.UseVisualStyleBackColor = true;
        }

        private void LoadVariablesToUseInTabs()
        {
            //opretsag
            //txt_Sag_StartDato.Text =

            
        }



        //Julius, old code
        //Prototype
        /* 
        private void TabBuilderHelper(TabPage newTabPage) //Old Prototype
        {
            newTabPage.Controls.Add(this.buttonHelpMe);
            newTabPage.Controls.Add(this.buttomAddNewObject);
            newTabPage.Controls.Add(this.buttonAnnuller);
            newTabPage.Controls.Add(this.buttomSave);
            newTabPage.Controls.Add(this.dropdownCombobox);
            newTabPage.Controls.Add(this.buttomRefresh);
            newTabPage.Controls.Add(this.myObjectListView);
            newTabPage.UseVisualStyleBackColor = true;
        }
        */
        // Proof-Of-Concept
        /*
        public void MakeNewTabs() 
        {
            TabControl thisTabControl;
            TabPage basicTabPage;

            thisTabControl = new TabControl(); // ny TabControl
            basicTabPage = new TabPage(); // ny TabPage

            //thisTabControl.Controls.Add(basicTabPage);

            TabPage advancedTabPage;
            advancedTabPage = basicTabPage; //sætter den nye til at være den samme
            //advancedTabPage = (stuff+advancedTabPage)
            thisTabControl.Controls.Add(advancedTabPage);
            // [...]
            //nu vil vi gerne opdatere
            TabPage newAdvancedTabPage;
            newAdvancedTabPage = basicTabPage;
            //newAdvancedTabPage = (stuff+newAdvancedTabPage)
            int targetLocation = thisTabControl.TabPages.IndexOf(advancedTabPage);
            thisTabControl.TabPages.Remove(advancedTabPage);
            thisTabControl.TabPages.Insert(targetLocation, newAdvancedTabPage);

            Controls.Add(thisTabControl); //Tilføjer tabcontrol til formen
        }
        */
        //Virker ikke da TabPage virker som en REFERANCE og ikke et object
        /*
        public void SetTabs()
        {
            TabPage basicTabPage;
            basicTabPage = CreateDefaultTabPage();

            TabPage tabSag = CreateTabPageFromTemplate(basicTabPage);
            tabSag.Text = "Sag";
            tabSag.Name = ("tab" + tabSag.Text);
            ReplaceTabPage(tabSag);

            TabPage tabAdvokat = CreateTabPageFromTemplate(basicTabPage);
            tabSag.Text = "Advokat";
            tabSag.Name = ("tab" + tabSag.Text);
            ReplaceTabPage(tabAdvokat);

            TabPage tabKlient = CreateTabPageFromTemplate(basicTabPage);
            tabSag.Text = "Klient";
            tabSag.Name = ("tab" + tabSag.Text);
            ReplaceTabPage(tabKlient);

            TabPage tabYdelse = CreateTabPageFromTemplate(basicTabPage);
            tabSag.Text = "Ydelse";
            tabSag.Name = ("tab" + tabSag.Text);
            ReplaceTabPage(tabYdelse);
        }

        private void ReplaceTabPage(TabPage newPage)
        {
            int targetLocation = dynamicTabControl.TabPages.IndexOfKey(newPage.Name);
            dynamicTabControl.TabPages.RemoveByKey(newPage.Name);
            dynamicTabControl.TabPages.Insert(targetLocation, newPage);
        }
        private TabPage CreateDefaultTabPage()
        {
            TabPage basicTabPage = new TabPage();
            //
            basicTabPage = tabClickHereFirst;
            //
            return basicTabPage;
        }
        private TabPage CreateTabPageFromTemplate(TabPage template)
        {
            TabPage newPage;
            newPage = template;
            return newPage;
        }
        */
    }
}
