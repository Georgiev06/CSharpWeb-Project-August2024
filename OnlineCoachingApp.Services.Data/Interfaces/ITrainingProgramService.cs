using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCoachingApp.Web.ViewModels.Home;
using OnlineCoachingApp.Web.ViewModels.TrainingProgram;

namespace OnlineCoachingApp.Services.Data.Interfaces
{
    public interface ITrainingProgramService
    {
        Task<IEnumerable<IndexViewModel>> LatestTrainingPrograms();

        Task Add(TrainingProgramViewModel model);
    }
}
