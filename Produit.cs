using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Produit
    {
        private uint IdProduit;
        private string NomProduit;
        private float PrixProduit;
        private Catégorie catégorie;
        private static uint auto;

        //Accesseurs
        public uint _IdProduit { get { return IdProduit; } private set { IdProduit = value; } }
        public string _NomProduit { get { return NomProduit; } private set { NomProduit = value; } }
        public float _PrixProduit { get { return PrixProduit; } private set { PrixProduit = value; } }
        public Catégorie _catégorie { get { return catégorie; } private set { catégorie = value; } }

        //Constructeur d'initialisation
        public Produit(string NomProduit, float PrixProduit, Catégorie catégorie)
        {
            auto++;
            IdProduit = auto;
            this.NomProduit = NomProduit;
            this.PrixProduit = PrixProduit;
            this.catégorie = catégorie;
        }

        //methode ToString
        public override string ToString()
        {
            return "Id Produit: " + _IdProduit + "\n" + "Nom Produit: " + _NomProduit + "\n" + "Prix Produit: " + _PrixProduit + "\n" + "Catégorie: " + catégorie._NomCatégorie + "\n";
        }
    }
}
