using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CPays
    {
        private int id;
        private String nom;

        public int Id { get { return this.id; }  set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }

        public CPays()
        {
            //Constructeur vide
        }

        public CPays(String nom)
        {
            this.nom = nom;
        }

        public CPays(int id, String nom)
        {
            this.id = id;
            this.nom = nom;
        }

        public override string ToString()
        {
            return this.nom;
        }

    }
}
