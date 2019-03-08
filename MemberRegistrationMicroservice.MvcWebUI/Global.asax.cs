using OK.Core.Utilities.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using FluentValidation.Mvc;
using MemberRegistrationMicroservice.Business.DependencyResolvers.Ninject;
using OK.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace MemberRegistrationMicroservice.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));

            FluentValidationModelValidatorProvider.Configure(provider =>
                {
                    provider.ValidatorFactory = new NinjectValidationFactory(new ValidationModule());
                });
        }
    }
}
