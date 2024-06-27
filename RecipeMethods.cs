using System;
using System.Collections.Generic;
using System.Linq;

namespace ST10262898_PROG6221_PoeFinal
{
    internal class RecipeMethods
    {
        private List<Recipe> recipes;

        public RecipeMethods()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public void OrderRecipes()
        {
            var orderedRecipes = recipes.OrderBy(x => x.RecipeName).ToList();
            Console.WriteLine("Your ordered recipes are:");

            for (int i = 0; i < orderedRecipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {orderedRecipes[i].RecipeName}");
            }

            Console.WriteLine("Select a recipe to display (enter index):");
            if (int.TryParse(Console.ReadLine(), out int selectedIndex))
            {
                if (selectedIndex > 0 && selectedIndex <= orderedRecipes.Count)
                {
                    Console.ForegroundColor = GetNextColor(selectedIndex);
                    FinalRecipe(orderedRecipes[selectedIndex - 1]);
                    Console.ResetColor(); // Reset color to default
                }
                else
                {
                    Console.WriteLine("Invalid selection!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
            }
        }

        private void FinalRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.ToString());
        }

        private ConsoleColor GetNextColor(int index)
        {
            // Define an array of colors
            ConsoleColor[] colors = {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Blue,
                ConsoleColor.Yellow,
                ConsoleColor.Magenta,
                ConsoleColor.Cyan
            };

            // Return the color based on index
            return colors[(index - 1) % colors.Length];
        }
    }
}
