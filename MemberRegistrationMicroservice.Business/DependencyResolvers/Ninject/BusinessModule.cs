using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistrationMicroservice.Business.Abstract;
using MemberRegistrationMicroservice.Business.Concrete;
using MemberRegistrationMicroservice.Business.ServiceAdapters;
using MemberRegistrationMicroservice.DataAccess.Abstract;
using MemberRegistrationMicroservice.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MemberRegistrationMicroservice.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
