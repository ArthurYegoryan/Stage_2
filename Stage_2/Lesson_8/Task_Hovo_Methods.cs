using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage_2.Lesson_8
{
    internal class Task_Hovo_Methods
    {
        decimal salary;
        decimal incomeTax;

        public Task_Hovo_Methods(ref decimal salary)
        {
            this.salary = salary;
        }

        public decimal IncomeTax(decimal salary)
        {
            incomeTax = salary * 15 / 100;
            salary = salary - (incomeTax);
            return salary;
        }

        public decimal SocialMaintenance(ref decimal salary)
        {
            salary = salary - (salary * 3 / 100);
            return salary;
        }

        public decimal CleanSalary(ref decimal salary)
        {
            salary = salary - incomeTax;
            return salary;
        }
    }
}
