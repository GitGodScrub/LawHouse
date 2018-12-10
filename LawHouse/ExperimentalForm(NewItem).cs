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
        //Man skal altid have "Basic Buttons"-so to say, som har events'ne på sig
        public object GetItem(string Name, string Type)//skal måske laves om, ny returtype
        {
            object newItem = new object();
            switch (Type)
            {
                case "buttonHelpMe":
                    newItem = GetButtonHelpMe(Name + Type);
                    break;
                case "buttomAddNewObject":
                    newItem = GetButtomAddNewObjectButton(Name + Type);
                    break;
                case "buttonAnnuller":
                    newItem = GetButtonAnnuller(Name + Type);
                    break;
                case "buttomSave":
                    newItem = GetButtomSave(Name + Type);
                    break;
                case "buttomRefresh":
                    newItem = GetButtomRefresh(Name + Type);
                    break;

                case "comboboxSelectOversigt":
                    newItem = GetCombobox(Name + Type);
                    break;

                case "myObjectListView":
                    newItem = GetMyObjectListView(Name + Type);
                    break;
            }
            return newItem;
        }

        private ObjectListView GetMyObjectListView(string name)
        {
            throw new NotImplementedException();
        }

        private ComboBox GetCombobox(string name)
        {
            throw new NotImplementedException();
        }

        private Button GetButtomRefresh(string name) //load form //bliver kaldt fra update som det er nu
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(8, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(89, 76);
            newButton.TabIndex = 1;
            newButton.Text = "Refresh";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomRefresh_Click);
            return newButton;
        }

        private Button GetButtomSave(string name) //update
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(107, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(121, 45);
            newButton.TabIndex = 3;
            newButton.Text = "Save";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomSave_Click);
            return newButton;
        }

        private Button GetButtonAnnuller(string name) //basically refresh
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(238, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(147, 45);
            newButton.TabIndex = 4;
            newButton.Text = "Annuller";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttonAnnuller_Click);
            return newButton;
        }

        private Button GetButtomAddNewObjectButton(string name) //skal måske cuttes, er måske overflødig
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(395, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(149, 45);
            newButton.TabIndex = 5;
            newButton.Text = "AddNewObject";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttomAddNewObject_Click);
            return newButton;
        }
        private Button GetButtonHelpMe(string name) //gud
        {
            Button newButton = new Button();
            newButton.Location = new System.Drawing.Point(554, 8);
            newButton.Margin = new System.Windows.Forms.Padding(5);
            newButton.Name = name;
            newButton.Size = new System.Drawing.Size(76, 76);
            newButton.TabIndex = 6;
            newButton.Text = "HelpMe";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += new System.EventHandler(this.buttonHelpMe_Click);
            return newButton;
        }
    }
}
