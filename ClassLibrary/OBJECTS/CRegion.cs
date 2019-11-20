using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CRegion
    {
        private int id;
        private String nom;
        private int id_pays;

        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public int Id_Pays { get { return this.Id_Pays; }}

        public CRegion(int id, String nom, int id_pays)
        {
            this.id = id;
            this.nom = nom;
            this.id_pays = id_pays;
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
