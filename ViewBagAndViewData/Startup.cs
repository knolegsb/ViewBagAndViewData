using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewBagAndViewData.Startup))]
namespace ViewBagAndViewData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
