﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    interface Calculate
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
    }

    class Result : Calculate
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
