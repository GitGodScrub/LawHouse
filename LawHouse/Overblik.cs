using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using DataClassLib;

namespace GUI
{
    public partial class Overblik : Form
    {
        public Overblik()
        {
            InitializeComponent();
            objectListView1.SetObjects(Controller.GetAllKlient());
            comboBox1.DataSource = Controller.GetAllItems();
            comboBox1.DisplayMember = "What_type";
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            //ListItems listItems = new ListItems();

           
            foreach (object item in objectListView1.Objects)
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
            MessageBox.Show("færdig");

        }

        //Koden under er ikke noget der har med nogle funktionelle krav at gøre, 
        //det er lavt så man kan skifte visningen af kolonner, alt efter om det er sag, klient osv.
        //Der er tilføjet en ekstra kolonne, fordi man ikke kan skjule den primære kolonnen
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ListItems listItem = (ListItems)comboBox1.SelectedItem;
            switch (listItem.What_type)
            {
                
                case "Klient":
                    objectListView1.SetObjects(Controller.GetAllKlient());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    KlientNr.IsVisible = true;
                    Navn.IsVisible = true;
                    Adresse.IsVisible = true;
                    TelefonNr.IsVisible = true;
                    break;

                case "Sag":
                    objectListView1.SetObjects(Controller.GetAllSag());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
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
                    objectListView1.SetObjects(Controller.GetAllAdvokat());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    MedarbejderNr.IsVisible = true;
                    Advokat_navn.IsVisible = true;
                    break;
                case "Ydelse":
                    objectListView1.SetObjects(Controller.GetAllYdelses());
                    foreach (var item in objectListView1.AllColumns)
                    {
                        item.IsVisible = false;
                    }
                    YdelsesNr.IsVisible = true;
                    StartDato.IsVisible = true;
                    YdelseBeskrivelse.IsVisible = true;
                    Pris.IsVisible = true;
                    Timer.IsVisible = true;
                    SagsNr.IsVisible = true;
                    AdvokatID.IsVisible = true;               
                    break;
            }
                objectListView1.RebuildColumns();
        }

    }
}

