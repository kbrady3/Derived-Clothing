using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassBrady
{
    public class Clothing
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public Clothing() { }

        public Clothing(string size, string color)
        {
            Size = size;
            Color = color;
        }

        public string DisplayClothing()
        {
            string details = "Size: " + Size + ", Color: " + Color;
            return details;
        }

        public virtual string Wash()
        {
            string instructions = "Wash in cold water.";
            return instructions;
        }

        public string Pack()
        {
            string instructions = "Fold first.";
            return instructions;
        }
    }
}
