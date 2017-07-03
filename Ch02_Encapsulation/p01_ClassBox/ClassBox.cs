namespace p01_ClassBox
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class ClassBox
    {
        public static void Main()
        {
            Type boxType = typeof(Box);
            FieldInfo[] fields = boxType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine(fields.Count());

            //double length  =double.Parse(Console.ReadLine());
            //double width = double.Parse(Console.ReadLine());
            //double height = double.Parse(Console.ReadLine());
            //Box box = new Box(length,width,height);

            double[] boxParams = new double[3];
            for (int i = 0; i < 3; i++)
            {
                boxParams[i] = double.Parse(Console.ReadLine());
            }
            Box box = new Box(boxParams[0], boxParams[1], boxParams[2]);

            
            Console.WriteLine($"{box.GetSurfaceArea()}\n{box.GetLateralSurfaceArea()}\n{box.GetVolume()}");
        }
    }
}
