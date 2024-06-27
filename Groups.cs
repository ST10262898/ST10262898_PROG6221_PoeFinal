using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10262898_PROG6221_PoeFinal
{
    internal class Groups
    {
        private double OriginalQuantity { get; set; }
        public string IngredientCalories { get; set; }
        public string FoodGroup { get; set; }

        private Ingredient ingredient;

        public Groups(double originalQuantity, string ingredientCalories, string foodGroup, Ingredient ingredient)
        {
            this.OriginalQuantity = originalQuantity;
            this.IngredientCalories = ingredientCalories;
            this.FoodGroup = foodGroup;
            this.ingredient = ingredient;
        }

        public void ResetQuantity()
        {
            ingredient.IngredientQuantity = OriginalQuantity;
        }
    }
}
