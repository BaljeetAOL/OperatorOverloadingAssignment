using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee
            Employee emp1 = new Employee();

            // Give values to emp1
            emp1.Id = 1001;
            emp1.FName = "John";
            emp1.LName = "Smith";

            // Create second employee
            Employee emp2 = new Employee();

            // Give values to emp2
            emp2.Id = 1001;
            emp2.FName = "Jane";
            emp2.LName = "Doe";

            // Compare employees
            bool isEqual = emp1 == emp2;
            bool isNotEqual = emp1 != emp2;

            // Show employee details
            Console.WriteLine($"Employee 1: {emp1.FName} {emp1.LName}");
            Console.WriteLine($"Employee 2: {emp2.FName} {emp2.LName}");

            // Show comparison results
            Console.WriteLine($"emp1 == emp2: {isEqual}");
            Console.WriteLine($"emp1 != emp2: {isNotEqual}");

            Console.ReadLine();
        }
    }
}