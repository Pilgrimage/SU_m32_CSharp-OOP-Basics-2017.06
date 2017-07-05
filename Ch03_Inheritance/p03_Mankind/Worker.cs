namespace p03_Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;
            }
        }
        
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.workHoursPerDay = value;
            }
        }
        
        public override string LastName
        {
            get { return base.LastName; }
            set
            {
                if (value.Length < 4)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");  // this message is fake!
                }
                base.LastName = value;
            }
        }


        private decimal CalculateSalaryPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5m);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Week Salary: {this.WeekSalary:f2}")
                .AppendLine($"Hours per day: {this.WorkHoursPerDay:f2}")
                .AppendLine($"Salary per hour: {this.CalculateSalaryPerHour():f2}");

            return sb.ToString();
        }

    }
}
