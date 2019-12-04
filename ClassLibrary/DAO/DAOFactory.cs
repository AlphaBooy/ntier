using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAO
{
    public class DAOFactory
    {
        protected static string _connexionString = "Data Source=iutdb;User ID=mms13;Password=02084649";
        public static _CPaysDAO getCPaysDAO()
        {
            return new _CPaysDAO(_connexionString);
        }

        public static _CRubriqueDAO getCRubriqueDAO()
        {
            return new _CRubriqueDAO(_connexionString);
        }

        public static _CArticleDAO getCArticleDAO()
        {
            return new _CArticleDAO(_connexionString);
        }

        public static _CLignePanierDAO getCLignePanierDAO()
        {
            return new _CLignePanierDAO(_connexionString);
        }
        
        public static _CRegionDAO getCRegionDAO()
        {
            return new _CRegionDAO(_connexionString);
        }

        public static _CDepartementDAO getCDepartementDAO()
        {
            return new _CDepartementDAO(_connexionString);
        }

        public static _CVilleDAO getCVilleDAO()
        {
            return new _CVilleDAO(_connexionString);
        }

        //public static _CCiviliteDAO getCCiviliteDAO()
        //{
        //    return new _CCiviliteDAO(_connexionString);

        //}
    }
}
