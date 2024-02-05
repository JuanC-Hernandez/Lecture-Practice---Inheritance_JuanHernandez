using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Practice___Inheritance_JuanHernandez
{
    internal class Sea : Vehicle
    {
        // Fields
        string _type;
        
        // Constructor
        public Sea(string color, string type) : base(color)
        {
            _type = type;
        }
        // Overide
        public override string ToString() 
        {
            return base.ToString() + $" - It is a {_type}";
        }
    }
}
