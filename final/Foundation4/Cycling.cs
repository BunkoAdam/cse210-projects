using System;

public class Cycling : Activity
{
    private double _ASspeed { get; set; }

    public Cycling(double ASlength, double ASspeed) : base(ASlength)
    {
        _ASspeed = ASspeed;
    }

        public override double ASCalculateDistance()
    {   
        double ASdistance = Math.Round(ASGetLength() * ASCalculateSpeed() / 60, 1);
        return ASdistance;
    }

    public override double ASCalculateSpeed()
    {
        return Math.Round(_ASspeed, 1);
    }

    public override double ASCalculatePace()
    {
        double ASpace = Math.Round(60 / ASCalculateSpeed(), 1);
        return ASpace;
    }

    public override void ASDisplaySummary()
    {
        Console.WriteLine($"{ASGetDate()} Cycling ({ASGetLength()} min) - Distance: {ASCalculateDistance()} miles, Speed: {ASCalculateSpeed()}mph, Pace: {ASCalculatePace()} min per mile");
    }
}