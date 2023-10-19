﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Models
{
    public class Dog :IAnimal
    {
        public Dog(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Property implementation:
        public int X { get; set; }

        public int Y { get; set; }

        // Property implementation
        public double Distance =>
           Math.Sqrt(X * X + Y * Y);
    }
}
