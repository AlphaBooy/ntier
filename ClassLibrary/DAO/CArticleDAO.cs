using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CArticleDAO : DAO<CArticle, int>
    {
        public CArticleDAO(String connexionString) : base(connexionString) { }


        public override int create(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean update(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public override List<CArticle> getAll()
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM ARTICLE";

            OracleDataReader res = req.ExecuteReader();

            List<CArticle> liste = new List<CArticle>();

            while (res.Read())
            {
                liste.Add(new CArticle(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), res["DESCRIPTION"].ToString(), int.Parse(res["ID_RUBRIQUE"].ToString()), 
                                       int.Parse(res["POIDS"].ToString()), int.Parse(res["PRIX_UNITAIRE"].ToString()), int.Parse(res["QUANTITE_STOCK"].ToString())));
            }
            res.Close();
            return liste;
        }

        public List<CArticle> getAllArticlesByRubrique(int id_rubrique)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM ARTICLE WHERE id_rubrique = :id_rubrique";

            OracleParameter pIdRubrique = new OracleParameter("id_rubrique", id_rubrique);
            req.Parameters.Add(pIdRubrique);
            OracleDataReader res = req.ExecuteReader();

            List<CArticle> liste = new List<CArticle>();

            while (res.Read())
            {
                liste.Add(new CArticle(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), res["DESCRIPTION"].ToString(), int.Parse(res["ID_RUBRIQUE"].ToString()),
                                       int.Parse(res["POIDS"].ToString()), int.Parse(res["PRIX_UNITAIRE"].ToString()), int.Parse(res["QUANTITE_STOCK"].ToString())));
            }
            res.Close();
            return liste;
        }

        public override CArticle find(int id)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM ARTICLE WHERE id = :id";

            OracleParameter pId = new OracleParameter("id", id);
            req.Parameters.Add(pId);
            OracleDataReader res = req.ExecuteReader();
            while (res.Read()) {
                return new CArticle(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), res["DESCRIPTION"].ToString(), int.Parse(res["ID_RUBRIQUE"].ToString()),
                                       int.Parse(res["POIDS"].ToString()), int.Parse(res["PRIX_UNITAIRE"].ToString()), int.Parse(res["QUANTITE_STOCK"].ToString()));
            }
            res.Close();
            return null;
        }
    }
}
