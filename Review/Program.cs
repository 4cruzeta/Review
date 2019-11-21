using System;
using System.Globalization;
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
                    DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss",   // Resolvido com ParseExact !
                    CultureInfo.InvariantCulture),                                      
                    "TV Sound Exit",
                    "It has a headphone plug",
                    12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Nice!");
            Comment c4 = new Comment("Thanks for the information!");
            Post p2 = new Post(
                    DateTime.Parse("07/28/2018 23:14:19"),          // No código original foi preciso usar mês/ano !
                    "TV Voltage",                                   // Problema foi resolvido com ParseExact na    
                    "It is Bivolt 90v/240v",                        // ocorrencia anterior. Será que é o OSX (MAC) ?
                    5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
