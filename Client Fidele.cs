using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    class Client_Fidele : Client
    {
        private uint NumFidelite;
        private static uint auto;

        public uint _NumFidelite { get { return NumFidelite; } private set { NumFidelite = value; } }

        public Client_Fidele(string nom, string prenom, string adressPostale, Ville ville, string numTele, string adresseEmail)
            :base(nom,prenom,adressPostale,ville,numTele,adresseEmail)
        {
            auto++;
            NumFidelite = auto;            
        }

        public override void AcheterProduit(Achat achat)
        {
            float remise = (achat._Produit._PrixProduit * 25) / 100;           
        }
    }
}
