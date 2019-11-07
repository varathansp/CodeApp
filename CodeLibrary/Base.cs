using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeLibrary
{
    public class Base
    {
        public int Factorial(int input)
        {
            int sum = 1;
            for (int i = 1; i <= input; i++)
            {
                sum  = i * sum; 
            }
            return sum;
        }
    }
}
