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
using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();

        text.Append("Book List");
        text.Append(" - Updated");

        Console.WriteLine(text);
    }
}

#endregion