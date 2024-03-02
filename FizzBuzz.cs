using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab0_kardas_sr19
{
    internal class FizzBuzz
    {
        int uB;
        public FizzBuzz(int ub){
            uB = ub;
        }
        public void Display() {
            for (int i=1; i <= uB;i++) {
                if (i % 3==0 && i%5!=0)
                {
                    Console.Write("Fizz");
                }
                else if (i % 5 == 0 && i%3!=0)
                {
                    Console.Write("Buzz");
                }
                else if (i % 3 == 0 && i % 5==0)
                {
                    Console.Write("FizzBuzz");
                }
                else Console.Write(i);

                Console.WriteLine();
            }
        }
    }
}
