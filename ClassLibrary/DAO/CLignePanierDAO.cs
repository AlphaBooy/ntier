using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CLignePanierDAO : DAO<CLignePanier, int>
    {
        public CLignePanierDAO(String connexionString) : base(connexionString) { }


        public override int create(CLignePanier obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "INSERT INTO LIGNE_PANIER (numero_client, id_article, quantite) values (:numero_client, :id_article, :quantite)";
            
            OracleParameter pNumCli = new OracleParameter("numero_client", obj.Numero_Client);
            OracleParameter pIDArt = new OracleParameter("id_article", obj.Id_Article);
            OracleParameter pQuant = new OracleParameter("quantite", obj.Quantite);

            req.Parameters.Add(pNumCli);
            req.Parameters.Add(pIDArt);
            req.Parameters.Add(pQuant);

            req.ExecuteNonQuery();
            return 0;
        }
        public override Boolean update(CLignePanier obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CLignePanier obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override List<CLignePanier> getAll()
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public CLignePanier find(int numero_client, int id_article)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM LIGNE_PANIER WHERE numero_client = :numero_client AND id_article = :id_article";
            OracleParameter pNumCli = new OracleParameter("numero_client", numero_client);
            OracleParameter pIdArt = new OracleParameter("id_article", id_article);
            req.Parameters.Add(pNumCli);
            req.Parameters.Add(pIdArt);

            OracleDataReader res = req.ExecuteReader();
            CLignePanier returnLignePanier = new CLignePanier(int.Parse(res["NUMERO_CLIENT"].ToString()), int.Parse(res["ID_ARTICLE"].ToString()), int.Parse(res["QUANTITE"].ToString()));
            res.Close();
            return returnLignePanier;
        }

        public List<CLignePanier> getAllLignePanierByClient(int numero_client)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM LIGNE_PANIER WHERE numero_client = :numero_client";

            OracleParameter pNumeroClient = new OracleParameter("numero_client", numero_client);
            req.Parameters.Add(pNumeroClient);
            OracleDataReader res = req.ExecuteReader();

            List<CLignePanier> liste = new List<CLignePanier>();

            while (res.Read())
            {
                liste.Add(new CLignePanier(int.Parse(res["NUMERO_CLIENT"].ToString()), int.Parse(res["ID_ARTICLE"].ToString()), int.Parse(res["QUANTITE"].ToString())));
            }
            res.Close();
            return liste;
        }

        public void IncrementLignePanier(int numero_client, int id_article)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "UPDATE LIGNE_PANIER SET quantite = quantite + 1 WHERE numero_client = :numero_client AND id_article = id_article";

            OracleParameter pNumCli = new OracleParameter("numero_client", numero_client);
            OracleParameter pIDArt = new OracleParameter("id_article", id_article);

            req.Parameters.Add(pNumCli);
            req.Parameters.Add(pIDArt);

            req.ExecuteNonQuery();
        }

    }

}

