using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of Numbers in Array");

            var sumNumbers = numbers.Sum(w => w);
            Console.WriteLine(sumNumbers);

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers in Array");

            var avgNumbers = numbers.Average(w => w);
            Console.WriteLine(avgNumbers);

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Ascending Order:");

            var ascendingNum = numbers.OrderBy(w => w);

            foreach (var num in ascendingNum) 
            {  
                Console.WriteLine(num);
            }

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Descending Order:");
            var descendingNum = numbers.OrderByDescending(w => w);
           
            foreach(var num in descendingNum) 
            {
                Console.WriteLine(num);
            }


            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Greater than 6");

            var greaterSix = numbers.Where(w => w > 6);
            foreach (var num1 in greaterSix) 
            { 
                Console.WriteLine(num1); 
            }



            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Numbers in order but only printing 4");

            var orderFour = numbers.OrderBy(w => w).Take(4);
            foreach (var num2 in orderFour)
            {
                Console.WriteLine(num2);
            }


            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
            Console.WriteLine("Change index 4 to age, decending order");

            numbers.SetValue(36, 4);
            foreach (var num3 in descendingNum)
            {
                Console.WriteLine(num3);
            }

            
            
            


            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            var fullNameCandS = employees.Where(w => w.FirstName.StartsWith("C") || w.FirstName.StartsWith("S")).OrderBy(w => w.FirstName);
            
            foreach (var fullNameVar in fullNameCandS) 
            { 
                Console.WriteLine(fullNameVar.FullName); 
            }

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Fullname and Age Over 26");

            var fullNameAgeOver26 = employees.Where(w => w.Age > 26).OrderBy(w => w.Age).ThenBy(w => w.FirstName);

            foreach (var fNameAge26 in fullNameAgeOver26)
            {
                Console.WriteLine($"{fNameAge26.FullName}, {fNameAge26.Age}");
            }

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of YOE 10 Age 35");
            int sumYOE1035 = employees.Where(w => w.YearsOfExperience <= 10 && w.Age > 35).Sum(w => w.YearsOfExperience);
            Console.WriteLine(sumYOE1035);



            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average of YOE 10 Age 35");

            var avgYOE1035 = employees.Where(w => w.YearsOfExperience <= 10 && w.Age > 35).Average(w => w.YearsOfExperience);
            Console.WriteLine(avgYOE1035);

            //TODO: Add an employee to the end of the list without using employees.Add()
            //use append

            //employees.Append()


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
