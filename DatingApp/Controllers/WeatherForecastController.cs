//using DatingApp.Data;
//using DatingApp.Entities;
//using Microsoft.AspNetCore.Mvc;

//namespace DatingApp.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MembersController(AppDbContext context) : ControllerBase
//    {

//        [HttpGet]
//        public ActionResult<IReadOnlyList<AppUser>> GetMembers()
//        {
//            var members = context.Users.ToList();
//            return members;
//        }

//        [HttpGet("{id}")] 
//        public ActionResult<AppUser> GetMember(int id)
//        {
//            var member = context.Users.Find(id);
//            if (member == null) return NotFound();
//            return Ok(member);
//        }
//    }
//}
