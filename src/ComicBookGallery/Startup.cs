using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComicBookGallery.Startup))]
namespace ComicBookGallery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
