using System.Collections.Generic;
using System.Linq;
using HealthyFoodApp.Data;
using HealthyFoodApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyFoodApp.Services
{
    public class SQLFoodData : IFoodData
    {
        private readonly HealthyFoodAppDbContext _context;

        public SQLFoodData(HealthyFoodAppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Food> GetAllFood()
        {
            return _context.Foods.OrderBy(f => f.Name);
        }

        public Food Get(int id)
        {
            return _context.Foods
                .Include(t => t.AdditionalInformation)
                .FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Food> SearchFoodByName(string query)
        {
            throw new System.NotImplementedException();
        }


        public Food Add(Food newFood)
        {
            _context.Foods.Add(newFood);
            _context.SaveChanges();
            return newFood;
        }
    }
}
