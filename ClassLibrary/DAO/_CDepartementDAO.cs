using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class _CDepartementDAO : CDepartementDAO
    {
        public _CDepartementDAO(String connexionString) : base(connexionString) { }
    }

}