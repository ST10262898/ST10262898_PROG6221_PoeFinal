using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262898_PROG6221_PoeFinal
{
    internal class Ingredient
    {
        public string IngredientName { get; set; }
        public double IngredientQuantity { get; set; }
        public string IngredientUnit { get; set; }
        public string StepDescription { get; set; }

        public Ingredient(string ingredientName, double ingredientQuantity, string ingredientUnit, string stepDescription)
        {
            this.IngredientName = ingredientName;
            this.IngredientQuantity = ingredientQuantity;
            this.IngredientUnit = ingredientUnit;
            this.StepDescription = stepDescription;
        }
    }
}
