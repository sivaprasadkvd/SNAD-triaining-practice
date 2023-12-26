using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern2
{
    internal class pattern2
    {
        public static void Main(string[] args)
        {

            for (int i = 1; i <= 5; i++)
            {
                int a = i;

                for (int k = 1; k <= i; k++)
                {

                    Console.Write(a + " ");

                    a = a + 2;
                }

                Console.WriteLine();
            }
        }


    }
}
