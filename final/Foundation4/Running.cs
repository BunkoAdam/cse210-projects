using System;

public class Running : Activity
{
    private double _ASdistance { get; set; }

    public Running(double ASlength, double ASdistance) : base(ASlength)
    {
        _ASdistance = ASdistance;
    }

    public override double ASCalculateDistance()
    {
        return Math.Round(_ASdistance, 1);
    }

    public override double ASCalculateSpeed()
    {
        double ASspeed = Math.Round((ASCalculateDistance() / ASGetLength()) * 60, 1);
        return ASspeed;
    }

    public override double ASCalculatePace()
    {
        double ASpace = Math.Round(ASGetLength() / ASCalculateDistance(), 1);
        return ASpace;
    }

    public override void ASDisplaySummary()
    {
        Console.WriteLine($"{ASGetDate()} Running ({ASGetLength()} min) - Distance: {ASCalculateDistance()} miles, Speed: {ASCalculateSpeed()}mph, Pace: {ASCalculatePace()} min per mile");
    }
}