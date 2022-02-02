using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoodApp.Models;
using HealthyFoodApp.Services;
using HealthyFoodApp.ViewModels;
using HealthyFoodApp.Views.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HealthyFoodApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodData _foodData;
        private readonly IGreeter _greeter;

        public HomeController(IFoodData foodData)
        {
            _foodData = foodData;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.FoodList = _foodData.GetAllFood().ToList();

            return View(model);
        }

        [Route("/food/{id}")]
        public IActionResult Details(int id)
        {
            var model = _foodData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View("FoodDetails", model);
        }

        [Route("/ingredients")]
        public IActionResult IngredientDetails()
        {
            return View("Ingredients", new IngredientsModel());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("CreateFood");
        }

        [HttpPost]
        public IActionResult Create(FoodEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateFood");
            }
            var newFood = new Food();
            newFood.Name = model.Name;
            newFood.Type = model.Type;

            newFood = _foodData.Add(newFood);

            return RedirectToAction(nameof(Details), new {id = newFood.Id});
        }
    }
}
