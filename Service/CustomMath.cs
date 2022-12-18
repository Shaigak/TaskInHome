using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomMath
    {
        public void GetFactorial(int n)
        {
            int result = 1;
            for (int i = 0; i <= n; i++)
            {
                result = result*i;

            }
            Console.WriteLine(result);

        }

        public void GetArr(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

