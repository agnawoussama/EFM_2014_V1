using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EFM_2014_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zone z1 = new Zone("ba 2006");
            Zone z2 = new Zone("shalk 2005");

            Pays p1 = new Pays("Maroc", z1);
            Pays p2 = new Pays("Germany", z2);

            Ville v1 = new Ville("Rabat", 1000, p1);
            Ville v2 = new Ville("SHfzelkuhch", 55852, p2);

            Catégorie c1 = new Catégorie("Bimo");
            Catégorie c2 = new Catégorie("Electronics");

            Produit pr1 = new Produit("Tager", 10, c1);
            Produit pr2 = new Produit("Cle usb", 140, c2);
            Produit pr3 = new Produit("Tager", 10, c1);

            p1.AjouterProduit(pr1);
            p1.AjouterProduit(pr2);
            p1.AjouterProduit(pr3);
            p1.ListerProduits();

            //Console.WriteLine("Enter the id of the product you want to delete: ");
            //p1.SupprimerProduit(uint.Parse(Console.ReadLine()));
            //p1.ListerProduits();

            Achat a1 = new Achat(pr1, 50);            
            Console.WriteLine($"Le montant d'achat de produit {pr1._NomProduit} est: {a1.MontantAchat()}");









            Console.ReadLine();
        }
    }
}
