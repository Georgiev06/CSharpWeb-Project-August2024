using Microsoft.EntityFrameworkCore;
using OnlineCoachingApp.Services.Data.Interfaces;
using OnlineCoachingApp.Web.Data;
using OnlineCoachingApp.Web.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCoachingApp.Services.Data
{
    public class CategoryService : ICategoryService
    {
        private readonly OnlineCoachingAppDbContext _data;

        public CategoryService(OnlineCoachingAppDbContext data)
        {
            this._data = data;
        }

        public async Task<IEnumerable<CategoryViewModel>> All()
        {
            IEnumerable<CategoryViewModel> categories = await this._data.Categories
                .AsNoTracking()
                .Select(c => new CategoryViewModel() 
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToArrayAsync();


            return categories;
        }
    }
}
