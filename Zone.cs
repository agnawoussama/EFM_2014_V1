using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFM_2014_V1
{
    
    class Zone
    {
        // Attributs
        private uint IdZone;
        private string NomZone;
        private static uint auto = 0;

        //Accesseurs
        public uint _IdZone    { get { return IdZone;   }  private set { IdZone = value;   } }
        public string _NomZone { get { return NomZone; }  private set { NomZone = value; } }

        //Constructeur d'initialisation
        public Zone(string NomZone)
        {
            auto++;
            IdZone = auto;
            this.NomZone = NomZone;          
        }

        //methode ToString
        public override string ToString()
        {
            return "Id Zone: "+ _IdZone+"\n"+"Nom Zone: " + _NomZone + "\n";
        }
    }


}
