using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, decimal value)
        {
            employee.Salary += value;
            return employee;
        }
        public static Employee operator -(Employee employee, decimal value)
        {
            employee.Salary -= value;
            return employee;
        }

        public static bool operator ==(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Salary == secondEmployee.Salary;
        }

        public static bool operator !=(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Salary != secondEmployee.Salary;
        }

        public static bool operator >(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Salary > secondEmployee.Salary;
        }

        public static bool operator <(Employee firstEmployee, Employee secondEmployee)
        {
            return firstEmployee.Salary < secondEmployee.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this.Salary == employee.Salary;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Salary.GetHashCode();
        }

        public override string ToString()
        {
            return $"| Employee:\t{Name}\t|| Salary:\t{Salary}\t|";
        }

    }
}
