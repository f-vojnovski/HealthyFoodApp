using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFoodApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodApp.ViewComponent
{
    public class GreeterViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private IGreeter _greeter;

        public GreeterViewComponent(IGreeter greeter)
        {
            _greeter = greeter;
        }

        public IViewComponentResult Invoke()
        {
            var model = _greeter.GetMessageOfTheDay();
            return View("Default", model);
        }
    }
}
