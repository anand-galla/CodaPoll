
using CodaPoll.Services;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;

namespace CodaPoll.WebApi.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void RegisterContainer()
        {
            Container container = new Container();

            container.Register<IHackerService, HackerService>();
            container.Register<IHackerPollService, HackerPollService>();

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
        }
    }
}