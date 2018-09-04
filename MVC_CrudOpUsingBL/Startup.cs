using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CrudOpUsingBL.Startup))]
namespace MVC_CrudOpUsingBL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
