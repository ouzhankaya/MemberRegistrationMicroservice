using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberRegistrationMicroservice.Business.Abstract;
using MemberRegistrationMicroservice.Entities.Concrete;
using MemberRegistrationMicroservice.MvcWebUI.Filters;
using MemberRegistrationMicroservice.MvcWebUI.Models;

namespace MemberRegistrationMicroservice.MvcWebUI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }
        
        public ActionResult Add()
        {
            return View(new MemberAddViewModel());
        }

        [HttpPost]
        [ExceptionHandler]
        public ActionResult Add(Member member)
        {
            _memberService.Add(member);
            return View(new MemberAddViewModel());
        }
    }
}