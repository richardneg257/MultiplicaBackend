using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Multiplica.Application.Polizas.Commands.CreatePoliza;
using Multiplica.Application.Polizas.Queries.GetPolizaById;
using Multiplica.Application.Ubigeos.Queries.GetUbigeoListById;
using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Multiplica.Service.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Multiplica.Service.App_Start.NinjectWebCommon), "Stop")]

namespace Multiplica.Service.App_Start
{
    public class NinjectWebCommon
    {
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();

        public static IKernel Kernel;

        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            Bootstrapper.Initialize(CreateKernel);
        }
        public static void Stop()
        {
            Bootstrapper.ShutDown();
        }

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            Kernel = kernel;
            return kernel;
        }
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IGetUbigeoListByIdQuery>().To<GetUbigeoListByIdQuery>();
            kernel.Bind<IGetPolizaByIdQuery>().To<GetPolizaByIdQuery>();
            kernel.Bind<ICreatePolizaCommand>().To<CreatePolizaCommand>();
        }
    }
}