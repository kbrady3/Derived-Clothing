using System;
using System.Collections.Generic;
using System.Text;

namespace SuperclassBrady
{
    public class Shirt : Clothing
    {
        //private string _sleeves;

        //public string Sleeves
        //{
        //    get
        //    {
        //        return _sleeves;
        //    }
        //    set
        //    {
        //        if (_sleeves == "short" || _sleeves == "long" || _sleeves == "none")
        //        {
        //            _sleeves = value;
        //        }
        //        else
        //        {
        //            throw new Exception("Sleeves must be short, long, or none.");
        //        }
        //    }
        //}

        public string Sleeves { get; set; }

        public Shirt(string size, string color, string sleeves) : base(size, color)
        {
            sleeves = sleeves.ToLower();

            if (sleeves == "short" || sleeves == "long" || sleeves == "none")
            {
                Sleeves = sleeves;
            }
            else
            {
                throw new ArgumentException("Sleeves must be short, long, or none.");
            }
            //_sleeves = sleeves;

            size = size.ToUpper();

            if (size == "S" || size == "M" || size == "L")
            {
                Size = size;
            }
            else
            {
                throw new ArgumentException("Size must be S, M, or L.");
            }
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
