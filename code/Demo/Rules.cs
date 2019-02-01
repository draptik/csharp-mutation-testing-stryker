﻿using System;

namespace Demo
{
    public class Rules
    {
        public bool Validate(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            if (s.Length > 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AnotherValidation(int a, int b)
        {
            if (a + b == 10) return true;
            if (a - b == 10) return true;
            if (a * b == 10) return true;
            if (a / b == 10) return true;
            if (a % b == 10) return true;
            return false;
        }
    }
}
