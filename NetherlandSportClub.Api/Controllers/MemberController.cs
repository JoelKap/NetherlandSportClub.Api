using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetherlandSportClub.Core;
using NetherlandSportClub.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetherlandSportClub.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        public MemberController(IMemberService member)
        {
            _memberService = member;
        }

        [HttpGet]
        public IActionResult GetMembers()
        {
            return Ok(_memberService.GetMembers());
        }

        [HttpPost]
        public IActionResult AddMember(Member member)
        {
            return Ok(_memberService.AddMember(member));
        }

        [HttpPut]
        public IActionResult UpdateMember(Member member)
        {
            return Ok(_memberService.Update(member));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _memberService.Delete(id);
            return NoContent();
        }
    }
}
