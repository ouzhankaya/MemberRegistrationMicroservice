using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using MemberRegistrationMicroservice.Business.ValidationRules.FluentValidation;
using MemberRegistrationMicroservice.Entities.Concrete;

namespace MemberRegistrationMicroservice.Business.DependencyResolvers.Ninject
{
    public class ValidationModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<Member>>().To<MemberValidator>().InSingletonScope();
        }
    }
}
