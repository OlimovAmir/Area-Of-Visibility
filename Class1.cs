using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Of_Visibility
{
     class Class1
    {
        static int b = 11;

        static void Foo()
        {
            //int b = 25;
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            
             
            for (int i = 0; i < 5; i++)
            {
                i = i + 1;
                Console.WriteLine(i);   
            }
            Foo();
        }
    }
}
