﻿using System;
using System.Collections.Generic;
namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] testScores = { 98, 99, 95, 70, 34, 91, 94, };


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);
            //Console.ReadLine();

            Console.WriteLine("Select a test score");
            Console.ReadLine();
            Console.WriteLine();
            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score:" + score);
                }
                Console.ReadLine();
                if (score < 85)
                    
                {
                    Console.WriteLine("Failing test score:" + score);
                }
              
            }

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();





            //string[] names = { "Jesse", "Erik", "Daniel", "adam" };

            //for (int j = 0; j < names.Length; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}
            //if (names != List Console.WriteLine("This Name does not exsist") ;

            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "adam" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            //int[] testScores = { 98, 99, 95, 70, 34, 91, 94, };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>() { 98, 99, 12, 74, 21, 99, };
            //List<int> passingScores = new List<int>();

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        passingScores.Add(score);
            //    }
            //}
        }
    }
}
