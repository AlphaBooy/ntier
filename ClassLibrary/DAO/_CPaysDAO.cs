using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class _CPaysDAO : CPaysDAO
    {
        public _CPaysDAO(String connexionString) : base(connexionString) { }

        //public List<CRegion> getRegions(CPays pays)
        //{
        //    OracleCommand req = new OracleCommand();
        //    req.Connection = _connex;
        //    req.CommandText = "select * from region where id_pays=:id_pays";

        //    OracleParameter pId_pays = new OracleParameter("id_pays", pays.Id);

        //    req.Parameters.Add(pId_pays);


        //}
    }
    
}
