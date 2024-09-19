using ManagingRestaurant.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ManagingRestaurant.Data
{
    public class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RestaurantContext(serviceProvider
                .GetRequiredService<DbContextOptions<RestaurantContext>>()))
            {
                //context.Database.EnsureCreated();
                //// blogs
                //if (context.Blogs.Any())
                //{
                //    return;
                //} 
                //var blogs = new Blog[] {
                //    new Blog{name = "abc",ShortDesc = "acb",Desciption ="<h1>acb</h1>"},
                //    new Blog{name = "Economics",ShortDesc = "Economics",Desciption ="<h1>Economics</h1>"},
                //    new Blog{name ="Mathematics",ShortDesc = "Mathematics",Desciption ="<h1>Mathematics</h1>"},
                //};
                //foreach (var blog in blogs)
                //{
                //    context.Blogs.Add(blog);
                //}
                //context.SaveChanges();

                //// Pages
                //if (context.Pages.Any())
                //{
                //    return;
                //}
                //var pages = new Page[] {
                //    new Page{name = "abcd",ShortDesc = "acb",Desciption ="<h1>acb</h1>"},
                //    new Page{name = "a",ShortDesc = "Economics",Desciption ="<h1>Economics</h1>"},
                //    new Page{name ="b",ShortDesc = "Mathematics",Desciption ="<h1>Mathematics</h1>"},
                //};
                //foreach (var page in pages)
                //{
                //    context.Pages.Add(page);
                //}
                //context.SaveChanges();
            }
        }

    }
}
