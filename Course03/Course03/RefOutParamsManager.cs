﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Course03
{
    public class RefOutParamsManager
    {
        public int Add( int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //methd with ref
        public int AddWithRef(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method with out
        public int AddWithOut(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method with params
        public int AddWithParams(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
