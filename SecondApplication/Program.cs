#region Question 1
//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title = "clean code";
//        string upperTitle = title.ToUpper();

//        Console.WriteLine(title);
//        Console.WriteLine(upperTitle);
//    }
//}

#endregion
#region Question 2
//Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title1 = "Clean Code";
//        string title2 = "Clean Code";

//        Console.WriteLine(ReferenceEquals(title1, title2));
//    }
//}

#endregion
#region Question 3
//Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
//using System;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        StringBuilder text = new StringBuilder();

//        text.Append("Book List");
//        text.Append(" - Updated");

//        Console.WriteLine(text);
//    }
//}

#endregion
#region Question 4
//Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result
//using System;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        StringBuilder text = new StringBuilder();

//        text.Append("Book List");
//        text.Append(" - Updated");

//        text.Replace("Book List", "Library");

//        Console.WriteLine(text);
//    }
//}
#endregion
#region Question 5
//Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, ages: 464" using the + operator.
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title = "Clean Code";
//        int pages = 464;

//        string sentence = "Book: " + title + ", Pages: " + pages;

//        Console.WriteLine(sentence);
//    }
//}
#endregion
#region Question 6
//Build the same sentence as above, but using string interpolation ($"...").
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title = "Clean Code";
//        int pages = 464;

//        string sentence = $"Book: {title}, Pages: {pages}";

//        Console.WriteLine(sentence);
//    }
//}
#endregion
#region Question 7
//Build the same sentence again, but using string.Format().
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title = "Clean Code";
//        int pages = 464;

//        string sentence = string.Format("Book: {0}, Pages: {1}", title, pages);

//        Console.WriteLine(sentence);
//    }
//}
#endregion
#region Question 8
//Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book"
//using System;

//class Program
//{
//    static void Main()
//    {
//        int pages = 464;

//        if (pages > 300)
//        {
//            Console.WriteLine("Long Book");
//        }
//        else
//        {
//            Console.WriteLine("Short Book");
//        }
//    }
//}
#endregion
#region Question 9
//Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator.
//using System;

//class Program
//{
//    static void Main()
//    {
//        int pages = 464;
//        bool isAvailable = true;

//        if (pages > 300 && isAvailable == true)
//        {
//            Console.WriteLine("You can borrow this book");
//        }
//    }
//}
#endregion
#region Question 10
//Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else
//using System;

//class Program
//{
//    static void Main()
//    {
//        string title = "Refactoring";

//        switch (title)
//        {
//            case "Clean Code":
//                Console.WriteLine("Great choice!");
//                break;

//            case "Refactoring":
//                Console.WriteLine("Nice pick!");
//                break;

//            default:
//                Console.WriteLine("Never heard of it");
//                break;
//        }
//    }
//}

#endregion
#region Question 11
//Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel(same rule as question 8: long if pages > 300).
//using System;

//class Program
//{
//    static void Main()
//    {
//        int pages = 464;

//        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

//        Console.WriteLine(sizeLabel);
//    }
//}
#endregion
#region Question 12
//Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

//        for (int i = 0; i < books.Length; i++)
//        {
//            Console.WriteLine((i + 1) + ". " + books[i]);
//        }
//    }
//}
#endregion
#region Question 13
//Using the same books array, use a while loop to print every book title.
using System;

class Program
{
    static void Main()
    {
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

        int i = 0;

        while (i < books.Length)
        {
            Console.WriteLine(books[i]);
            i++;
        }
    }
}
#endregion