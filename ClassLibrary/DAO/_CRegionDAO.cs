using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class _CRegionDAO : CRegionDAO
    {
        public _CRegionDAO(String connexionString) : base(connexionString) { }
    }

}