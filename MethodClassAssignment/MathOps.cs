using System;
using System.Collections.Generic;
using System.Text;

namespace MethodClassAssignment
{
    class MathOps
    {
         public void Math1(int input1, int input2)
        {
            input1 += 7;

            
            
            
            Console.WriteLine("The second input was:  " + input2);
            
        }

        public static void NamedParameterFunction(string input1, string input2)
        {
            Console.WriteLine($"FullName: {input1} {input2}");
        }
    }
}
