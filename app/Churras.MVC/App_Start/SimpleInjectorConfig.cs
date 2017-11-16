using Churras.Application;
using Churras.Application.Contracts;
using Churras.Data.Context;
using Churras.Data.Repositories;
using Churras.Domain.Contracts.Repositories;
using Churras.Domain.Contracts.Services;
using Churras.Domain.Services;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Churras.MVC.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void Config()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<DbContext, ChurrasContext>(Lifestyle.Scoped);

            RepositoryConfig(container);
            ApplicationServicesConfig(container);
            DomainServicesConfig(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();

            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));
        }

        private static void RepositoryConfig(Container container)
        {
            container.Register<IEventRepository, EventRepository>(Lifestyle.Scoped);
            container.Register<IParticipantRepository, ParticipantRepository>(Lifestyle.Scoped);
        }

        private static void DomainServicesConfig(Container container)
        {
            container.Register<IEventService, EventService>(Lifestyle.Scoped);
            container.Register<IParticipantService, ParticipantService>(Lifestyle.Scoped);
        }

        private static void ApplicationServicesConfig(Container container)
        {
            container.Register<IEventAppService, EventAppService>(Lifestyle.Scoped);
            container.Register<IParticipantAppService, ParticipantAppService>(Lifestyle.Scoped);
        }
    }
}