﻿using System;

namespace MethodsandObjects293
{
    class Program 
    {
        static void Main(string[] args)
        {
            Employee Obj1 = new Employee() { FirstName = "Sample", LastName = "Student", id = 5 };
            Obj1.SayName();
        }
    }
}