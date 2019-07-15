using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Helpers;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(HttpHeaderItem Items)
        {
            return View(ReflectionHelper.DictionaryFromType(Items));
        }
    }
}