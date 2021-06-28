using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Client
    {
        // Attributs
        private uint IdClient;
        private string Nom;
        private string Prenom;
        private string AdressPostale;
        private Ville Ville;
        private string NumTele;
        private string AdresseEmail;
        private static List<Achat> AchatsEffectués = new List<Achat>();
        private static uint auto;
     
        // Accesseurs
        public uint _IdClient { get { return IdClient; } private set { IdClient = value; } }
        public string _Nom { get { return Nom; } set { Nom = value; } }
        public string _Prenom { get { return Prenom; } set { Prenom = value; } }
        public string _AdressPostale { get { return AdressPostale; } set { AdressPostale = value; } }
        public Ville _Ville { get { return Ville; } set { Ville = value; } }
        public string _NumTele { get { return NumTele; } set { NumTele = value; } }
        public string _AdresseEmail { get { return AdresseEmail; } set { AdresseEmail = value; } }

        public Client()
        {

        }

        // Constructeur d'initialisation
        public Client(string nom, string prenom, string adressPostale, Ville ville, string numTele, string adresseEmail)
        {
            auto++;
            IdClient = auto;
            Nom = nom;
            Prenom = prenom;
            AdressPostale = adressPostale;
            Ville = ville;
            NumTele = numTele;
            AdresseEmail = adresseEmail;
        }

        public virtual void AcheterProduit(Achat achat)
        {
            AchatsEffectués.Add(achat);
        }

        public void ListerAchats(DateTime Debut, DateTime Fin)
        {
            foreach (var item in AchatsEffectués)
            {
                if (item._DateAchat >= Debut || item._DateAchat <= Fin)
                {
                    Console.WriteLine("Produit: "+ item._Produit);
                    Console.WriteLine("Quantite" + item._Quantite);
                }
            }
        }





    }




}
