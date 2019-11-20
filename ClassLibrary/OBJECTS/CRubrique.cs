using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CRubrique
    {
        private int id;
        private String nom;
        private String description;
        private Nullable<int> idparent;
        private List<CRubrique> _rubriquesFilles;

        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public String Description { get { return this.description; } set { this.description = value; } }
        public Nullable<int> IDParent { get { return this.idparent; } set { this.idparent = value; } }
        public List<CRubrique> RubriquesFilles { get { return this._rubriquesFilles; } set { this._rubriquesFilles = value; } }

        public CRubrique(int id, String nom, String description, Nullable<int> idparent, List<CRubrique> rubriquesFilles)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.idparent = idparent;
            this._rubriquesFilles = rubriquesFilles;
        }

        public CRubrique(int id, String nom)
        {
            this.id = id;
            this.nom = nom;
            this.description = null;
            this.idparent = null;
            this._rubriquesFilles = null;
        }

        public CRubrique(int id, String nom, String description, Nullable<int> idparent)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.idparent = idparent;
            this._rubriquesFilles = null;
        }

        public CRubrique()
        {
        }

        public override string ToString()
        {
            return this.nom;
        }
    }
}
