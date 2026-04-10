using DataBaseApproach.Data;
using DataBaseApproach.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {

        var context = new PlutoDbContext();
        var post = new Post()
        {
            Body = "Body",
            Title = "Title",
            DatePublished = DateTime.Now,
            PostId = 1
        };

        context.Posts.Add(post);
        context.SaveChanges();


    }
}