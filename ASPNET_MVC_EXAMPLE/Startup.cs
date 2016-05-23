using Microsoft.Owin;
using MONGO_CONNECT;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNET_MVC_EXAMPLE.Startup))]
namespace ASPNET_MVC_EXAMPLE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

            ConnectDatabase.Init();
        }
    }
}
