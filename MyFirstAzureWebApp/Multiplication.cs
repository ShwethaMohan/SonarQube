﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAzureWebApp
{
    public class Multiplication : ICalculation
    {
        private readonly decimal x;
        private readonly decimal y;

        public Multiplication(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }

        public decimal Calculate()
        {
            return x * y;
        }
    }
}
