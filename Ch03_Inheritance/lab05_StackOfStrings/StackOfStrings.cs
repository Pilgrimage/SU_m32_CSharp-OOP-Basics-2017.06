using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public StackOfStrings()
    {
        data = new List<string>();
    }


    public void Push(string element)
    {
        this.data.Add(element);
    }

    public string Pop()
    {
        var element = this.data.Last();
        this.data.Remove(element);
        return element;

        return "Miracle";
    }

    public string Peek()
    {
        return "Miracle";
    }

    public bool IsEmpty()
    {
        return true;
    }


}


