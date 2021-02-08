using System;

namespace Pizza_Recipe

{
    public class Program
    {
        static void Main(string[] args)
        {

            Pizza pizza = new Pizza();
            Pizza veggiePizza = new Pizza("mushrooms", "red sauce", 450, "mozzarella", "thin", "oregano");

            Console.WriteLine("Welcome to how to make your favorite pizza at home!");

            Console.WriteLine("What is your favorite crust, thick or thin?");
            pizza.CrustType = Console.ReadLine();

            Console.WriteLine("Great! Let's make a " + pizza.CrustType + " crust pizza!");

            Console.WriteLine("What toppings do you want on the pizza?");
            pizza.Toppings = Console.ReadLine();
            Console.WriteLine("What type of cheese?");
            pizza.CheeseType = Console.ReadLine();

            Console.WriteLine( pizza.Toppings + " with " + pizza.CheeseType + " sounds good on your " + pizza.CrustType + " pizza, so let's get started!");

            Console.WriteLine("\n1. Choose the number 1 selection to make a veggie thin crust pizza:");
            Console.WriteLine("\n2. Choose the number 2 selection to make a thick crust pizza:");
            Console.WriteLine("\nEnter 3 if you want to EXIT at any time.");
            Console.WriteLine("\n4. Check on your pizza once in the oven.");
            
            bool keepCooking = true;
            while (keepCooking)
            {
            
                 string userChoice = Console.ReadLine();

                 switch (userChoice)
                 {
                    case "1":
                        //veggiePizza.Bake();

                        Console.WriteLine("Choose from the following speciality thin crust pizzas to make: ");
                        string[] pizzaIngredients = new string[6];
                        pizzaIngredients[0] = "1 package of ready made bread dough";
                        pizzaIngredients[1] = "marinara sauce 1/2 cup";
                        pizzaIngredients[2] = "mozzerella cheese";
                        pizzaIngredients[3] = "fresh chopped basil - handful";
                        pizzaIngredients[4] = "your choice of toppings";
                        pizzaIngredients[5] = "pizza pan or cookie sheet";

                        for (int i = 0; i < pizzaIngredients.Length; i++)
                        {
                            string ingredients = pizzaIngredients[i];
                            Console.WriteLine(ingredients);

                        }

                        Console.WriteLine("\nNow we are ready to put the ingredients together.");
                        Console.WriteLine("Preheat the oven to 450 degrees, \nspread dough on pan, \nspread marinara sauce on dough, \nplace two large handfuls of cheese on top of sauce.");
                        Console.WriteLine("Layer the toppings on top of the cheese and bake for 25 to 30 minutes.\nServe hot and ENJOY!!!");


                        break;
                    case "2":
                        Console.WriteLine("Here is your list of ingredients: ");
                        string[] thickpizzaIngredients = new string[6];
                        thickpizzaIngredients[0] = "Two packages of ready made bread dough";
                        thickpizzaIngredients[1] = "marinara sauce 1/2 cup";
                        thickpizzaIngredients[2] = "mozzerella cheese";
                        thickpizzaIngredients[3] = "fresh chopped basil - handful";
                        thickpizzaIngredients[4] = "your toppings";
                        thickpizzaIngredients[5] = "pizza pan or cookie sheet";

                        for (int i = 0; i < thickpizzaIngredients.Length; i++)
                        {
                            string ingredients = thickpizzaIngredients[i];
                            Console.WriteLine(ingredients);
                        }

                Console.WriteLine("\nNow we are ready to put the ingredients together.");
                Console.WriteLine("Preheat the oven to 450 degrees, \nSpread dough on pan, \nSpread marinara sauce on dough, \nPlace two large handfuls of cheese on top of sauce.");
                Console.WriteLine("Layer the toppings on top of the cheese and bake for 25 to 30 minutes.\nServe hot and ENJOY!!!");
                                
                        break;
                    case "3":
                        Console.WriteLine("Wait! Do you have the list of instructions? If so, hope you enjoy your " + pizza.CrustType + " crust pizza!");
                        keepCooking = false;
                        break;
                    case "4":
                        //pizza.CheckOnPizza();
                        Console.WriteLine("Enter your oven temp here: ");
                        int userTemp = Convert.ToInt32(Console.ReadLine());
                        if (userTemp == 450)
                        {
                            Console.WriteLine("Your pizza is not burned! You pizza should be not too crispy at " + pizza.OvenTemp + "!");
                        }
                        else 
                        {
                            Console.WriteLine("Your pizza is burned! oops!");
                        }
                                                                
                        Console.WriteLine($"Good idea to check your " + pizza.Toppings + " crust pizza!");
                        break; 
                    default:
                        Console.WriteLine("Can't make pizza this way!");
                        break;
                 }
                                             
                       

            }


        }
                    
    }
}
