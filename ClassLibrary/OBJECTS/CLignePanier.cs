using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.OBJECTS
{
    public class CLignePanier
    {
        private int numero_client;
        private int id_article;
        private int quantite;

        public int Numero_Client { get { return this.numero_client; } set { this.numero_client = value; } }
        public int Id_Article { get { return this.id_article; } set { this.id_article = value; } }
        public int Quantite { get { return this.quantite; } set { this.quantite = value; } }

        public CLignePanier()
        {
            //Constructeur vide
        }

        public CLignePanier(int numero_client, int id_article, int quantite)
        {
            this.numero_client = numero_client;
            this.id_article = id_article;
            this.quantite = quantite;
        }

        public CLignePanier(int numero_client, int id_article)
        {
            this.numero_client = numero_client;
            this.id_article = id_article;
            this.quantite = 1;
        }
    }
}
