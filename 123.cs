using System;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car new1 = new Car(50);


            Console.WriteLine(new1.CurrentFuel);








            Console.WriteLine("Please enter a number: ");
            int count = int.Parse(Console.ReadLine());
            Employee employee = new Employee(0, "reis");
            Employee[] employees = new Employee[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Please enter employee Salary");
                employee.Salary = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter employee Position");
                employee.Position = Console.ReadLine();
                employee = new Employee(employee.Salary, employee.Position);
                string data = employee.ToString();
                employees[i] = employee;

            }
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine(employees[i]);
            }





            Console.WriteLine("Please type 'y' or 'n' in the console ");
            string input = Console.ReadLine();
            do
            {
                Console.WriteLine("Please type 'y' or 'n': ");
                input = Console.ReadLine();

            } while (input != "y" && input != "n");

            if (input == "y")
            {
                Console.WriteLine("Please enter full name: ");
                string fullname = Console.ReadLine();
                Console.WriteLine();
                


            }
            if (input == "n")
            {
                Console.WriteLine("end");
            }
        }
    }
} 
