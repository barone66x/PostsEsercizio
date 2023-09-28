using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostsEsercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ctx = new PostContext();
            var post = new Post { Title = "Primo Post", Body = "prova", PubDate = DateTime.Now };
            ctx.Posts.Add(post);
            Console.WriteLine(post.Code);
            ctx.SaveChanges();
            Console.WriteLine(post.Code);
            Console.ReadLine();
        }
    }
}
