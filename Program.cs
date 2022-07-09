using System;
using System.Collections.Generic;
using Exercise2.Entities;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employee {i} data: ");
                Console.Write("Outsourced? (y/n): ");
                string ch = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                if (ch.ToUpper() == "Y") {
                    Console.Write("Additional Charge: ");
                    double addCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, addCharge));
                } else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("Payments: ");
            foreach (Employee emp in list) {
                Console.WriteLine(emp.Name + " - R$" + emp.Payment().ToString("F2"));

            }
        }
    }
}
