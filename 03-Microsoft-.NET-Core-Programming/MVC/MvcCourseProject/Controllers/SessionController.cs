using Microsoft.AspNetCore.Mvc;

namespace MvcCourseProject.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult SetData(string user, int age)
        {
            
            HttpContext.Session.SetString("user", user);
            HttpContext.Session.SetInt32("age", age);
            return Content("Saved Successfully");
        }

        public IActionResult GetData()
        {
            string user = HttpContext.Session.GetString("user");
            int? age = HttpContext.Session.GetInt32("age");
            return Content($"user name= {user} && Age ={age}");
        }
    }
}
