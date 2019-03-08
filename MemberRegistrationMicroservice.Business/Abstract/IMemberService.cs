using MemberRegistrationMicroservice.Entities.Concrete;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistrationMicroservice.Business.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
    }
}
