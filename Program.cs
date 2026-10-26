using Assignment01EFCore.Models;

namespace Assignment01EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new BookStoreContext();

            context.Categories.Add(new Category
            {
                Name = "Programming",
                Description = "Software books",
                IsActive = true
            });

            context.Authors.Add(new Author
            {
                FirstName = "Ahmed",
                LastName = "Shaker",
                Email = "AhmedSar7an123@gmail.com",
                Biography = ".net Developer",
                DateOfBirth = new DateTime(1976, 4, 4)
            });

            context.Books.Add(new Book
            {
                Title = "C# Programming Language",
                ISBN = "4234234",
                Price = 90.00m,
                NumberOfPages = 300,
                PublicationYear = 2025,
                InStock = true
            });

            context.SaveChanges();

          
        }
    }
}
