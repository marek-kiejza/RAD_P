using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCs00173510.Xmas20182019.Startup))]
namespace MVCs00173510.Xmas20182019
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
