# LinqJoinPratik Application
## Overview
The LinqJoinPratik application is a simple C# console program that demonstrates how to perform an inner join operation using LINQ. This application is part of an exercise to practice joining collections in C#, specifically using LINQ.

## Features
The application performs the following key operations:

Joining Books with Authors: The application joins two lists—books and authors—based on a common AuthorId property. It retrieves the title of each book along with the corresponding author's name.
Displaying Results: The result of the join operation is printed to the console, displaying each author’s name alongside the title of their respective book.
## Class Descriptions

Book Class
The Book class represents a book with the following properties:

BookId: The unique identifier for the book.
Title: The title of the book.
AuthorId: The identifier that links the book to its author.

Author Class
The Author class represents an author with the following properties:

AuthorId: The unique identifier for the author.
Name: The name of the author.


Program Class
The Program class contains the Main method, which is the entry point of the application. It performs the following operations:

Creating Book and Author Lists: It creates lists of Book and Author objects, each with predefined entries.
Joining the Lists: It performs an inner join on the books and authors lists using LINQ, matching each book with its corresponding author based on the AuthorId.
Printing the Results: The results of the join operation, including the book title and author name, are printed to the console.
## Example Usage
```csharp

var bookAuthor = from book in books
                 join author in authors
                 on book.AuthorId equals author.AuthorId
                 select new
                 {
                    Title = book.Title,
                    AuthorName = author.Name
                 };

foreach (var group in bookAuthor) {
    Console.WriteLine(group.AuthorName + "-" + group.Title);
}
```
This example demonstrates how the application uses LINQ to join two collections and create a new result set containing the book titles and their respective authors.

## Technologies Used
Language: C#
Framework: .NET
LINQ: For performing join operations and querying collections
This project is a part of a LINQ practice exercise aimed at teaching how to join collections in C# using LINQ.







