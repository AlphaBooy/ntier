using ClassLibrary.DAO;
using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{

    public partial class WebService2 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<CArticle> getAllArticles()
        {
            return DAOFactory.getCArticleDAO().getAll();
        }

        [WebMethod]
        public List<CArticle> getAllArticlesFromRubrique(int id_rubrique)
        {
            return DAOFactory.getCArticleDAO().getAllArticlesByRubrique(id_rubrique);
        }

        [WebMethod]
        public CArticle findArticle(int id)
        {
            return DAOFactory.getCArticleDAO().find(id);
        }

    }
}
