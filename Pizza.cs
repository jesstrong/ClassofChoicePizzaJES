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
        public string GetToppings { get; set; }
        public string GetSauce { get; set; }



        // constructors
        public Pizza()
        {

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

        //public void Bake()
        //{
        //    Console.WriteLine("Baking pizza with ingredients: " + GetToppings() + " " + GetSauce() + " " + GetCrustType() + ""); 
        //}
        public void SetCrustType(string crustType)
        {
            CrustType = crustType; 
        }

        //public string GetToppings()
        //{
        //    return Toppings;
        //}

        //public string GetSauce()
        //{

        //}

        //public string GetCrustType()
        //{

        //}
       public void CheckOvenTemp()
        {
            
        }
        public void CheckOnPizza()
        {
            /////not used   
        }
    }

}
