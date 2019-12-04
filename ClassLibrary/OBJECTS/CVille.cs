using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CVille
    {
        private int code_postal;
        private String nom;
        private int numero_departement;

        public int Code_Postal { get { return this.code_postal; } set { this.code_postal = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public int Numero_Departement { get { return this.numero_departement; } }

        public CVille()
        {
            //Constructeur vide
        }

        public CVille(int code_postal, String nom, int numero_departement)
        {
            this.code_postal = code_postal;
            this.nom = nom;
            this.numero_departement = numero_departement;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}