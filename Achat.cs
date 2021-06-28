using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Achat
    {
        // Question 5
        private Produit Produit;
        private uint Quantite;
        private DateTime DateAchat;

        //Accesseurs
        public Produit _Produit { get { return Produit; } private set { Produit = value; } }
        public uint _Quantite { get { return Quantite; } private set { Quantite = value; } }
        public DateTime _DateAchat { get { return DateAchat; } private set { DateAchat = value; } }

        //Constructeur d'initialisation
        public Achat(Produit Produit, uint Quantite)
        {
            this.Produit = Produit;
            this.Quantite = Quantite;
            DateAchat = DateTime.Now;
        }

        // Question 6
        public float MontantAchat()
        {
            float montant = Produit._PrixProduit * this.Quantite;
            return montant;
        }

        ////methode ToString
        //public override string ToString()
        //{
        //    return "Id Produit: " + _IdProduit + "\n" + "Nom Produit: " + _NomProduit + "\n" + "Prix Produit: " + _PrixProduit + "\n" + "Catégorie: " + catégorie._NomCatégorie + "\n";
        //}
    }
}
