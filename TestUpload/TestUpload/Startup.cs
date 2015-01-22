using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestUpload.Startup))]
namespace TestUpload
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
