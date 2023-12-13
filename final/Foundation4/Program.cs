using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> ASactivitiesList = new List<Activity>();

        Running ASrunning = new Running(30, 3);
        ASactivitiesList.Add(ASrunning);
        Cycling AScycling = new Cycling(45, 16);
        ASactivitiesList.Add(AScycling);
        Swimming ASswimming = new Swimming(60, 40);
        ASactivitiesList.Add(ASswimming);


        //display activity summaries
        foreach (Activity ASactivity in ASactivitiesList)
        {
            ASactivity.ASDisplaySummary();
        }
    }
}