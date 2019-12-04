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
        public List<CRegion> getAllRegionFromPays(int id_pays)
        {
            return DAOFactory.getCRegionDAO().getAllRegionsByPays(id_pays);
        }

    }
}

