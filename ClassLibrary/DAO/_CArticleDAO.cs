using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class _CArticleDAO : CArticleDAO
    {
        public _CArticleDAO(String connexionString) : base(connexionString) { }
    }
}
