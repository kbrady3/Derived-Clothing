using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassBrady
{
    public class Pants : Clothing
    {
        public Pants(string size, string color) : base(size, color)
        {

        }

        public override string Wash()
        {
            string instructions = "Dry clean only.";
            return instructions;
        }

        public string Hang()
        {
            string instructions = "Hang to dry.";
            return instructions;
        }
    }
}
