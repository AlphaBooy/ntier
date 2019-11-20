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
        public int createPays(String nom)
        {
            return DAOFactory.getCPaysDAO().create(new CPays(nom));
        }
        
    }
}
