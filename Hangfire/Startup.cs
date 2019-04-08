using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hangfire.Startup))]

namespace Hangfire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage(@"Server=SERKANEREN8A72\SQLEXPRESS;Database=Hangfire;Integrated Security=true");
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
