using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class CommissionEmployee : Employee
    {
        public double GrossSales { get; set; }
        public double CommissionRate { get; set; }

        public CommissionEmployee(int id, string name, double grossSales, double commissionRate) : base(id, name)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }

        public override double Earnings()
        {
            return GrossSales * CommissionRate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nGross Sales = {GrossSales:C}\nCommission Rate = {CommissionRate:P}\n\n";
        }
    }
}
