using System;
using System.Collections.Generic;

// Abstract class representing a person
public abstract class Person
{
    public string? Name { get; set; }
    public int ID { get; set; }
}

// Enum representing the book type
public enum BookType
{
    Comic,
    Novel,
    TextBook,
    ResearchPaper
}

// Interface defining the borrowable behavior
public interface IBorrowable
{
    void Borrow();
    void Return();
}

// Interface defining the printable behavior
public interface IPrintable
{
    void PrintPages(int startPage, int endPage);
}

// Base class representing a book
public abstract class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public int PublicationYear { get; set; }
    public bool CanBorrow { get; set; }
    public bool CanPrint { get; set; }

    public abstract void PrintInfo();

    // Constructor
    protected Book(string title, string author, string isbn, int publicationYear)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        PublicationYear = publicationYear;
    }
}

// Derived class representing a comic book
public class Comic : Book, IBorrowable
{
    public string Artist { get; set; }

    public Comic(string title, string author, string isbn, int publicationYear, string artist)
        : base(title, author, isbn, publicationYear)
    {
        Artist = artist;
        CanBorrow = true;
        CanPrint = false;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
        Console.WriteLine($"Artist: {Artist}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Comic '{Title}' borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Comic '{Title}' returned.");
    }
}

// Derived class representing a novel book
public class Novel : Book, IBorrowable
{
    public string Genre { get; set; }

    public Novel(string title, string author, string isbn, int publicationYear, string genre)
        : base(title, author, isbn, publicationYear)
    {
        Genre = genre;
        CanBorrow = true;
        CanPrint = false;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
        Console.WriteLine($"Genre: {Genre}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Novel '{Title}' borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Novel '{Title}' returned.");
    }
}

// Derived class representing a textbook
public class TextBook : Book, IBorrowable, IPrintable
{
    public TextBook(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear)
    {
        CanBorrow = true;
        CanPrint = true;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }

    public void Borrow()
    {
        Console.WriteLine($"Textbook '{Title}' borrowed.");
    }

    public void Return()
    {
        Console.WriteLine($"Textbook '{Title}' returned.");
    }

    public void PrintPages(int startPage, int endPage)
    {
        Console.WriteLine($"Printing pages {startPage} to {endPage} of textbook '{Title}'.");
    }
}

// Derived class representing a research paper
public class ResearchPaper : Book, IPrintable
{
    public ResearchPaper(string title, string author, string isbn, int publicationYear)
        : base(title, author, isbn, publicationYear)
    {
        CanBorrow = false;
        CanPrint = true;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }

    public void PrintPages(int startPage, int endPage)
    {
        Console.WriteLine($"Printing pages {startPage} to {endPage} of research paper '{Title}'.");
    }
}

// Class representing the library
public class Library
{
    private List<Book> books;
    private List<Person> people;

    public Library()
    {
        books = new List<Book>();
        people = new List<Person>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Book '{book.Title}' added to the library.");
    }

    public void RemoveBook(Book book)
    {
        books.Remove(book);
        Console.WriteLine($"Book '{book.Title}' removed from the library.");
    }

    public void AddPerson(Person person)
    {
        people.Add(person);
        Console.WriteLine($"Person '{person.Name}' added to the library.");
    }

    public void RemovePerson(Person person)
    {
        people.Remove(person);
        Console.WriteLine($"Person '{person.Name}' removed from the library.");
    }

    public void BorrowBook(Person person, Book book)
    {
        if (book.CanBorrow && person is Customer)
        {
            ((Customer)person).Borrow(book);
        }
        else
        {
            Console.WriteLine("This book cannot be borrowed.");
        }
    }

    public void ReturnBook(Person person, Book book)
    {
        if (book.CanBorrow && person is Customer)
        {
            ((Customer)person).Return(book);
        }
        else
        {
            Console.WriteLine("This book cannot be returned.");
        }
    }

    public void PrintBookInfo(Book book)
    {
        book.PrintInfo();
    }
}

// Derived class representing a customer
public class Customer : Person
{
    public Customer(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public void Borrow(Book book)
    {
        Console.WriteLine($"Customer '{Name}' borrowed book '{book.Title}'.");
    }

    public void Return(Book book)
    {
        Console.WriteLine($"Customer '{Name}' returned book '{book.Title}'.");
    }
}

// Derived class representing a librarian
public class Librarian : Person
{
    public Librarian(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public void AddBook(Library library, Book book)
    {
        library.AddBook(book);
    }

    public void RemoveBook(Library library, Book book)
    {
        library.RemoveBook(book);
    }

    public void EditBook(Book book)
    {
        Console.WriteLine($"Editing book '{book.Title}'.");
    }
}


