﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Practice___Inheritance_JuanHernandez
{
    internal class Vehicle
    {
        // Field
        string _color;

        // Properties
        public string Color { get => _color; set => _color = value; }

        // Constructor
        public Vehicle(string color)
        {
            Color = color;
        }
        // Overide
        public override string ToString()
        {
            return this.GetType() + $" {Color}";
        }
    }
}
