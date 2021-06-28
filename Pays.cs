using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Pays
    {
        private uint IdPays;
        private string NomPays;
        private Zone zone;
        private static uint auto;
        // Question 1
        public static List<Produit> Produits_disponibles = new List<Produit>();

        // Question 2
        public void AjouterProduit(Produit p)
        {
            bool exists = false;
            foreach (var item in Produits_disponibles)
            {
                if (p._IdProduit == item._IdProduit)
                    exists = true;
            }
            if (!exists) { Produits_disponibles.Add(p); }
            else { throw new Exception("Le produit existe deja!"); }
        }

        // Question 3
        public void SupprimerProduit(uint identifiant_produit)
        {
            bool exists = false;
            foreach (var item in Produits_disponibles.ToList())
            {
                if (identifiant_produit == item._IdProduit)
                    Produits_disponibles.Remove(item);
            }
            if (!exists) throw new Exception("Le produit n'existe pas!");
        }

        // Question 4
        public void ListerProduits()
        {
            foreach (var item in Produits_disponibles)
            {
                Console.WriteLine("Id Produit: "+item._IdProduit);
                Console.WriteLine("Nom Produit: " + item._NomProduit);
                Console.WriteLine("Prix Produit: " + item._PrixProduit);
                Console.WriteLine("Categorie: " + item._catégorie._NomCatégorie+"\n");
            }
        }

        //Accesseurs
        public uint _IdPays { get { return IdPays; } private set { IdPays = value; } }
        public string _NomPays { get { return NomPays; } private set { NomPays = value; } }
        public Zone _zone { get { return zone; } private set { zone = value; } }

        //Constructeur d'initialisation
        public Pays(string NomPays, Zone zone)
        {
            auto++;
            IdPays = auto;
            this.NomPays = NomPays;
            this.zone = zone;
        }

        //methode ToString
        public override string ToString()
        {
            return "Id Pays: " + _IdPays + "\n" + "Nom Pays: " + _NomPays + "\n" + "Zone: " + _zone._NomZone + "\n";
        }



    }


}
