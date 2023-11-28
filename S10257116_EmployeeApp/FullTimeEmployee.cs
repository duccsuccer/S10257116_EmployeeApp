using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class FullTimeEmployee : Employee
    {
        public double Basicpay { get; set; }
        public double Allowance { get; set; }
        public FullTimeEmployee(int id, string name, double basicpay, double allowance) : base(id, name)
        {
            Basicpay = basicpay;
            Allowance = allowance;
        }
        public override double CalculatePay()
        {
            double pay = Basicpay + Allowance;
            return pay;
        }
        public override string ToString()
        {
            return base.ToString() + $"Basic Pay: ${Basicpay}, Allowance ${Allowance} ";
        }
    }
}
