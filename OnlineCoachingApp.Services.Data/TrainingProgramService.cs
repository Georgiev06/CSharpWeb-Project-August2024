using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.Data;
using OnlineCoachingApp.Web.ViewModels.Home;

namespace OnlineCoachingApp.Services.Data
{
    public class TrainingProgramService : ITrainingProgramService
    {
        private readonly OnlineCoachingAppDbContext _data;

        public TrainingProgramService(OnlineCoachingAppDbContext data)
        {
            this._data = data;
        }

        public async Task<IEnumerable<IndexViewModel>> LatestTrainingPrograms()
        {
            IEnumerable<IndexViewModel> latestPrograms = await this._data.TrainingPrograms
                .OrderByDescending(tp => tp.CreatedOn)
                .Take(5)
                .Select(tp => new IndexViewModel
                {
                    Id = tp.Id.ToString(),
                    Name = tp.Name,
                    ImageUrl = tp.ImageUrl,
                    Price = tp.Price
                })
                .ToListAsync();

            return latestPrograms;
        }
    }
}
