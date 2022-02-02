using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoodApp.Models;

namespace HealthyFoodApp.ViewModels
{
    public class HomeIndexViewModel
    {
        public List<Food> FoodList{ get; set; }
        public string CurrentMessage { get; set; }
    }
}
