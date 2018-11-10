using Autofac;
using Autofac.Integration.Mvc;
using MovieInfo.Core.Core.Interfaces;
using MovieInfo.Core.Models;
using MovieInfo.Core.Models.GenericRepository;
using MovieInfo.Core.Models.Models;
using MovieInfo.Core.Services;
using System.Web.Mvc;


namespace MovieInfo.Api.App_Start
{
    public static class AutoFacConfig
    {
        public static void ConfigureDependencyInjection()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<GenericRepository<User>>().As<IRepository<User>>();

            builder.RegisterType<TestService>().As<ITestService>();

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}