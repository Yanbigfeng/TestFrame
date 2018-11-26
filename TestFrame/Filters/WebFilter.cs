using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.IService;

namespace TestFrame
{
    public class WebFilter : ActionFilterAttribute
    {
        public ILoginLogService service { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            service.AddLoginLog();
        }
    }
}