﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BridgePattern
{
    /// <summary>
    /// 一个桥接实体
    /// </summary>
    public class RedCircle : DrawAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine("Drowing Circle[ color : red]" +
                ", x :" + x + " , y : " + y + ", radius : " + radius);
        }
    }
}
