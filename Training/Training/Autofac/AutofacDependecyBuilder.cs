using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using Training.Service;

namespace Training.Autofac
{
    public class AutofacDependecyBuilder
    {
        public static void DependencyBuilder()
        {
            var builder = new ContainerBuilder();

            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<TrainingService>().As<ITrainingService>();
            builder.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Build the Container
            var container = builder.Build();

            //Create the Dependency Resolver
            var resolver = new AutofacWebApiDependencyResolver(container);

            //Configuring WebApi with Dependency Resolver
            GlobalConfiguration. Configuration.DependencyResolver = resolver;
        }
    }
}