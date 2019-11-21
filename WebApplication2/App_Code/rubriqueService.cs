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
        public List<CRubrique> getAllRubrique()
        {
            return DAOFactory.getCRubriqueDAO().getAll();
        }

        [WebMethod]
        public int createRubrique(String nom, String description, CRubrique id_parent)
        {
            return DAOFactory.getCRubriqueDAO().create(new CRubrique(nom, description, id_parent.Id));
        }

    }
}