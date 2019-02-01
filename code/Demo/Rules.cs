using System;

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
            if (a % b == 1) return true;
            return false;
        }
    
        public int Looping(int a)
        {
            var result = 0;
            for (int i = 0; i < a; i++)
            {
                result++;
            }
            return result;
        }
    }
}
