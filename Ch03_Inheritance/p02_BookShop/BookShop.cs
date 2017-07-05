using System;

namespace p02_BookShop
{
    public class BookShop
    {
        public static void Main()
        {
            string[] inParams = new string[3];

            for (int i = 0; i < 3; i++)
            {
                inParams[i] = Console.ReadLine().Trim();
            }

            try
            {
                Book newBook = new Book(inParams[1], inParams[0],decimal.Parse(inParams[2]));
                GoldenEditionBook newGoldenBook = new GoldenEditionBook(inParams[1], inParams[0],decimal.Parse(inParams[2]));

                Console.WriteLine(newBook);
                Console.WriteLine(newGoldenBook);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
