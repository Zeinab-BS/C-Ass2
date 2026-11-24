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


        }
    }
}
