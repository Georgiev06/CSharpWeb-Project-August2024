using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineCoachingApp.Web.ViewModels.Home;

namespace OnlineCoachingApp.Services.Data.Interfaces
{
    public interface ITrainingProgramService
    {
        Task<IEnumerable<IndexViewModel>> LatestTrainingPrograms();
    }
}
