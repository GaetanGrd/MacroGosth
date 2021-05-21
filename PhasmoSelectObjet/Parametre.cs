using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
namespace PhasmoSelectObjet
{
    public partial class Parametre : Form
    {
        public Parametre()
        {
            InitializeComponent();
        }

        public List<int> serialisationListeObjet(string Player)
        {
            //Recupere la valeur du joueur selectionner dans app.config et coupe la chaine
            //pour remplir une liste des objet 

            string obj = ConfigurationManager.AppSettings[Player];
            List<int> ListeObjet = new List<int>();
            int start = 0;
            while(obj.Substring(start,1) != ";")
            {
                int count = 0;
                while (obj.Substring(start + count,1) != ","&& (obj.Substring(start + count, 1) != ";"))
                {
                    count += 1;
                }
                if(obj.Substring(start,1) != ",")
                { 
                ListeObjet.Add(Convert.ToInt16(obj.Substring(start, count)));
                start += count;
                }
                else
                { start += 1; }
            }
            return ListeObjet;
        }

        public string DeserialisationListeObjet()
        {
            string ListeObjet="";
            bool test = true;

            for (int i = 0; i <= (CheckListeObjet.Items.Count - 1); i++)
            {
                if (CheckListeObjet.GetItemChecked(i))
                {
                    if (test)
                    {
                        ListeObjet += Convert.ToString(i);
                        test = false;
                    }
                    else
                    {
                        ListeObjet += "," +Convert.ToString(i);
                    }
                }
            }
            ListeObjet += ";";


            return ListeObjet;
        }

        private void Parametre_Load(object sender, EventArgs e)
        {
            txtBoxScreenRes.Text = ConfigurationManager.AppSettings["Screen_Resolution"];
            txtBoxDelay.Text = ConfigurationManager.AppSettings["Delay"];
            txtBoxSelectPlayer.Text = "Joueur 1";
        }


        private void txtBoxDelay_TextChanged(object sender, EventArgs e) //Changement du delay entre chaque deplacement de souris
        {
            if (txtBoxDelay.Text != "")
            { 
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Delay");
            config.AppSettings.Settings.Add("Delay", txtBoxDelay.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            }
        }
        private void txtBoxDelay_KeyPress(object sender, KeyPressEventArgs e) //empeche la saisie de caractere dans la textebox delay
        {
            if (Char.IsControl(e.KeyChar) || !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtBoxDelay_Enter(object sender, EventArgs e)
        {
            txtBoxDelay.Clear();
        }

        private void txtBoxDelay_Leave(object sender, EventArgs e)
        {
            if (txtBoxDelay.Text == "")
            {
                txtBoxDelay.Text = ConfigurationManager.AppSettings["Delay"];
            }
        }

        private void txtBoxScreenRes_SelectedIndexChanged(object sender, EventArgs e) //Changement de la resolution d'ecran
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("Screen_Resolution");
            config.AppSettings.Settings.Add("Screen_Resolution", txtBoxScreenRes.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void txtBoxSelectPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //desactiver tout les item check
            for (int i = 0; i <= (CheckListeObjet.Items.Count - 1); i++)
            {
                if (CheckListeObjet.GetItemChecked(i))
                {
                    CheckListeObjet.SetItemChecked(i, false);
                }
            }  

            //Recuperation du joueur selectionner + affichage des objet lui correspondant
            List<int> ListeObjet = serialisationListeObjet(txtBoxSelectPlayer.Text.Substring(0, 1) + txtBoxSelectPlayer.Text.Substring((txtBoxSelectPlayer.Text.Length - 1), 1));
            foreach (int item in ListeObjet)
            {
                CheckListeObjet.SetItemChecked(item, true);
            }


        }

        private void SaveList_Click(object sender, EventArgs e)
        {
            string Player = txtBoxSelectPlayer.Text.Substring(0, 1) + txtBoxSelectPlayer.Text.Substring((txtBoxSelectPlayer.Text.Length - 1), 1);
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(Player);
            config.AppSettings.Settings.Add(Player, DeserialisationListeObjet());
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");


        }

        private void j1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}