using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Practice___Inheritance_JuanHernandez
{
    internal class Plane : Air
    {
        // Fields
        int _numberOfJets;
        // Constructor
        public Plane(string color, int numberofjets) : base(color)
        {
            _numberOfJets = numberofjets;
        }
        // Override To String
        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets {_numberOfJets}";
        }
    }
}
