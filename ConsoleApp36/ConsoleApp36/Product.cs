﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public abstract void DisplayInfo();

    }
}

