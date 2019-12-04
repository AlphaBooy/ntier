using ClassLibrary.DAO;
using ClassLibrary.OBJECTS;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

namespace WebApplication2
{

    public partial class WebService2 : System.Web.Services.WebService
    {
        [WebMethod]
        public List<CVille> getAllVilleFromDepartement(int id_departement)
        {
            return DAOFactory.getCVilleDAO().getAllVilleByDepartement(id_departement);
        }

    }
}

