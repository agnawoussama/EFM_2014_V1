using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Ville
    {
        private uint IdVille;
        private string NomVille;
        private uint CodePostal;
        private Pays pays;
        private static uint auto;

        //Accesseurs
        public uint _IdVille { get { return IdVille; } private set { IdVille = value; } }
        public string _NomVille { get { return NomVille; } private set { NomVille = value; } }
        public uint _CodePostal { get { return CodePostal; } private set { CodePostal = value; } }
        public Pays _pays { get { return pays; } private set { pays = value; } }

        //Constructeur d'initialisation
        public Ville(string NomVille, uint CodePostal, Pays pays)
        {
            auto++;
            IdVille = auto;
            this.NomVille = NomVille;
            this.CodePostal = CodePostal;
            this.pays = pays;
        }

        //methode ToString
        public override string ToString()
        {
            return "Id Ville: " + _IdVille + "\n" + "Nom Ville: " + _NomVille + "\n" + "CodePostal: " + _CodePostal + "\n" + "Pays: " + _pays._NomPays + "\n";
        }
    }
}
