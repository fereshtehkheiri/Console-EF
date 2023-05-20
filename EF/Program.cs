// See https://aka.ms/new-console-template for more information
using EF;
using EF.DB;

Console.WriteLine("Hello, World!");

var DB = new EFDbContext();


DB.Books.Add(new Book{AuthorName="HF", Name = "Test1", Id= 1});
DB.Books.Add(new Book{AuthorName="FHF", Name = "Test2", Id= 2});
DB.Books.Add(new Book{AuthorName="FHFH", Name = "Test3", Id= 3});
DB.Books.Add(new Book{AuthorName="FHFH", Name = "Test4", Id= 4});

DB.SaveChanges();

var books = DB.Books.ToList();
Console.WriteLine($"books count = {books.Count}" );                   
var book = DB.Books.Where(p => p.Id == 2).FirstOrDefault();
if (book != null)
    {

        Console.WriteLine("Book with Id 2: " + book.Name);
    }
    else
    {
        Console.WriteLine("No Book with Id 2 found.");
    }
    
DB.SaveChanges();


