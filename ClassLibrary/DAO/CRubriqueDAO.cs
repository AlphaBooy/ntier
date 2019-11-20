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
            Exception err = new Exception("not implemented");
            throw err;
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
            return new CRubrique((int)res[0], (String)res[1], (String)res[2], (int)res[3]);
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
                liste.Add(new CRubrique((int)res[0], (String)res[1], (String)res[2], (int)res[3]));
                //int.Parse(res["ID"].ToString())
            }
            return liste;
        }
    }
}
