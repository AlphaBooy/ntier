using System;
using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CRegionDAO : DAO<CRegion, int>
    {
        public CRegionDAO(String connexionString) : base(connexionString) { }


        public override int create(CRegion obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "insert into region (id, nom, id_pays) values (:id, :nom, :id_pays)";

            int id = (int)CSequence.getNextValue("REGION", base._connex.ConnectionString);

            OracleParameter pId = new OracleParameter("id", id);
            OracleParameter pNom = new OracleParameter("nom", obj.Nom);
            OracleParameter pId_Pays = new OracleParameter("id_pays", obj.Id_Pays);


            req.Parameters.Add(pId);
            req.Parameters.Add(pNom);
            req.Parameters.Add(pId_Pays);
            req.ExecuteNonQuery();
            return id;
        }
        public override Boolean update(CRegion obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CRegion obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override List<CRegion> getAll()
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public List<CRegion> getAllRegionsByPays(int id_pays)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM REGION WHERE id_pays = :id_pays";

            OracleParameter pIdPays = new OracleParameter("id_pays", id_pays);
            req.Parameters.Add(pIdPays);
            OracleDataReader res = req.ExecuteReader();

            List<CRegion> liste = new List<CRegion>();

            while (res.Read())
            {
                liste.Add(new CRegion(int.Parse(res["ID"].ToString()), res["NOM"].ToString(), int.Parse(res["ID_PAYS"].ToString())));
            }
            res.Close();
            return liste;
        }

        public override CRegion find(int critere)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

    }

}