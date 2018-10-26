using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstVS13GitDemo.Startup))]
namespace MyFirstVS13GitDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
