using Microsoft.AspNetCore.Mvc;
using MVC_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_application.ViewComponents
{
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly SpecialsDataContext _specials;
        public MonthlySpecialsViewComponent(SpecialsDataContext specials)
        {
             _specials = specials;
        }
        public IViewComponentResult Invoke()
        {
            var specials = _specials.GetMonthlySpecials();
            return View(specials);
        }
    }
}
