//NOTE TO INSTRUCTOR ----->>>>> SEE TESTS PROJECT FOR OBJECT TESTING




//Big O: O(1)
/**************************************************************
* Name        : DerivedClothingBrady
* Author      : Kabrina Brady
* Created     : 1/26/2021
* Course      : Data Structures
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access to
* my program.         
***************************************************************/

using System;

namespace SuperclassBrady
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clothing objects
            Clothing a = new Clothing(null, null);
            Clothing b = new Clothing("medium", "blue");
            Clothing c = new Clothing("L", "black");

            Console.WriteLine("CLOTHING OBJECTS:");
            Console.WriteLine(a.DisplayClothing() + ", " + a.Wash() + " " + a.Pack());
            Console.WriteLine(b.DisplayClothing() + ", " + b.Wash() + " " + b.Pack());
            Console.WriteLine(c.DisplayClothing() + ", " + c.Wash() + " " + c.Pack());
            Console.WriteLine();

            //Pants objects
            Pants pants = new Pants("large", "red");

            Console.WriteLine("PANTS OBJECT:");
            Console.WriteLine(pants.DisplayClothing() + ", " + pants.Wash() + " " + pants.Pack() + " " + pants.Hang());
            Console.WriteLine();

            //Shirt objects
            Shirt shirt = new Shirt("M", "gray", "short");

            Console.WriteLine("SHIRT OBJECT:");
            Console.WriteLine(shirt.DisplayClothing() + ", Sleeves: " + shirt.Sleeves + ", " + shirt.Wash() + " " + shirt.Pack() + " " + shirt.Hang());
        }
    }
}
