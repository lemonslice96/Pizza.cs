using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _305_Probs
{
    class Pizza
    {
       
      
            public string Topping
            {
                get
                {
                    return topping;
                }
                set
                {
                    topping = value;
                }
            }
       
     
            class Program
            { 
                Pizza.Diameter = 16;
                Pizza.Radius = 8;
                Pizza.Price = 13.99;
                
            public static void Main();
           {
            Pizza pizza = new Pizza();
            Pizza.Topping = "Pepperoni";
           }
      }
  }


