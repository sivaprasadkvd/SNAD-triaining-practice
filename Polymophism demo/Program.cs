using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// polymorphism is a mechanism of changing the behavior based on the inputs given

namespace Polymophism_demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[11]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //Console.WriteLine ("Something went wrong.");
            }


        }
    }
    

    
}
