using System;
using Composition2.Entities;

namespace Composition2
{
    class Program
    {
        static void Main(string[] args)
        {
            string title1 = "Traveling to New Zealand";
            int likes1 = 12;
            DateTime moment1 = DateTime.Parse("21/06/2018 13:05:44");
            string content1 = "I'm going to visit this wonderful country!";
            Post post1 = new Post(moment1,title1,content1,likes1);

            Comment comment1 = new Comment("Have a nice trip");
            post1.AddComment(comment1);

            Comment comment2 = new Comment("Wow that's awesome!");
            post1.AddComment(comment2);

            string title2 = "Good night guys";
            int likes2 = 5;
            DateTime moment2 = DateTime.Parse("28/07/2018 23:14:19");
            string content2 = "See you tomorrow";
            Post post2 = new Post(moment2,title2,content2,likes2);

            Comment comment3 = new Comment("Good night");
            post2.AddComment(comment3);
            Comment comment4 = new Comment("May the force be with you");
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);



        }
    }
}
