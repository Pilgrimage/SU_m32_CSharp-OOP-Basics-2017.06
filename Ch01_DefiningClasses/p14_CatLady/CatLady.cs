namespace p14_CatLady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CatLady
    {
        public static void Main()
        {
            List<Cat> cats = new List<Cat>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inParams = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (inParams[0])
                {
                    case "Siamese":
                        Siamese newSiam = new Siamese(inParams[1], int.Parse(inParams[2]));
                        cats.Add(newSiam);
                        break;

                    case "Cymric":
                        Cymric newCym = new Cymric(inParams[1], double.Parse(inParams[2]));
                        cats.Add(newCym);
                        break;

                    case "StreetExtraordinaire":
                        StreetExtraordinaire newExtra = new StreetExtraordinaire(inParams[1], int.Parse(inParams[2]));
                        cats.Add(newExtra);
                        break;
                }
            }

            string targetCatName = Console.ReadLine();

            var targetCat = cats.FirstOrDefault(x => x.Name == targetCatName);

            if (targetCat != null)
            {
                Console.WriteLine(targetCat.ToString());
            }
        }
    }
}
