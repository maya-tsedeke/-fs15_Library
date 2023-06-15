# Library Management System

This is a basic Library Management System implemented as a `C#` console application. The system allows managing `books` and `users` in a library, with support for `adding`, `removing`, `borrowing`, and `returning` books. It also includes different types of books such as comics, novels, textbooks, and research papers. 
## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Classes, Interfaces, and Abstract Classes](#classes-interfaces-and-abstract-classes)
- [Getting Started](#getting-started)
- [Contributing](#contributing)


## Introduction

The Library Management System is designed to showcase key principles of Object-Oriented Programming (OOP) such as encapsulation, abstraction, inheritance, and polymorphism. It demonstrates the use of classes, interfaces, and abstract classes to model the entities and behaviors of a library. It demonstrates `encapsulation` by properly encapsulating the fields in the classes and using access modifiers to limit access to class members. `Abstraction` is achieved through the use of abstract classes and interfaces to define common methods and behaviors. Inheritance is utilized with the base class Book and derived classes like Comic, Novel, TextBook, and ResearchPaper. Polymorphism is demonstrated by the PrintInfo() method, which is overridden in the derived classes to provide different implementations.


## Features

- Add, remove, borrow, and return books.
- Add, remove, edit person objects (customers and librarians).
- Differentiate between book types: comics, novels, textbooks, and research papers.
- Implement borrowable and printable behaviors for books.
- Utilize polymorphism to allow objects to decide which methods should be invoked.

## Classes, Interfaces, and Abstract Classes

### Classes

- `Library`: Represents the library and manages the collection of books and people. It provides methods to add, remove, borrow, and return books, as well as add and remove people.
- `Person`: An abstract class representing a person. It has common properties like Name and ID, and serves as the base class for `Customer` and `Librarian`.
- `Customer`: A derived class of `Person` representing a library customer. It inherits the properties of `Person` and has additional methods to borrow and return books.
- `Librarian`: A derived class of `Person` representing a librarian. It inherits the properties of `Person` and has additional methods to add, remove, and edit books.

### Interfaces

- `IBorrowable`: An interface defining the borrowable behavior. It includes methods for borrowing and returning books.
- `IPrintable`: An interface defining the printable behavior. It includes a method for printing pages of a book.

### Abstract Classes

- `Book`: An abstract class representing a book. It provides common properties like Title, Author, ISBN, PublicationYear, CanBorrow, and CanPrint. It also includes an abstract method `PrintInfo()` to print information about each book. It serves as the base class for `Comic`, `Novel`, `TextBook`, and `ResearchPaper`.

## Getting Started

To run the Library Management System, follow these steps:

1. Clone the repository.
2. Open the project in an IDE or text editor that supports C#.
3. Build and run the project.

You can explore the code to understand the class hierarchy, interfaces, and abstract classes used in the implementation. Feel free to modify and enhance the code as per your requirements.
## Output

      PS C:\Users\tshabe\Documents\GitHub\fs15_13-Library> dotnet run
      Book 'The Amazing Spider-Man' added to the library.
      Book 'To Kill a Mockingbird' added to the library.
      Book 'Introduction to Algorithms' added to the library.
      Book 'Quantum Computing' added to the library.
      Person 'John Smith' added to the library.
      Person 'Jane Doe' added to the library.
      Customer 'John Smith' borrowed book 'The Amazing Spider-Man'.
      Customer 'John Smith' borrowed book 'Introduction to Algorithms'.
      Customer 'John Smith' returned book 'The Amazing Spider-Man'.
      Title: To Kill a Mockingbird
      Author: Harper Lee
      ISBN: 987654321
      Publication Year: 1960
      Genre: Classic
## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.
