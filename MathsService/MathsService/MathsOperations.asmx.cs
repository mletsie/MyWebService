using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathsService
{
    /// <summary>
    /// Summary description for MathsOperations
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathsOperations : System.Web.Services.WebService
    {

        [WebMethod]
        public decimal Add(decimal a, decimal b)
        {
            return a+b;
        }
    }
}
