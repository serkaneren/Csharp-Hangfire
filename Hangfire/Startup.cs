using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Hangfire.Startup))]

namespace Hangfire
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //Db Bilgilerimizi bu alana giriyoruz.
            GlobalConfiguration.Configuration.UseSqlServerStorage(@"Server=SİZİN_LOCALHOST;Database=Hangfire;Integrated Security=true");
            //Dashboardunu aktif ediyoruz. 
            app.UseHangfireDashboard();
            //Serverı aktif hale getiriyoruz.
            app.UseHangfireServer();
        }
    }
}
