using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    abstract class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract double CalculatePay();
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name} ";
        }
        public int CompareTo(Employee employee)
        {
            return Id.CompareTo(employee.Id);
        }
    }
}
