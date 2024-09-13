using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.Infrastructure.Extensions;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;

namespace OnlineCoachingApp.Web.Controllers
{
    [Authorize]
    public class TrainingProgramController : Controller
    {
        private readonly ICategoryService _categoryService;

        private readonly ICoachService _coachService;

        public TrainingProgramController(ICategoryService categoryService, ICoachService coachService)
        {
            this._categoryService = categoryService;
            this._coachService = coachService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Add() 
        {
            //bool isCoach = await this._coachService.GetCoachByUserId(this.User.GetUserId()!);
                
            TrainingProgramViewModel trainingProgramViewModel = new TrainingProgramViewModel()
            {
                Categories = await this._categoryService.All()
            };

            return View(trainingProgramViewModel);
        }
    }
}
