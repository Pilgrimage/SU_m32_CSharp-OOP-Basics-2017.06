using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager manager;

    public Engine()
    {
        this.isRunning = true;
        this.manager = new DraftManager();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inCommand = Console.ReadLine();
            List<string> commParams = inCommand.Split(' ').ToList();
            this.DistributeCommand(commParams);
        }
    }


    private void DistributeCommand(List<string> commParams)
    {
        string command = commParams[0];
        commParams.Remove(command);

        switch (command)
        {
            case "RegisterHarvester":
                this.OutputWriter(this.manager.RegisterHarvester(commParams));
                break;
            case "RegisterProvider":
                this.OutputWriter(this.manager.RegisterProvider(commParams));
                break;

            case "Day":
                this.OutputWriter(this.manager.Day());
                break;

            case "Mode":
                this.OutputWriter(this.manager.Mode(commParams));
                break;

            case "Check":
                this.OutputWriter(this.manager.Check(commParams));
                break;

            case "Shutdown":
                this.OutputWriter(this.manager.ShutDown());
                this.isRunning = false;
                break;
        }
    }


    private void OutputWriter(string status)
    {
        Console.WriteLine(status);
    }

}
