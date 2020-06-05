using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesEtudiants
{
    public partial class Form1 : Form
    {
        string _chaineConnexion; // donnée privée
        List<Etudiant> _maListe = new List<Etudiant>();

        public string ChaineConnexion { get => _chaineConnexion; set => _chaineConnexion = value; }
        internal List<Etudiant> MaListe { get => _maListe; set => _maListe = value; }

        public Form1()
        {
            _chaineConnexion = "server = 127.0.0.1; user id = adminEtudiant;password= adminEtudiant; database = etudiants";
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // TODO: Ouvre la fenêtre de création d'un étudiant
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (lstEtudiants.SelectedIndex > -1)
            {
                // TODO: Ouvre la fenêtre de modification d'un étudiant
            }

        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (lstEtudiants.SelectedIndex > -1)
            {
                DialogResult a = MessageBox.Show("Supprimer l'étudiant sélectionné ?", "Supprimer un étudiant", MessageBoxButtons.YesNo);

                if (a == DialogResult.Yes)
                {
                    // TODO: Supprimer l'étudiant sélectionné
                }
            }

        }

        private void btnRaf_Click(object sender, EventArgs e)
        {
            lstEtudiants.Items.Clear();
            Form1_Load(sender,  e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int id;
            string nomEtudiant;
            string prenomEtudiant;
            int idClasse;
            string section;
            DateTime dateNaissance;
            string dateEnChaine;

            _maListe.Clear();

            CURS cs = new CURS(_chaineConnexion);
            string requete = "select Id,Nom,Prenom,Etudiant.IdClasse, DateNaissance, Section from Etudiant,Classe where Etudiant.IdClasse = Classe.IdClasse;";
            cs.ReqSelect(requete);
            while (!cs.Fin())
            {
                id = Convert.ToInt32(cs.champ("Id"));
                nomEtudiant = cs.champ("Nom").ToString(); ;
                prenomEtudiant = cs.champ("Prenom").ToString();
                idClasse = Convert.ToInt32(cs.champ("IdClasse"));
                section = cs.champ("Section").ToString();
                dateNaissance = Convert.ToDateTime(cs.champ("DateNaissance"));
                dateEnChaine = dateNaissance.ToShortDateString();
                Classe uneClasse = new Classe(idClasse, section);
                Etudiant unEtudiant = new Etudiant(id, nomEtudiant, prenomEtudiant, uneClasse, dateNaissance);
                _maListe.Add(unEtudiant);
                lstEtudiants.Items.Add(unEtudiant.ToString()); ;



                
                cs.suivant();
            }

            cs.fermer();
            



        }
    }
}
