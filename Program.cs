using System.Drawing;
using System;
using System.Linq;

namespace entity_lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var user1 = new User() { UserName = "Bill",FamilyName="sadeghi",Age=3};
            var user2 = new User() { UserName = "hasanGholi" };
            var book1 = new Book() {title = "ravesh", author = "safabakhsh",};
            using (var db = new LibraryContext())
            {
                db.Database.EnsureCreated();
                // db.Users.Add(user2);
                // db.Books.Add(book1);
                // var blog = db.Users
                //     .OrderBy(b => b.ID)
                //    .First();
                db.Users.Remove(new User() { ID = 3 });
                db.SaveChanges(); 
                Console.WriteLine("worked");               
            }

            Console.WriteLine("worked2");
        }
    }
}
