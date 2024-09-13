using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Services.Data
{
    public class CoachService : ICoachService
    {
        private readonly OnlineCoachingAppDbContext _data;

        public CoachService(OnlineCoachingAppDbContext data)
        {
            this._data = data;
        }

        public async Task<bool> GetCoachByUserId(string userId)
        {
            bool result = await this._data.Coaches.AnyAsync(c => c.UserId.ToString() == userId);

            return result;
        }
    }
}
