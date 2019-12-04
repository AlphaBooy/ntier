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
    public abstract class CVilleDAO : DAO<CVille, int>
    {
        public CVilleDAO(String connexionString) : base(connexionString) { }


        public override int create(CVille obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "insert into ville (code_postal, nom, numero_departement) values (:code_postal, :nom, :numero_departement)";

            int code_postal = (int)CSequence.getNextValue("VILLE", base._connex.ConnectionString);

            OracleParameter pCode_Postal = new OracleParameter("code_postal", code_postal);
            OracleParameter pNom = new OracleParameter("nom", obj.Nom);
            OracleParameter pNumero_Departement = new OracleParameter("numero_departement", obj.Numero_Departement);


            req.Parameters.Add(pCode_Postal);
            req.Parameters.Add(pNom);
            req.Parameters.Add(pNumero_Departement);
            req.ExecuteNonQuery();
            return code_postal;
        }
        public override Boolean update(CVille obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CVille obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override List<CVille> getAll()
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public List<CVille> getAllVilleByDepartement(int numero_departement)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM VILLE WHERE numero_departement = :numero_departement";

            OracleParameter pNumero_Departement = new OracleParameter("numero_departement", numero_departement);
            req.Parameters.Add(pNumero_Departement);
            OracleDataReader res = req.ExecuteReader();

            List<CVille> liste = new List<CVille>();

            while (res.Read())
            {
                liste.Add(new CVille(int.Parse(res["CODE_POSTAL"].ToString()), res["NOM"].ToString(), int.Parse(res["NUMERO_DEPARTEMENT"].ToString())));
            }
            res.Close();
            return liste;
        }

        public override CVille find(int critere)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

    }

}