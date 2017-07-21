using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CalculateNumbers.Startup))]
namespace CalculateNumbers
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
