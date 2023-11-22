using System;

namespace MathandComparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Person 1");
            Console.WriteLine("Please input how much money you make per hour: ");
            int person1Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input hours per week that you work: ");
            int person1HoursWorks = Convert.ToInt32(Console.ReadLine());
            int person1paycheck = (person1Hourly * person1HoursWorks);
            Console.WriteLine("Person 1 paycheck:" + person1paycheck);
            int Salary1 = (52);
            int person1Salary = (person1paycheck * Salary1);
            Console.WriteLine("Person 1 Annual Salary " + person1Salary);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Please input how much money you make per hour: ");
            int person2Hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input hours per week that you work: ");
            int person2HoursWorks = Convert.ToInt32(Console.ReadLine());
            int person2paycheck = (person2Hourly * person2HoursWorks);
            Console.WriteLine("Person 1 paycheck:" + person2paycheck);
            int Salary2 = (52);
            int person2Salary = (person2paycheck * Salary2);
            Console.WriteLine("Person 2 Annual Salary " + person2Salary);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = Salary1;
            int person2 = Salary2;
            Console.WriteLine(Salary2 > Salary1);
            Console.ReadLine();





            //Console.WriteLine("Anonymous Income Comparison Program");
            //Console.ReadLine();
            //Console.WriteLine("Person 1");
            //Console.WriteLine("Hourly rate: 16.00" );
            //Console.WriteLine("Hours worked: 30");
            //Console.ReadLine();
            //int num1 = 480;
            //int num2 = 26;
            //int product1 = num1 * num2;
            //Console.WriteLine("Person 1 annual salary: " + product1 );
            //Console.ReadLine();
            //Console.WriteLine("Person 2");
            //Console.WriteLine("Hourly rate: 18.00");
            //Console.WriteLine("Hours worked: 35");
            //Console.ReadLine();
            //int num3 = 630;
            //int num4 = 26;
            //int product2 = num3 * num4;
            //Console.WriteLine("Person 2 annual salary: " + product2);
            //Console.ReadLine();
            //Console.WriteLine("Annual salary of Person 1: 12,480");
            //Console.WriteLine("Annual salary of Person 2: 16,380");
            //Console.ReadLine();
            //Console.WriteLine("Does Person 1 make more money than Person 2?");
            //string TorF = Console.ReadLine();
            //Console.WriteLine(TorF + "  Person 2 makes more money");
        }
    }
}
