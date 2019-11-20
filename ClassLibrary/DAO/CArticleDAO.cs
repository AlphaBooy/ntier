using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public abstract class CArticleDAO : DAO<CArticle, int>
    {
        public CArticleDAO(String connexionString) : base(connexionString) { }


        public override int create(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean update(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
        public override Boolean delete(CArticle obj)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public override List<CArticle> getAll()
        {
            Exception err = new Exception("not implemented");
            throw err;
        }

        public override CArticle find(int critere)
        {
            Exception err = new Exception("not implemented");
            throw err;
        }
    }
}
