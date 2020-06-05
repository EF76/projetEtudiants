using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesEtudiants
{
    class Classe
    {
        int _idClasse;
        string _section;
        public string getSection()
        {
            return _section;
        }
        public void setSection( string nouvelleSection)
        {
            _section = nouvelleSection;
        }

        public Classe( int id,string section)
        {
            _idClasse = id;
            _section = section;
        }
        public override string ToString()
        {
            return string.Format("{0} {1})", _idClasse, _section);
        }
    }
}
