using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    class Worker:Person
    {
        private decimal workhours;

        public decimal WokHours
        {
            get { return workhours; }
            set { workhours = value; }
        }
        private decimal perHour;

        public decimal PerHour
        {
            get { return perHour; }
            set { perHour = value; }
        }

        private decimal salary;

        public decimal Salary
        {
            get
            {
                return perHour*workhours;
            }
            
        }
        public Worker()
        {

        }
        public Worker(decimal workhours,decimal perHour,decimal salary, string name, int age, string egn, string sex):
            base(name,age,egn,sex)
        {
            PerHour = perHour;
            WokHours = workhours;
          
        }



    }
}
