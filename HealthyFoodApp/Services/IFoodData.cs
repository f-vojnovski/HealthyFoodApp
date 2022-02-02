using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoodApp.Models;

namespace HealthyFoodApp.Services
{
    public interface IFoodData
    {
        IEnumerable<Food> GetAllFood();

        IEnumerable<Food> SearchFoodByName(string query);

        Food Get(int id);
        Food Add(Food newFood);
    }
}
