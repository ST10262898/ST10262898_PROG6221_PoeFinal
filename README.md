READ ME
This application is based on ingredients and recipes. The application allows users to input their ingredients and steps. This is how to use it.

The user must unzip the download file. Right-click the .sln file and open it using Visual Studio. The user must press Ctrl + Shift + B simultaneously to build the solution. After the solution has been built successfully, the F5 key can be pressed to run the application. 

Now that the application is running – the user can follow the screen prompts to interact with the application. The user is greeted with a menu consisting of: 
1. Add new recipe
2. Display a specific recipe
3. View all recipes
4. Scale a recipe
5. Reset ingredient quantities
6. Clear a recipe
7. Exit
The number’s 1 through 5 can be selected based on what the user wants to use the application for. 
_________________________________________________________________________________
If option 1 is selected, the user will be prompted to enter the:
Name of the recipe
The number of ingredients 
	This will determine how many times the following will be asked:
Ingredient Name
Ingredient Quantity
Ingredient Measuring units
The number of steps
	This will determine how many times the following will be asked:
		Description of steps
The amount if calories
The user will select a food group from the following options:
	Carbohydrates
	Protein
	Dairy
	Fruit and vegetables
	Fats and sugars
If option 2 is selected, the user will be shown the list of all the recipes they have saved. The user can select which of the recipes. The recipe that they selected will then be displayed. The information that will be displayed if the same information that was inputted above in option 1
If option 3 is selected, the user will be shown a list of their recipes. 
If option 4 is selected, the user will be prompted to select a recipe from the display. The recipe’s quantities will then be scaled based on the user’s selection from:
x0.5
x1
x2
x3
The new quantities will then be displayed.
If option 5 is selected, the user will be prompted to select a recipe. The selected recipe’s quantities will then be reset to the original quantities. This can only be done if the user has scaled the recipe. If the recipe was not scaled…the quantities will simply remain the same
If option 6 is selected, the user will select a recipe from the display to be deleted. This will clear all the values and the recipe will no longer show in the displays. 
If option 7 is selected, the application will close.
When using the WPF application, the user will be prompted to enter a choice of filtration. 
This can be done by:
Entering an ingredient
Selecting a food group from the drop-down menu
Entering a maximum number of calories. 
The application will filter through the array of recipes and display the recipes that meet the user’s needs. 
