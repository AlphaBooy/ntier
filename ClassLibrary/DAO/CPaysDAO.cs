using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CPaysDAO : DAO<CPays, int>
    {
        public CPaysDAO(String connexionString) : base(connexionString) { }


        public override int create(CPays obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "insert into pays (id, nom) values (:id, :nom)";

            int id = (int) CSequence.getNextValue("PAYS", base._connex.ConnectionString);

            OracleParameter pId = new OracleParameter("id", id);
            OracleParameter pNom = new OracleParameter("nom", obj.Nom);

            req.Parameters.Add(pId);
            req.Parameters.Add(pNom);
            req.ExecuteNonQuery();
            return id;
        }
        public override Boolean update(CPays obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CPays obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override List<CPays> getAll()
        {
            //OracleCommand req = new OracleCommand();
            //req.Connection = _connex;
            //req.CommandText = "SELECT * FROM pays";

            //int id = (int)CSequence.getNextValue("PAYS", base._connex.ConnectionString);

            //OracleParameter pId = new OracleParameter("id", id);
            //OracleParameter pNom = new OracleParameter("nom", obj.Nom);

            //req.Parameters.Add(pId);
            //req.Parameters.Add(pNom);
            //req.ExecuteNonQuery();
            return null;
        }
        public override CPays find(int critere)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

    }

}
