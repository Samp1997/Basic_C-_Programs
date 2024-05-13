using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSubmissionassignment286
{
    class MathOps
    {
        //Method Math1 takes input1 and devides it by 2
        public void Math1(int input1)
        {
            Console.WriteLine(input1 / 2);

        }

        //This overload method has an output peramiter and takes the imput and devides it by 5
        public void Math1(int input2, out int output1)
        {
            output1 = input2 / 5;
        }
        
        

        

    }
   
    

    
}
