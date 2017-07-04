using System;
using System.Collections;

public class RandomList : ArrayList
{
    private Random rnd;


    public RandomList()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        //int element = rnd.Next(0, data.Count - 1);
        //string str = data[element];
        //data.Remove(str);
        //return str;

        return "Abra-Cadabra";
    }

}
