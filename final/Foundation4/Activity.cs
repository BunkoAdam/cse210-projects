using System;

public abstract class Activity
{
    private string _ASdate { get; set; }
    private double _ASlength { get; set; }

    public Activity(double ASlength)
    {
        _ASlength = ASlength;
    }

    public string ASGetDate() 
    {
        DateTime ASdate = DateTime.Now;
        string _ASdate = ASdate.ToString("dd MMM yyyy");
        return _ASdate;
    }

    public double ASGetLength()
    {
        return _ASlength;
    }

    public abstract double ASCalculateDistance();
    public abstract double ASCalculateSpeed();
    public abstract double ASCalculatePace();
    public abstract void ASDisplaySummary();
}