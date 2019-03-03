using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWord/Welcome/

        // if using this: public string Welcome(string name, int numTimes = 1) params are passed as query strings
        // if using this: public string Welcome(string name, int ID = 1) ID is a param because it matches the URL specification in the RegisterRoutes method.
        // we can also add name to the URL specification (see RouteConfig file)
        public ActionResult Welcome(string name, int numTImes = 1)
        {
            // note that HtmlEncode does not accept string interpolation - all methods in the controller will fail.
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);

            // ViewBag is a dynamic object, so we can add whatever properties we want to it.
            // ViewModel is much preferred over the view bag, because a view model gives you the strongly typed views
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTImes;

            return View();
        }
    }
}