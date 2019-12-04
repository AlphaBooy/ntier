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
    public abstract class CDepartementDAO : DAO<CDepartement, int>
    {
        public CDepartementDAO(String connexionString) : base(connexionString) { }


        public override int create(CDepartement obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "insert into departement (numero, nom, id_region) values (:numero, :nom, :id_region)";

            int numero = (int)CSequence.getNextValue("DEPARTEMENT", base._connex.ConnectionString);

            OracleParameter pId = new OracleParameter("numero", numero);
            OracleParameter pNom = new OracleParameter("nom", obj.Nom);
            OracleParameter pId_Region = new OracleParameter("id_region", obj.Id_Region);


            req.Parameters.Add(pId);
            req.Parameters.Add(pNom);
            req.Parameters.Add(pId_Region);
            req.ExecuteNonQuery();
            return numero;
        }
        public override Boolean update(CDepartement obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CDepartement obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override List<CDepartement> getAll()
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public List<CDepartement> getAllDepartementByRegion(int id_region)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM DEPARTEMENT WHERE id_region = :id_region";

            OracleParameter pIdRegion = new OracleParameter("id_region", id_region);
            req.Parameters.Add(pIdRegion);
            OracleDataReader res = req.ExecuteReader();

            List<CDepartement> liste = new List<CDepartement>();

            while (res.Read())
            {
                liste.Add(new CDepartement(int.Parse(res["NUMERO"].ToString()), res["NOM"].ToString(), int.Parse(res["ID_REGION"].ToString())));
            }
            res.Close();
            return liste;
        }

        public override CDepartement find(int critere)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

    }

}