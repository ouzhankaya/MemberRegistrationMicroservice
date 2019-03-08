using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MemberRegistrationMicroservice.MvcWebUI.Filters
{
    public class ExceptionHandlerAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var message = filterContext.Exception.Message;

            filterContext.Controller.ViewData.ModelState.AddModelError("MemberExceptionMessage",message);

            filterContext.ExceptionHandled = true;

            filterContext.Result = new ViewResult
            {
                ViewData = new ViewDataDictionary(filterContext.Controller.ViewData)
            };
        }
    }
}