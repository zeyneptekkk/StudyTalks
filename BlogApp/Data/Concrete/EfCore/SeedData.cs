using BlogApp.Data.Concrete.EfCore;
using BlogApp.Entity;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using static BlogApp.Entity.Tag;






namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();
            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                         new Tag { Text = "web programlama", Url="web-proglamlama",Color=TagColors.warning},
                         new Tag { Text = "backend", Url = "backend", Color = TagColors.success },
                         new Tag { Text = "frontend", Url = "frontend", Color = TagColors.success },
                         new Tag { Text = "fullstack", Url = "fullstack", Color = TagColors.secondary },
                         new Tag { Text = "php", Url = "php", Color = TagColors.secondary }
                       
                     );
                    context.SaveChanges();
                }
                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                       new User { UserName = "ZeynepTek",Name="Zeynep Tek",Email="tekzeynep043@gmail.com",Password="1234", Image="p3.jpg"},
                       new User { UserName = "AsyaPekgöz", Name = "Asya Pekgöz", Email = "tekasiye043@gmail.com", Password = "166634", Image = "p4.jpg" }
                 );
                    context.SaveChanges();
                }
                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "Asp.net core",
                            Description = "Asp.net core dersleri",
                            Content = "Asp.net core dersleri",
                            Url= "asp.net core",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(5).ToList(),
                            UserId = 1,
                            Comments = new List<Comment>
                            {
                                new Comment { Text = "iyi bir kurs", PublishedOn =  DateTime.Now.AddDays(-10), UserId = 2 },
                                new Comment { Text = "çok faydalandığım bir kurs", PublishedOn =  DateTime.Now.AddDays(-70), UserId = 1 }
                            }

                        },
                        new Post
                        {
                            Title = "PHP ",
                            Description = "PHP dersleri",
                            Content = "PHP dersleri",
                            Url= "php",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(1).ToList(),
                            UserId = 1
                        },

                        new Post
                        {
                            Title = "Django",
                            Description = "Django dersleri",
                            Content = "Django dersleri",
                            Url = "django",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(1).ToList(),
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "React Dersleri",
                            Content = "React Dersleri",
                            Url = "react-dersleri",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-25),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }, new Post
                        {
                            Title = "Angular",
                            Content = "Angular dersleri",
                            Url = "angular",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-51),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 2
                        }, new Post
                        {
                            Title = "Web Tasarım",
                            Content = "Web Tasarım dersleri",
                            Url = "web-tasarım",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-7),
                            Tags = context.Tags.Take(1).ToList(),
                            UserId = 2
                        }





                        );
                    context.SaveChanges();
                }
            }

        }
    }
}
