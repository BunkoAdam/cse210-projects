using System;

class Program
{
    static void Main(string[] args)
    {
        Address ASaddress1 = new Address ("5848 W 11000 N", "Highland", "UT", "884003", "USA");
        string ASlectureAddress = ASaddress1.ASGetAddress();
        Lectures ASlecture = new Lectures("Stake Conference", "Church meeting with members of the Highland 34th Stake.", "January 14, 2024", "10:00 am - 12:00 pm", $"{ASlectureAddress}", "Lecture", "Elder Whiting", 400);

        //display lecture event details
        Console.WriteLine("---------------------------------------------------------------------------");
        ASlecture.ASDisplayShortDescription();
        Console.WriteLine();
        ASlecture.ASDisplayStandardDetails();
        Console.WriteLine();
        ASlecture.ASDisplayLectureFullDetails();


        Address ASaddress2 = new Address ("9736 N 4800 W", "American Fork", "UT", "84003", "USA");
        string ASreceptionAddress = ASaddress2.ASGetAddress();
        Receptions ASreception = new Receptions("Bob and Sally", "Bob and Sally's wedding ceremony and reception", "April 7, 2024", "4:00 pm - 12:00am", $"{ASreceptionAddress}", "Reception", "Sally@gmail.com");
        //display reception event details
        Console.WriteLine("---------------------------------------------------------------------------");
        ASreception.ASDisplayShortDescription();
        Console.WriteLine();
        ASreception.ASDisplayStandardDetails();
        Console.WriteLine();
        ASreception.ASDisplayReceptionsFullDetails();


        Address ASaddress3 = new Address ("10189 N 4800 W", "Highland", "UT", "84003", "USA");
        string ASoutdoorAddress = ASaddress3.ASGetAddress();
        Outdoor ASoutdoor = new Outdoor("Lone Peak Football Game", "Lone Peak's final football game of the season", "November 24, 2023", "6:00 pm", $"{ASoutdoorAddress}", "Outdoor", "Raining");
        //display outdoor event details
        Console.WriteLine("---------------------------------------------------------------------------");
        
        ASoutdoor.ASDisplayShortDescription();
        Console.WriteLine();
        ASoutdoor.ASDisplayStandardDetails();
        Console.WriteLine();
        ASoutdoor.ASDisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}