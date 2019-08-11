using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;
using Training.Autofac;
using Training.AutoMapper;
using Training.DataAccess;

namespace Training
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutofacDependecyBuilder.DependencyBuilder();
            AutoMapperConfig.Initialize();


        }
    }
}
