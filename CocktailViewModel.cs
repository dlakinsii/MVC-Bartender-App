using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Bartender_App.Models;

namespace MVC_Bartender_App.ViewModels
{
    public class CocktailViewModel : Controller
    {
       public List<Cocktail> Cocktails { get; set; }
        public Customer ACustomer { get; set; } 
        public Bartender ABartender { get; set; }

    }
}