using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistrationMicroservice.Business.Abstract;
using MemberRegistrationMicroservice.Business.ServiceAdapters;
using MemberRegistrationMicroservice.Business.ValidationRules.FluentValidation;
using MemberRegistrationMicroservice.DataAccess.Abstract;
using MemberRegistrationMicroservice.Entities.Concrete;
using OK.Core.Aspects.Postsharp;
using OK.Core.Aspects.PostSharp;

namespace MemberRegistrationMicroservice.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;

        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckMemberExists(member);

            CheckIfIdValidFromKps(member);
            _memberDal.Add(member);
        }

        private void CheckIfIdValidFromKps(Member member)
        {
            if (_kpsService.ValidateUser(member) == false)
            {
                throw new Exception("Kullanıcı doğrulanamadı");
            }
        }

        private void CheckMemberExists(Member member)
        {
            if (_memberDal.Get(x => x.TCKimlikNo == member.TCKimlikNo) != null)
            {
                throw new Exception("Kayıtlı Tc Kimlik Numarası");
            }
        }
    }
}
