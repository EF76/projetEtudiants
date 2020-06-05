using System;

namespace GestionDesEtudiants
{
    class Etudiant
    {
        int _id;

        string _nom;

        string _prenom;

        Classe _classe;

        DateTime _dateDeNaissance;

        public int getId()
        {
            return _id;
        }

        public string getNom()
        {
            return _nom;
        }
        public Classe getClasse()
        {
            return _classe;
        }
        public DateTime getDateDenaissance()
        {
            return _dateDeNaissance;
        }
        public void setNom( string nouveauNom)
        {
            _nom = nouveauNom;
        }
        public void setPrenom( string nouveauprenom)
        {
            _prenom = nouveauprenom;
        }
        public void setDateDeNaissance( DateTime nouvelleDate)
        {
            _dateDeNaissance = nouvelleDate;
        }
        public void setClasse( Classe nouvelleClasse)
        {
            _classe = nouvelleClasse;
        }
        /// <summary>
        /// Constructeur
        /// </summary>
        public Etudiant(int id, string nom, string prenom, Classe classe, DateTime dateDeNaissance)
        {
            _id = id;
            _nom = nom;
            _prenom = prenom;
            _classe = classe;
            _dateDeNaissance = dateDeNaissance;
        }

        /// <summary>
        /// Permet d'afficher l'étudiant sous forme de chaîne de caractère dans la liste
        /// </summary>
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} ({4})",_id, _nom, _prenom,_dateDeNaissance.ToShortDateString(), _classe);
        }
    }
}