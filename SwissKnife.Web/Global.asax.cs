﻿using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

using Microsoft.AspNet.SignalR;

using SwissKnife.SignalR;

namespace SwissKnife.Web
{
    // メモ: IIS6 または IIS7 のクラシック モードの詳細については、
    // http://go.microsoft.com/?LinkId=9394801 を参照してください
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            GlobalHost.HubPipeline.AddModule(new RateLimitingModule());
        }
    }
}