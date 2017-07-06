namespace p04_OnlineRadioDatabase
{
    using System;

    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split(';');

                try
                {
                Console.WriteLine(input[2]);
                TimeSpan time = TimeSpan.Parse(input[2]);
                Console.WriteLine(time);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }



            }





        }
    }
}
