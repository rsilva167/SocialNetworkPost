using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostInSM.Entities;

namespace PostInSM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip.");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
            DateTime.Parse("07/09/2022 20:22:33"),
            "Traveling to Brazil!",
            "I'm going to visit this wonderfull country!",
            12);

            p1.AddComments(c1);
            p1.AddComments(c2);

            Comment c3 = new Comment("Good night.");
            Comment c4 = new Comment("May the force be with you!");
            Post p2 = new Post(
            DateTime.Parse("06/09/2022 18:30:17"),
            "Good night guys",
            "See you tomorrow.",
            5);

            p2.AddComments(c3);
            p2.AddComments(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
