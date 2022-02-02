using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HealthyFoodApp.Controllers
{
    [Route("about")]
    public class AboutController
    {
        [Route("")]
        public string Phone()
        {
            return "test";
        }
    }
}
