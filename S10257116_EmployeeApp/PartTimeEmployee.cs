using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class PartTimeEmployee : Employee
    {
        public double Dailyrate { get; set; }
        public int Daysworked { get; set; }
        public PartTimeEmployee(int id, string name, double dailyrate, int daysworked) : base(id, name)
        {
            Dailyrate = dailyrate;
            Daysworked = daysworked;
        }
        public override double CalculatePay()
        {
            double pay = Dailyrate * Daysworked;
            return pay;
        }
        public override string ToString()
        {
            return base.ToString() + $"Daily Rate: {Dailyrate}, Days Worked: {Daysworked}";
        }
    }
}
