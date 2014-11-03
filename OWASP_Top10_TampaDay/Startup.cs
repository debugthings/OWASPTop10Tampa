using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWASP_Top10_TampaDay.Startup))]
namespace OWASP_Top10_TampaDay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
