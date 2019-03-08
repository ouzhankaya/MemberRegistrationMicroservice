using MemberRegistrationMicroservice.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistrationMicroservice.Business.Abstract;
using MemberRegistrationMicroservice.Entities.Concrete;

namespace MemberRegistrationMicroservice.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var memberService = InstanceFactory.GetInstance<IMemberService>();

            memberService.Add(new Member
            {
                FirstName = "Oğuzhan",
                LastName = "Kaya",
                DateOfBirth = new DateTime(1994,02,21),
                TCKimlikNo = "10118824198",
                Email = "oguuzhankaya@gmail.com"
            });
   
            Console.WriteLine("Eklendi");
            Console.ReadKey();
        }
    }
}
