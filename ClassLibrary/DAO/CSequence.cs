using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    class CSequence
    {
        public static double getNextValue(String table, String connexionString)
        {
            OracleConnection connex = SingleConnexion.getInstance(connexionString);
            OracleCommand req = new OracleCommand("SELECT S_ID_" + table + ".nextval FROM DUAL", connex);
            OracleDataReader res = req.ExecuteReader();
            double value = -1;
            if (res.HasRows)
            {
                res.Read();
                value = double.Parse(res.GetValue(0).ToString());
            }
            res.Close();
            return value;
        }
    }
}
