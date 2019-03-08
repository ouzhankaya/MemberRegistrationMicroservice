using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistrationMicroservice.Business.KpsServiceReference;
using MemberRegistrationMicroservice.Entities.Concrete;

namespace MemberRegistrationMicroservice.Business.ServiceAdapters
{
    public class KpsServiceAdapter : IKpsService
    {
        public bool ValidateUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();

            return client.TCKimlikNoDogrula(Convert.ToInt64(member.TCKimlikNo), member.FirstName.ToUpper(),member.LastName.ToUpper(),member.DateOfBirth.Year);
        }
    }
}
