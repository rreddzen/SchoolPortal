using Owin;
using System;
using Microsoft.Owin;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;

using SchoolPortal.Models;
using SchoolPortal.Services.ApiProviders;
using System.Web.Http;
using Microsoft.Owin.Cors;

[assembly: OwinStartupAttribute(typeof(SchoolPortal.Startup))]
namespace SchoolPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            app.UseCors(CorsOptions.AllowAll);
            app.UseWebApi(config);
            app.UseOAuthBearerTokens(OAuthOptions);
            ConfigureAuth(app);
        }
    }
}
