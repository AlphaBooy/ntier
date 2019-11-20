using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CArticle
    {

        private int id;
        private String nom;
        private String description;
        private int id_rubrique;
        private int poids;
        private int prix_unitaire;
        private int quantite_stock;

        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public String Description { get { return this.description; } set { this.description = value; } }
        public int Id_rubrique { get { return this.id_rubrique; } set { this.id_rubrique = value; } }
        public int Poids { get { return this.poids; } set { this.poids = value; } }
        public int Prix_unitaire { get { return this.prix_unitaire; } set { this.prix_unitaire = value; } }
        public int Quantite_stock { get { return this.quantite_stock; } set { this.quantite_stock = value; } }

        public CArticle()
        {
            //Constructeur vide
        }

        public CArticle(int id, String nom, String description, int id_rubrique, int poids, int prix_unitaire, int quantite_stock)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.id_rubrique = id_rubrique;
            this.poids = poids;
            this.prix_unitaire = prix_unitaire;
            this.quantite_stock = quantite_stock;
        }
    }
}
