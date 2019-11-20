using System;
using Review.Entities;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Good to know this!");
            Comment c2 = new Comment("Nice!");
            Post p1 = new Post(
                    DateTime.Parse("06/21/2018 13:05:44"),
                    "TV Sound Exit",
                    "It has a headphone plug",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Nice!");
            Comment c4 = new Comment("Thanks for the information!");
            Post p2 = new Post(
                    DateTime.Parse("07/28/2018 23:14:19"),
                    "TV Voltage",
                    "It is Bivolt 90v/240v",
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
