class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Create books
        Comic comic = new Comic("The Amazing Spider-Man", "Stan Lee", "123456789", 1963, "Steve Ditko");
        Novel novel = new Novel("To Kill a Mockingbird", "Harper Lee", "987654321", 1960, "Classic");
        TextBook textbook = new TextBook("Introduction to Algorithms", "Thomas H. Cormen", "543216789", 2009);
        ResearchPaper researchPaper = new ResearchPaper("Quantum Computing", "John Doe", "987612345", 2022);

        // Add books to the library
        library.AddBook(comic);
        library.AddBook(novel);
        library.AddBook(textbook);
        library.AddBook(researchPaper);

        // Create people
        Customer customer = new Customer("John Smith", 1);
        Librarian librarian = new Librarian("Jane Doe", 2);

        // Add people to the library
        library.AddPerson(customer);
        library.AddPerson(librarian);

        // Perform library operations
        library.BorrowBook(customer, comic);
        library.BorrowBook(customer, textbook);
        library.ReturnBook(customer, comic);
        library.PrintBookInfo(novel);
    }
}