﻿using AutoMapper;
using Multiplica.Application.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Multiplica.Service
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new ApplicationProfile());
            });
        }
    }
}
