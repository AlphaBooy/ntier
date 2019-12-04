using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CDepartement
    {
        private int numero;
        private String nom;
        private int id_region;

        public int Numero { get { return this.numero; } set { this.numero = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public int Id_Region { get { return this.id_region; } }

        public CDepartement() { }

        public CDepartement(int numero, String nom, int id_region)
        {
            this.numero = numero;
            this.nom = nom;
            this.id_region = id_region;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}