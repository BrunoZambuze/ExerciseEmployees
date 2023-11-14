using ExerciseEmployees.Entities;
using System;
using System.Globalization;
using System.Collections.Generic;
namespace ExerciseEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees:");
            int qntd = int.Parse(Console.ReadLine());
            List<Employee>ListEmployee = new List<Employee>();
            for (int i = 0; i < qntd; i++)
            {
                Console.WriteLine($"\nEmployee #{i + 1} data:");
                Console.Write("Outsourced (y/n)?: ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double value = double.Parse(Console.ReadLine());
                if (resp == 'y' || resp == 'Y')
                {
                    Console.Write("Additional Charge:");
                    double additional = double.Parse(Console.ReadLine());
                    ListEmployee.Add(new OutsourcedEmployee(name, hours, value, additional));
                }
                else
                {
                    ListEmployee.Add(new Employee(name, hours, value));
                }
            }
            Console.WriteLine();
            Console.WriteLine("***Payments***");
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"{emp.Name} - R$ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}