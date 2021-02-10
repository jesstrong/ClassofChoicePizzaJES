using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Recipe
{
    public class Pizza
    {

        // Properties 
        public string Toppings { get; set; }
        public int OvenTemp { get; set; }
        public string CheeseType { get; set; }
        public string CrustType { get; set; }
        public string Seasonings { get; set; }
        public string Sauce { get; set; }
        //public string GetToppings { get; set; }
        //public string GetSauce { get; set; }


       public int Slices { get; set;  }


        // constructors
        public Pizza()
        {
            Slices = 8; 
        }


        //constructors
        public Pizza(string toppings, string sauce, int ovenTemp, string cheeseType, string crustType, string seasonings)
        {

            Toppings = toppings;
            OvenTemp = ovenTemp;
            CheeseType = cheeseType;
            CrustType = crustType;
            Seasonings = seasonings;
            Sauce = sauce;
            
        }


        // Methods 

        public void Bake()
        {
            Console.WriteLine("Baking pizza with ingredients: " + GetToppings() + " " + GetSauce() + " " + GetCrustType() + "crust pizza.");
        }

        public void EatPizza()
        {
            Slices -= 1; 
        }


        public int GetSlices()
        {
            return Slices; 
        }





        public void SetCrustType(string crustType)
        {
            CrustType = crustType;
        }

        public string GetToppings()
        {
            return Toppings;
        }

        public string GetSauce()
        {
            return Sauce;
        }

        public string GetCrustType()
        {
            return CrustType;
        }


        public void SetOvenTemp(int ovenTemp)
        {
            OvenTemp = ovenTemp;
        }

        
        public void CheckOnPizza()
        {
            if (OvenTemp <= 450)
            {
                Console.WriteLine("Your pizza may not be cooked all the way."); 
            }

            else if (OvenTemp == 450)
            {
                Console.WriteLine("Your pizza is ready to come out of the oven!");
            }
                           
            else
            {
                Console.WriteLine("Your pizza is burned! oops!");
            }
        }
    }

}
