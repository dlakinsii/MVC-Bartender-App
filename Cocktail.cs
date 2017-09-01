using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Bartender_App.Models
{
    public class Cocktail
    {
        
        public int CocktailId { get; set; }
        public string CocktailName { get; set; }
        public string FirstIngredient { get; set; }
        public string SecondIngredient { get; set; }
        public string ThirdIngredient { get; set; }
        public string FourthIngredient { get; set; }
        public string FifthIngredient { get; set; }
}
    

}
