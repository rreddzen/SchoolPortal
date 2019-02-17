using System.Web.Mvc;
using System.Web.Http;
using System.Web.Routing;
using System.Data.Entity;
using System.Web.Optimization;

using MySql.Data.Entity;
using SchoolPortal.App_Start;

namespace SchoolPortal
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MappingProfile mapping = new MappingProfile();
            DbConfiguration.SetConfiguration(new MySqlEFConfiguration());
        }
    }
}
