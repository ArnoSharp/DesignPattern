﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.VisitorPattern
{
    class Mose : IComputerPart
    {
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
