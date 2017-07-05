namespace p03_Mankind
{
    using System;
    using System.Text;
    using System.Linq;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10 || !value.All(char.IsLetterOrDigit))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(base.ToString())
                .AppendLine($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
