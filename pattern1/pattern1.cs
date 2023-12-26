using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__programs_and_patterns
{
    internal class pattern1
    {

        public static void Main(string[] args)
        {
            int x = 1;

            for (int i = 0; i < 4; i++)
                
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(x + " ");
                    x++;
                }
                Console.WriteLine();
            }
        }
        
    }
}
