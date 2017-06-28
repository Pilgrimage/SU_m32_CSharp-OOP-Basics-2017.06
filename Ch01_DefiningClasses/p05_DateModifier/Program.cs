namespace p05_DateModifier
{
    using System;
    public class Program
    {
        public static void Main()
        {
            string date1AsStr = Console.ReadLine();
            string date2AsStr = Console.ReadLine();

            DateModifier diff = new DateModifier(date1AsStr, date2AsStr);

            Console.WriteLine(diff.CalculateDifference());
        }
    }

    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public string FirstDate
        {
            get { return firstDate; }
            set { this.firstDate = value; }
        }
        public string SecondDate
        {
            get { return secondDate; }
            set { this.secondDate = value; }
        }
        
        public DateModifier(string firstDate, string secondDate)
        {
            this.FirstDate = firstDate;
            this.SecondDate = secondDate;
        }

        public double CalculateDifference()
        {
            DateTime date1 = DateTime.ParseExact(FirstDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(SecondDate, "yyyy MM dd", System.Globalization.CultureInfo.InvariantCulture);

            return Math.Abs((date2 - date1).TotalDays);
        }

    }
}
