using System;

namespace Pizza_Recipe

{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new Pizza();
            
        
            Console.WriteLine("Welcome to making your favorite pizza at HOME!");

            Console.WriteLine("First, what is your favorite type crust, thick or thin?");
            pizza.CrustType = Console.ReadLine();
            Console.WriteLine("Great! Let's make a " + pizza.CrustType + " crust pizza!");

            Console.WriteLine("What toppings do you want on the pizza?");
            pizza.Toppings = Console.ReadLine();
            Console.WriteLine("What type of cheese?");
            pizza.CheeseType = Console.ReadLine();
            Console.WriteLine( pizza.Toppings + " with " + pizza.CheeseType + " sounds good on your " + pizza.CrustType + " crust pizza. Let's get started!");
            Console.WriteLine("See below for ingredients and instructions: ");
                     
            
            
            bool keepCooking = true;
            while (keepCooking)
            {
                Console.WriteLine("\n1. Choose this selection for instructions to make your THIN crust pizza.:");
                Console.WriteLine("\n2. Choose this selection for instructions to make your THICK crust pizza:");
                Console.WriteLine("\n3. Enter 3 to EXIT at any time.");
                Console.WriteLine("\n4. Check your pizza temperature while it is in the oven.");
                Console.WriteLine("\n5. Enter here to eat your pizza.");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        
                        Console.WriteLine("LIST of ingredients: ");
                        string[] pizzaIngredients = new string[6];
                        pizzaIngredients[0] = "*1 package of ready made bread dough";
                        pizzaIngredients[1] = "*Marinara sauce 1/2 cup";
                        pizzaIngredients[2] = "*Your selection of cheese";
                        pizzaIngredients[3] = "*Fresh chopped basil - handful";
                        pizzaIngredients[4] = "*Your choice of toppings";
                        pizzaIngredients[5] = "*Pizza pan or cookie sheet";

                        for (int i = 0; i < pizzaIngredients.Length; i++)
                        {
                            string ingredients = pizzaIngredients[i];
                            Console.WriteLine(ingredients);

                        }

                        Console.WriteLine("\nINSTRUCTIONS to assemble and bake your pizza");
                        Console.WriteLine("\n[]Preheat the oven to 450 degrees, \n[]Spread dough on pan, \n[]Spread marinara sauce on dough, \n[]Place two large handfuls of cheese on top of sauce.");
                        Console.WriteLine("[]Layer the toppings on top of the cheese and bake for 25 to 30 minutes.");
                        Console.WriteLine("\n");
                        pizza.Bake();
                        Console.WriteLine("Serve hot!");

                        

                        break;
                    case "2":
                        Console.WriteLine("LIST of ingredients: ");
                        string[] thickpizzaIngredients = new string[6];
                        thickpizzaIngredients[0] = "*Two packages of ready made bread dough";
                        thickpizzaIngredients[1] = "*Marinara sauce 1/2 cup";
                        thickpizzaIngredients[2] = "*Your selection of cheese";
                        thickpizzaIngredients[3] = "*Fresh chopped basil - handful";
                        thickpizzaIngredients[4] = "*Your toppings";
                        thickpizzaIngredients[5] = "*Pizza pan or cookie sheet";

                        for (int i = 0; i < thickpizzaIngredients.Length; i++)
                        {
                            string ingredients = thickpizzaIngredients[i];
                            Console.WriteLine(ingredients);
                        }

                        Console.WriteLine("INSTRUCTIONS to assemble and bake your pizza.");
                        Console.WriteLine("[]Preheat the oven to 450 degrees, \n[]Spread dough on pan, \n[]Spread marinara sauce on dough, \n[]Place two large handfuls of cheese on top of sauce.");
                        Console.WriteLine("[]Layer the toppings on top of the cheese and bake for 25 to 30 minutes. ");
                        Console.WriteLine("\n");
                        pizza.Bake();
                        Console.WriteLine("\nServe hot!");                                            
                        break;
                    case "3":
                        Console.WriteLine("Wait! Did you make sure to write down the list of instructions for next time? If so, hope you enjoy your " + pizza.CrustType + " crust pizza!");
                        keepCooking = false;
                        break;
                    case "4":
                        Console.WriteLine("Enter your oven temp here:   ");
                        int userTemp = Convert.ToInt32(Console.ReadLine());
                        pizza.SetOvenTemp(userTemp);                                        
                        pizza.CheckOnPizza();
                        Console.WriteLine($"Good idea to check your " + pizza.Toppings + pizza.CrustType + " crust pizza!");
                        break;
                    case "5":
                        pizza.EatPizza();
                        Console.WriteLine("\nYou have " + pizza.GetSlices() + " slices remaining!");
                        break;
                    default:
                        Console.WriteLine("Can't make pizza this way!");
                        break;

                }

                Console.WriteLine("press any key to continue");
                Console.ReadKey();
                Console.Clear();

            }

        }
                    
    }
}
