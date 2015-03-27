namespace _02.StudentAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSekary;

       
        private decimal workHoursPerDay;

     
        public Worker(string workerFirstName,string workerLastName,decimal weekSelaryWorker,decimal workHouerPerDerOfWorker)
            :base(workerFirstName,workerLastName)
        {
            this.WeekSekary = weekSelaryWorker;
            this.WorkHoursPerDay = workHouerPerDerOfWorker;
        }

        public decimal WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public decimal WeekSekary
        {
            get { return weekSekary; }
            set { weekSekary = value; }
        }

        public void MoneyPerHour()
        {

        }
    }
}
