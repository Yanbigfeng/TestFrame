using Autofac;
using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using test.IService;
using test.DTO;

namespace TestFrame
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoFacRegister();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        public void AutoFacRegister()
        {
            var builder = new ContainerBuilder();

            // 通过程序集注册所有控制器和属性注入
            //builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            ////单个控制器注入
            //builder.RegisterType<BaseService>().As<IBaseService>();
            //集体自动注入
            var baseType = typeof(IDependency);
            var assbembly = AppDomain.CurrentDomain.GetAssemblies().ToList();
            builder.RegisterAssemblyTypes(assbembly.ToArray())
                .Where(t => baseType.IsAssignableFrom(t) && t != baseType)
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            //过滤器注入
            builder.RegisterFilterProvider();
            // 将依赖性分解器设置为AutoFac。
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
