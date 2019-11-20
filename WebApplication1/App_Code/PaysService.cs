using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    public partial class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld2()
        {
            return "Hello World";
        }
    }
}
