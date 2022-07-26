﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingLab.BLL.Exceptions;

namespace UnitTestingLab.BLL.Services
{
    public class MathService : IMathService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new Num2ZeroException();
            }

            return num1 / num2;
        }
    }
}
