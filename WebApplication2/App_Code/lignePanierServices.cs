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
        public int createLignePanier(int numero_client, int id_article)
        {
            return DAOFactory.getCLignePanierDAO().create(new CLignePanier(numero_client, id_article));  
        }

        [WebMethod]
        public void IncrementLignePanier(int numero_client, int id_article)
        {
            DAOFactory.getCLignePanierDAO().IncrementLignePanier(numero_client, id_article);
        }

        [WebMethod]
        public List<CLignePanier> getAllLignePanierFromClient(int numero_client)
        {
            return DAOFactory.getCLignePanierDAO().getAllLignePanierByClient(numero_client);
        }

        [WebMethod]
        public CLignePanier findLignePanier(int numero_client, int id_article)
        {
            return DAOFactory.getCLignePanierDAO().find(numero_client, id_article);
        }

        [WebMethod]
        public void ajoutLignePanier(int numero_client, int id_article)
        {
            if (findLignePanier(numero_client, id_article) != null)
            {
                createLignePanier(numero_client, id_article);
            } else
            {
                IncrementLignePanier(numero_client, id_article);
            }
        }


    }
}