using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my <b>default<b> action...";
        }

        //
        // GET: /HelloWord/Welcome/

        // if using this: public string Welcome(string name, int numTimes = 1) params are passed as query strings
        // as written below, ID is a param because it matches the URL specification in the RegisterRoutes method.
        // we can also add name to the URL specification (see RouteConfig file)
        public string Welcome(string name, int ID = 1)
        {
            // note that HtmlEncode does not accept string interpolation - all methods in the controller will fail.
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}