using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineCoachingApp.Web.Controllers
{
    [Authorize]
    public class TrainingProgramController : Controller
    {
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            return View();
        }
    }
}
