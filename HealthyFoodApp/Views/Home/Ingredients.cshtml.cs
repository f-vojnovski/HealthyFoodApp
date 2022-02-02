using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HealthyFoodApp.Views.Home
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
    public class IngredientsModel : PageModel
    {
        public List<Ingredient> ingredients;

        private Ingredient ing = new Ingredient
        {
            Name = "Potassium",
            Description =
                "Potassium is one of the most important minerals in the body. It helps regulate fluid balance, muscle contractions and nerve signals. What's more, a high-potassium diet may help reduce blood pressure and water retention, protect against stroke and prevent osteoporosis and kidney stones."
        };

        public IngredientsModel()
        {
            ingredients = new List<Ingredient> { ing };
        }
        public void OnGet()
        {
        }
    }
}
