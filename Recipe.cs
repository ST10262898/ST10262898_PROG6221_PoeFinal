using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ST10262898_PROG6221_PoeFinal
{
    internal class Recipe
    {
        public string RecipeName { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Groups> Groups { get; set; }
        public List<string> StepDescriptions { get; set; }
        public string IngredientCalories { get; set; }

        public string ToString()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Recipe for {RecipeName}\n\nIngredients:\n");
            foreach (Ingredient ingredient in Ingredients)
            {
                message.Append($"{ingredient.IngredientName}\t\t{ingredient.IngredientQuantity}\t\t{ingredient.IngredientUnit}\n");
            }
            message.Append("\nSteps:\n");
            foreach (string step in StepDescriptions)
            {
                message.Append(step + "\n");
            }
            message.Append("\nEnjoy!\n");
            return message.ToString();
        }

        public int CalculateCalories()
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in Ingredients)
            {
                Console.WriteLine($"Enter the food group for {ingredient.IngredientName}:");
                string foodGroup = Console.ReadLine();

                Console.WriteLine($"Enter the number of calories for {ingredient.IngredientName}:");
                int ingredientCalories = int.Parse(Console.ReadLine());

                Groups group = new Groups(ingredient.IngredientQuantity, ingredientCalories.ToString(), foodGroup, ingredient);
                Groups.Add(group);

                totalCalories += ingredientCalories;

                if (totalCalories > 500)
                {
                    Console.WriteLine("This recipe is high in calories and should be consumed sparingly");
                }
                else if (totalCalories > 200)
                {
                    Console.WriteLine("This recipe has moderate calories, suitable for a balanced meal.");
                }
                else if (totalCalories < 200)
                {
                    Console.WriteLine("This recipe is low in calories, suitable for a snack.");
                }
            }
            return totalCalories;
        }

        public void scaled()
        {
            Console.WriteLine("Scaling Options:\n0\n0.5\n2\n3");
            double factor = double.Parse(Console.ReadLine());

            // Iterating over each ingredient to scale its quantity
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredient ingredient = Ingredients[i];

                if (factor == 0.5)
                {
                    Console.WriteLine("Quantities have been halved.");
                    ingredient.IngredientQuantity *= 0.5;
                    Console.WriteLine($"{ingredient.IngredientQuantity} {ingredient.IngredientUnit}");
                }
                else if (factor == 2)
                {
                    Console.WriteLine("Quantities have been doubled.");
                    ingredient.IngredientQuantity *= 2;
                    Console.WriteLine($"{ingredient.IngredientQuantity} {ingredient.IngredientUnit}");
                }
                else if (factor == 3)
                {
                    Console.WriteLine("Quantities have been tripled.");
                    ingredient.IngredientQuantity *= 3;
                    Console.WriteLine($"{ingredient.IngredientQuantity} {ingredient.IngredientUnit}");
                }
                else
                {
                    Console.WriteLine("Quantities remain the same.");
                    Console.WriteLine($"{ingredient.IngredientQuantity} {ingredient.IngredientUnit}");
                }

            }
        }
        public void clearData()
        {
            Ingredients.Clear();
            StepDescriptions.Clear();
            Console.WriteLine("Data cleared.");
        }

        public void Reset()
        {
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Groups[i].ResetQuantity();
            }
        }
    }
}
