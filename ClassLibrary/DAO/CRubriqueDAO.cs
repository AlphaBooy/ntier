using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CRubriqueDAO : DAO<CRubrique, int>
    {
        public CRubriqueDAO(String connexionString) : base(connexionString) { }


        public override int create(CRubrique obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "INSERT INTO RUBRIQUE (id, nom, description, id_parent) values (:id, :nom, :description, :id_parent)";

            int id = (int)CSequence.getNextValue("RUBRIQUE", base._connex.ConnectionString);

            OracleParameter pId = new OracleParameter("id", id);
            OracleParameter pNom = new OracleParameter("nom", obj.Nom);
            OracleParameter pDesc = new OracleParameter("description", obj.Description);
            OracleParameter pIdParent = new OracleParameter("id_parent", obj.IDParent);

            req.Parameters.Add(pId);
            req.Parameters.Add(pNom);
            req.Parameters.Add(pDesc);
            req.Parameters.Add(pIdParent);

            req.ExecuteNonQuery();
            return id;
        }
        public override Boolean update(CRubrique obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CRubrique obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public override List<CRubrique> getAll()
        {
            //Récupération du premier niveau (rubriques qui n'ont pas de parent)
            return getAllFille(null);
            
        }

        public override CRubrique find(int critere)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM Rubrique WHERE id = :id";
            OracleParameter pId = new OracleParameter("id", critere);
            req.Parameters.Add(pId);

            OracleDataReader res = req.ExecuteReader();
            return new CRubrique(int.Parse(res[0].ToString()), res[1].ToString(), res[2].ToString(), int.Parse(res[3].ToString()));
        }

        public List<CRubrique> getAllFille(Nullable<int> idParent)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            if (idParent == null)
            {
                req.CommandText = "SELECT * FROM Rubrique WHERE id_Parent is null";
            } else
            {
                req.CommandText = "SELECT * FROM Rubrique WHERE id_Parent = :idParent";
            }
            OracleParameter pId = new OracleParameter("idParent", idParent);
            req.Parameters.Add(pId);

            OracleDataReader res = req.ExecuteReader();

            List<CRubrique> liste = new List<CRubrique>();

            while (res.Read())
            {
                if (string.IsNullOrEmpty(res["ID_PARENT"].ToString()))
                {
                    CRubrique rubrique = new CRubrique(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), res["DESCRIPTION"].ToString(), null);
                    rubrique.RubriquesFilles = getAllFille(rubrique.Id);
                    liste.Add(rubrique);
                } else
                {
                    CRubrique rubrique = new CRubrique(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), res["DESCRIPTION"].ToString(), int.Parse(res["ID_PARENT"].ToString()));
                    rubrique.RubriquesFilles = getAllFille(rubrique.Id);
                    liste.Add(rubrique);
                }
            }
            return liste;
        }
    }
}
