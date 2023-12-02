using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        LectureEvent lecture = new("Professor Alastor Moody", 25, "London's Top DeathEathers", "An introduction to the most notorious Death Eaters roaming around London.", "Burke Street", "Well City", "London", "London", 15, "October", 2005, 7, 30);
        lecture.LectureStandardDetails();
        lecture.LectureFullDetails();
        lecture.LectureShortDescription();

        ReceptionEvent reception = new("McGonagall@hogwarts", "Triwizard Tournament Viewing","Live  play by play of the challenges faced by the champions chosen by the Goblet of Fire. Yes, Harry Potter is also participating", "Hogwarts School of Witchcraft and Wizardry", "Hogwart's Castle", "Scottish Highlands", "United Kingdom", 24, "November", 1994, 9, 00);
        reception.ReceptionStandardDetails();
        reception.ReceptionFullDetails();
        reception.ReceptionShortDescription();


        OutdoorEvent outdoor = new("Good Weather", "Bill and Fleur Wedding", "Witness the wedding of Charlie Weasley and Fleur Delacour.", "Weasley Burrow", "Devon", "Devon", "England", 1, "August", 1997, 8, 30);
        outdoor.OutdoorStandardDetails();
        outdoor.OutdoorFullDetails();
        outdoor.OutdoorShortDescription();

    }
}