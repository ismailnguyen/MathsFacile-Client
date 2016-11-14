using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MathsFacileClient.Web.Startup))]
namespace MathsFacileClient.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
