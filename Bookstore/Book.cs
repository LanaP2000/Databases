/// <summary>
/// Lana
/// Book class with all the essential information about books (properties and constructors)
/// </summary>

namespace Assignment2
{
    public class Book
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        
        public Book (string author, string isbn, string price, string title) // Explicit-value constructor
        {
            Author = author;
            ISBN = isbn;
            Price = price;
            Title = title;
        }
        public Book() { } // Default constructor
    }
}
