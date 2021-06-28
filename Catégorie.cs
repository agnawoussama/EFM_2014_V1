using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Catégorie
    {
        private uint IdCatégorie;
        private string NomCatégorie;
        private Catégorie catégorie;
        private static uint auto;

        //Accesseurs
        public uint _IdCatégorie { get { return IdCatégorie; } private set { IdCatégorie = value; } }
        public string _NomCatégorie { get { return NomCatégorie; } private set { NomCatégorie = value; } }
        public Catégorie _catégorie { get { return catégorie; } private set { catégorie = value; } }

        //Constructeur d'initialisation
        public Catégorie(string NomCatégorie, Catégorie catégorie)
        {
            auto++;
            IdCatégorie = auto;
            this.NomCatégorie = NomCatégorie;
            this.catégorie = catégorie;
        }

        //Constructeur de nom de categorie
        public Catégorie(string NomCatégorie)
        {
            auto++;
            IdCatégorie = auto;
            this.NomCatégorie = NomCatégorie;
        }

        //methode ToString
        public override string ToString()
        {
            return "Id Catégorie: " + _IdCatégorie + "\n" + "Nom Catégorie: " + _NomCatégorie + "\n";
        }
    }




}
