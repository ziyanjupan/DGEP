﻿using System;
using System.Threading;
using Abp.Castle.Logging.Log4Net;
using Abp.Web;
using Abp.WebApi.Validation;
using Castle.Facilities.Logging;

namespace QGEP.Web
{
    public class MvcApplication : AbpWebApplication<QGEPWebModule>
    {
        protected override void Application_Start(object sender, EventArgs e)
        {
            AbpBootstrapper.IocManager.IocContainer.AddFacility<LoggingFacility>(
                f => f.UseAbpLog4Net().WithConfig(Server.MapPath("log4net.config"))
            );
            
            base.Application_Start(sender, e);
        }
    }
}
