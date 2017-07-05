using System;

namespace p03_Mankind
{
    public class Mankind
    {
        public static void Main()
        {
            try
            {
            string[] inStudent = Console.ReadLine().Split();
            Student student = new Student(inStudent[0], inStudent[1], inStudent[2]);

            string[] inWorker = Console.ReadLine().Split();
            Worker worker = new Worker(inWorker[0], inWorker[1], decimal.Parse(inWorker[2]), decimal.Parse(inWorker[3]));

            Console.WriteLine(student);
            Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }
    }
}
