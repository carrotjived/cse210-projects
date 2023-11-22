using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Comments> firstVidComments = new();
        Video firstVideo = new("Vlog 255: 1 Hour loop of me breaking Malfoy's nose.", "Hermione Granger", 3600, firstVidComments);
        Comments firstVidFirstComment = new("Harry Potter", "You should've punched the other two.");
        Comments firstVidSecondComment = new("Albus Dumbledore", "Exemplary Straight! 50 points to Gryffindor!");
        Comments firstVidThirdComment = new("Draco Malfoy", "My Father will hear about this!");
        firstVidComments.Add(firstVidFirstComment);
        firstVidComments.Add(firstVidSecondComment);
        firstVidComments.Add(firstVidThirdComment);

        List<Comments> secondVidComments = new();
        Video secondVideo = new("Vlog 300: Should I go with Krum to the Yule Ball or should I wait for Ron?", "Hermione Granger", 300, secondVidComments);
        Comments secondVidFirst = new("Ginny Weasley", "Go with Krum. Just saw Ron figuring out how to fit three chicken legs in his mouth on the Great Hall.");
        Comments secondVidSecond = new("George Weasley", "Lost a bet to Fred, he fit four legs!");
        Comments secondVidThird = new("Neville Longbottom", "Ginny, would you like to go to the Yule Ball with me?");
        Comments secondVidFourth = new("Ginny Weasley", "Neville, of course.");
        Comments secondVidFifth = new("Albus Dumbledore", "Neville, smooth! 50 points to Gryffindor!");
        Comments secondVidSixth = new("Hermione Granger", "Ugh");
        secondVidComments.Add(secondVidFirst);
        secondVidComments.Add(secondVidSecond);
        secondVidComments.Add(secondVidThird);
        secondVidComments.Add(secondVidFourth);
        secondVidComments.Add(secondVidFifth);
        secondVidComments.Add(secondVidSixth);

        List<Comments> thirdVidComments = new();
        Video thirdVideo = new("Vlog 315: The Yule Ball!", "Hermione Granger", 450, thirdVidComments);
        Comments thirdVidFirst = new("Fred Weasley", "I bet Ronald was jealous of you dancing Krum.");
        Comments thirdVidSecond = new("Harry Potter", "Because Ronald wants to dance with Hermione, right?");
        Comments thirdVidThird = new("George Weasley", "Of course. Of course. Should there be another reason?");
        thirdVidComments.Add(thirdVidFirst);
        thirdVidComments.Add(thirdVidSecond);
        thirdVidComments.Add(thirdVidThird);


        List<Video> videos = new()
        {
            firstVideo,
            secondVideo,
            thirdVideo
        };

        foreach (Video video in videos)
        {
            Console.WriteLine();
            video.ShowVideoComments();
        }


    }
}