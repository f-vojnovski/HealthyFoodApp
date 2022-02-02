using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoodApp.Models;

namespace HealthyFoodApp.ViewModels
{
    public class FoodEditModel
    {

        [Required, MaxLength(80)]
        public string Name { get; set; }
        
        public FoodType Type { get; set; }
    }
}
