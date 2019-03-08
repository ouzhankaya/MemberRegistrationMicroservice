using MemberRegistrationMicroservice.Entities.Concrete;
using OK.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistrationMicroservice.DataAccess.Abstract
{
    public interface IMemberDal:IEntityRepository<Member>
    {

    }
}
