﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A11.FacadePattern
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
