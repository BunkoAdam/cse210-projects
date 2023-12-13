using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        List<Video> ASvideosList = new List<Video>();

        Video ASvideo1 = new Video();
        ASvideo1._AStitle = "I survived 10 YEARS in Minecraft Superflat";
        ASvideo1._ASlength = "4770";
        ASvideo1._ASauthor = "Mogswamp";
        Comment ASvideo1Comment1 = new Comment();
        ASvideo1Comment1._ASname = "fWhip";
        ASvideo1Comment1._AScommentText = "This is extremely impressive. Well done on the journey so far! Very cool to see it's been going for 10 years!";
        Comment ASvideo1Comment2 = new Comment();
        ASvideo1Comment2._ASname = "gantnitsa";
        ASvideo1Comment2._AScommentText = "It's interesting that you can carry on to eventually bring us a 10 year retrospective. Looking forward to the 20 year one!";
        Comment ASvideo1Comment3 = new Comment();
        ASvideo1Comment3._ASname = "cattrash3113";
        ASvideo1Comment3._AScommentText = "It's absolutely insane that all of THIS can come from that little vanilla village in 2012! Mind-blowing";

        Video ASvideo2 = new Video();
        ASvideo2._AStitle = "THE END.";
        ASvideo2._ASlength = "390";
        ASvideo2._ASauthor = "Ken";
        Comment ASvideo2Comment1 = new Comment();
        ASvideo2Comment1._ASname = "BradCR";
        ASvideo2Comment1._AScommentText = "You know its serious when Ken doesnt stretch the video to 8 minutes";
        Comment ASvideo2Comment2 = new Comment();
        ASvideo2Comment2._ASname = "kbnen";
        ASvideo2Comment2._AScommentText = "One of the most beautiful story arcs I've ever witnessed, thank you";
        Comment ASvideo2Comment3 = new Comment();
        ASvideo2Comment3._ASname = "toasty0124";
        ASvideo2Comment3._AScommentText = "Rest in peace, soldier. We'll miss you";

        Video ASvideo3 = new Video();
        ASvideo3._AStitle = "The Mandalorian Season 4 Will Now Be a Movie";
        ASvideo3._ASlength = "470";
        ASvideo3._ASauthor = "Star Wars Theory";
        Comment ASvideo3Comment1 = new Comment();
        ASvideo3Comment1._ASname = "Bigdawg215";
        ASvideo3Comment1._AScommentText = "I'd rather a well written series than one movie but as long as it's a quality project it'll be a win for fans";
        Comment ASvideo3Comment2 = new Comment();
        ASvideo3Comment2._ASname = "Emojo5619";
        ASvideo3Comment2._AScommentText = "It was Jeff Sneider not Zack Snyder, great to hear your thoughts on the matter regardless.";
        Comment ASvideo3Comment3 = new Comment();
        ASvideo3Comment3._ASname = "samuraijedi1669";
        ASvideo3Comment3._AScommentText = "Mandalorian Season 4 is now a movie?? A suprise to be sure, but a welcomed one.";
        Comment ASvideo3Comment4 = new Comment();
        ASvideo3Comment4._ASname = "clubkid13";
        ASvideo3Comment4._AScommentText = "as long as it properly brings Mando and Grogu's story to a proper conclusion";

        //add comments to list for each video 
        ASvideo1._AScommentList.Add(ASvideo1Comment1);
        ASvideo1._AScommentList.Add(ASvideo1Comment2);
        ASvideo1._AScommentList.Add(ASvideo1Comment3);

        ASvideo2._AScommentList.Add(ASvideo2Comment1);
        ASvideo2._AScommentList.Add(ASvideo2Comment2);
        ASvideo2._AScommentList.Add(ASvideo2Comment3);

        ASvideo3._AScommentList.Add(ASvideo3Comment1);
        ASvideo3._AScommentList.Add(ASvideo3Comment2);
        ASvideo3._AScommentList.Add(ASvideo3Comment3);
        ASvideo3._AScommentList.Add(ASvideo3Comment4);

        //add each video to videosList 
        ASvideosList.Add(ASvideo1);
        ASvideosList.Add(ASvideo2);
        ASvideosList.Add(ASvideo3);

        foreach (Video ASvideo in ASvideosList)
        {
            ASvideo.ASDisplayVideoDetails();
            Console.WriteLine();
        }

    }
}