using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BrightIdeasSoftware;

namespace GUI
{
    public partial class ExperimentalForm //Julius(Port) - andre(design)
    {
        //Laver nye Items til brug i GUI'en
        public object GetItem(string Name, string Type)//skal måske laves om
        {
            object newItem = new object();
            switch (Type)
            {
                case "buttonHelpMe":
                    newItem = GetButtonHelpMe(Name);
                    break;
                case "buttomAddNewObject":
                    newItem = GetButtomAddNewObjectButton(Name);
                    break;
                case "buttonAnnuller":
                    newItem = GetButtonAnnuller(Name);
                    break;
                case "buttomSave":
                    newItem = GetButtomSave(Name);
                    break;
                case "buttomRefresh":
                    newItem = GetButtomRefresh(Name);
                    break;

                case "dropdownCombobox":
                    newItem = GetDropdownCombobox(Name);
                    break;

                case "myObjectListView":
                    newItem = GetMyObjectListView(Name);
                    break;
            }
            return newItem;
        }

        private ObjectListView GetMyObjectListView(string name)
        {
            throw new NotImplementedException();
        }

        private ComboBox GetDropdownCombobox(string name)
        {
            throw new NotImplementedException();
        }

        private Button GetButtomRefresh(string name)
        {
            throw new NotImplementedException();
        }

        private Button GetButtomSave(string name)
        {
            throw new NotImplementedException();
        }

        private Button GetButtonAnnuller(string name)
        {
            throw new NotImplementedException();
        }

        private Button GetButtomAddNewObjectButton(string Name)
        {
            Button newButton = new Button();
            this.buttomAddNewObject.Location = new System.Drawing.Point(395, 8);
            this.buttomAddNewObject.Margin = new System.Windows.Forms.Padding(5);
            this.buttomAddNewObject.Name = Name;
            this.buttomAddNewObject.Size = new System.Drawing.Size(149, 45);
            this.buttomAddNewObject.TabIndex = 5;
            this.buttomAddNewObject.Text = "AddNewObject";
            this.buttomAddNewObject.UseVisualStyleBackColor = true;
            //this.buttomAddNewObject.Click += new System.EventHandler(this.buttomAddNewObject_Click);
            return newButton;
        }
        private Button GetButtonHelpMe(string name)
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(554, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(76, 76);
            newButton.TabIndex = 6;
            newButton.Text = "HelpMe";
            newButton.UseVisualStyleBackColor = true;
            //newButton.Click += new System.EventHandler(this.buttonHelpMe_Click);
            return newButton;
        }



        /*
        public Button GetButton(string Name, string ButtonType)//Old
        {
            Button newButton = new Button();
            switch (ButtonType)
            {
                case "GetHelpButton":
                    break;
                case "buttomAddNewObject":
                    break;
                case "buttonAnnuller":
                    break;
                case "buttomSave":
                    break;
                case "buttomRefresh":
                    break;
            }
            return newButton;
        }
        */
    }
}
