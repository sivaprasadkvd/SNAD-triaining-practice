using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofcubes
{
    internal class pattern2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Enter a Number");

            int x = 12;

            int sum = 0;
            //Console.WriteLine(x.ToString().Length);

            for ( int i =0; i  <= x.ToString().Length; i++)
            {
                int lastDigt = x % 10;

                //Console.WriteLine(lastDigt);


                sum = sum + (lastDigt * lastDigt * lastDigt);

                x = x / 10;

            }
            Console.WriteLine(sum);



        }


    }
}
