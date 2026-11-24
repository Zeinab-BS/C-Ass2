using System.Text;

namespace C_Ass2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*
                Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
                both title and upperTitle to show that title did not change. 
               */
            //string title = "clean code ";
            //string  upperTitle= title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle); 
            #endregion

            #region Question2
            /*
             Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
             to check if they point to the same object in memory. 
             */
            //string s1 = "Clean Code";
            //string s2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(s1, s2));// true 


            #endregion

            #region Question3
            /*
             Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
             object. Print the final result.
            */

            //StringBuilder sb= new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);


            #endregion

            #region Question4
            /*
            Using the StringBuilder from the question above, 
            use Replace() to change "Book List" into "Library".
            Print the result.
            */
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb);





            #endregion


            #region Question5
            /*
             Given string title = "Clean Code"; and int pages = 464;, 
             build the sentence "Book: Clean Code,
             Pages: 464" using the + operator.
            */

            //string title = "Clean Code";
            //int Pages = 464;
            //Console.WriteLine("Book: "+ title);
            //Console.WriteLine("Pages: "+ Pages);




            #endregion

            #region Question6

            //string title = "Clean Code";
            //int Pages = 464;
            //Console.WriteLine($"Book: {title}");
            //Console.WriteLine($"Pages: {Pages}");


            #endregion

            #region Question7

            /*
             Build the same sentence again, but using string.Format().
            */
            //string title = "Clean Code";
            //int Pages = 464;
            //Console.WriteLine(string.Format("Book: {0} ", title));
            //Console.WriteLine(string.Format("Pages: {0} ", Pages));

            #endregion

            #region Question8

            /*
             Given int pages = 464;, write an if / else statement that
             prints "Long Book" if pages is greater than
             300, otherwise prints "Short Book".
             
            */

            //int pages = 464;
            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");

            //}


            #endregion

            #region Question9

            /*
             Given int pages = 464; and bool isAvailable = true;,
             print "You can borrow this book" only if pages is
             greater than 300 and isAvailable is true. Use the && operator.
             
            */
            //int pages = 464;
            //bool isAvailable = true;
            //if(pages>300 && isAvailable == true)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}






            #endregion

            #region Question10
            /*
             Given string title = "Refactoring";, 
             write a switch statement that prints "Great choice!" if the title is
            "Clean Code", "Nice pick!" if it's "Refactoring",
             and "Never heard of it" for anything else.
            */

            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard");
            //        break;

            //}



            #endregion


            #region Question11

            /*
             Given int pages = 464;,
             use the ternary operator to store
            "Long Book" or "Short Book" into a
             variable sizeLabel
            (same rule as question 8: long if pages > 300).
            */
            //int pages = 464;
            //string res = pages > 300 ? "Long Book" : "Short Book";
            //Console.WriteLine(res);


            #endregion

            #region Question12

            /*
             Given string[] books = { "Clean Code", 
            "The Pragmatic Programmer", "Refactoring" };, use a for loop
             to print each book with its position number, like 1. Clean Code.   
             */

            //string[] books = {"Clean Code",
            //"The Pragmatic Programmer", "Refactoring" };
            // for (int i = 0; i < books.Length; i++)
            // {
            // Console.WriteLine($"{i+1}. {books[i]}");
            // }





            #endregion

            #region Question13
            /*
             Using the same books array, use a while loop to print every book title.
        
             */

            //string[] books = {"Clean Code",
            //"The Pragmatic Programmer", "Refactoring" };
            //int count = 0;
            //while (count<books.Length)
            //{

            //    Console.WriteLine($"{count + 1}. {books[count]}");
            //    count++;
            //}

            #endregion

            #region Question14
            //Write a do-while loop that prints "Checking book..." exactly 3 times.

            //int count = 0;
            //do
            //{

            //    Console.WriteLine("Checking book...");//1 2 3
            //    count++;//2 3

            //} while (count<3);




            #endregion

            #region Question15
            //Using the same books array, use a foreach loop to print every book title.
            //string[] books = {"Clean Code",
            //"The Pragmatic Programmer", "Refactoring" };
            //foreach( string book in books)
            //{

            //    Console.WriteLine(book);
            //}

            #endregion

            #region Question16
            /*
             Using the same books array, loop through it and print each title,
             but stop completely (break) once
             you reach "Refactoring".
            */

            //string[] books = {"Clean Code",
            //"The Pragmatic Programmer", "Refactoring" };

            //for(int i=0;i< books.Length; i++)
            //{
            //   if(books[i] == "Refactoring")
            //    {
            //        break;
            //    }

            //    else
            //    {
            //        Console.WriteLine(books[i]);
            //    }
            //}



            #endregion

            #region Question17
            /*
             Using the same books array, print every title except 
            "The Pragmatic Programmer" (skip it with
             continue, don't stop the loop)    
             */

            //string[] books = {"Clean Code",
            //"The Pragmatic Programmer", "Refactoring" };

            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i] == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }

            //    else
            //    {
            //        Console.WriteLine(books[i]);
            //    }
            //}



            #endregion


            #region Question18
            /*
             Write a method PrintFirstBook() that prints the first book in the books array.
            If the array is empty,use return to exit the method early instead of printing anything.  
             */
            PrintFirstBook();
            #endregion


        }

        static void PrintFirstBook()
        {
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            if (books.Length == 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(books[0]);
                
            }

        }   
    }
}
