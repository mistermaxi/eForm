using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eForm.Startup))]
namespace eForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
