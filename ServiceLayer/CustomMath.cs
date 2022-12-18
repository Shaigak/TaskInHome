using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class CustomMath
    {

        public void Factorial(int n)
        {
            int result = 1;
            for (int i = 0; i <= n; i++)
            {
                result = result * i;

            }
            Console.WriteLine(result);
        }
    }
}
