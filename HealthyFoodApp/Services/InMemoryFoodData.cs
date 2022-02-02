using System;
using System.Collections.Generic;
using System.Linq;
using HealthyFoodApp.Models;

namespace HealthyFoodApp.Services
{
    public class InMemoryFoodData : IFoodData
    {
        private List<Food> _foodList;
        public InMemoryFoodData()
        {
            _foodList = new List<Food>
            {
                new Food {Id = 1, Name = "Pizza"},
                new Food {Id = 2, Name = "Chips"},
                new Food {Id = 3, Name = "Smoki"}
            };
        }

        public IEnumerable<Food> GetAllFood()
        {
            return _foodList;
        }

        public IEnumerable<Food> SearchFoodByName(string query)
        {
            throw new NotImplementedException();
        }

        public Food Get(int id)
        {
            return _foodList.FirstOrDefault(food => food.Id == id);
        }

        public Food Add(Food newFood)
        {
            newFood.Id = _foodList.Max(food => food.Id) + 1;
            _foodList.Add(newFood);
            return newFood;
        }
    }

    
}
