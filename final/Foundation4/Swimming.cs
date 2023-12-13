using System;

public class Swimming : Activity
{
    private int _ASlaps { get; set; }

    public Swimming(double ASlength, int ASlaps) : base(ASlength)
    {
        _ASlaps = ASlaps;
    }

        public override double ASCalculateDistance()
    {
        double ASdistance =  Math.Round(_ASlaps * 50 / 1000 * 0.62, 1);
        return ASdistance;
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
        Console.WriteLine($"{ASGetDate()} Swimming ({ASGetLength()} min) - Distance: {ASCalculateDistance()} miles, Speed: {ASCalculateSpeed()}mph, Pace: {ASCalculatePace()} min per mile");
    }
}