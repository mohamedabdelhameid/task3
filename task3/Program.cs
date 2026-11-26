
namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine($"second price : {prices[1]}");

            Console.WriteLine("----------------------------");

            // 2
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine($"copies on shelf 1, slot 0: {shelfCopies[1, 0]}");


            Console.WriteLine("----------------------------");

            // 3
            PrintWelcomeMessage();

            Console.WriteLine("----------------------------");

            // 4
            Console.WriteLine(PrintBookTitle("Clean Code"));

            Console.WriteLine("----------------------------");


            // 5
            int pages = 400;

            Console.WriteLine(AddBounesPages(pages));
            Console.WriteLine("---------After Calling----------");
            Console.WriteLine(pages);

            // no change in the value of int pages becuase it passes a copy of value (passing by value) 


            Console.WriteLine("----------------------------");

            // 6
            double[] prices2 = { 25.5, 40.0 };

            Console.WriteLine(ApplyDiscount(prices2));
            Console.WriteLine("---------After Calling----------");
            Console.WriteLine(prices2[0]);

            // the value is changed because it passes the value by reference of the array


            Console.WriteLine("----------------------------");

            // 7
            Console.WriteLine(ApplyDiscountByRef(ref prices2));
            Console.WriteLine("---------After Calling----------");
            Console.WriteLine(prices2[0]);

            // the value is changed because it passes the reference of the array (passing by reference)

            Console.WriteLine("----------------------------");

            // 8
            Console.WriteLine(prices2.Length);
            Console.WriteLine("---------After Calling----------");
            Console.WriteLine(ReplaceArray(ref prices2));

            Console.WriteLine("----------------------------");

            // 9
            string bookTitle = "Clean Code";
            bool isFound = TryGetPrice(bookTitle, out double price);

            Console.WriteLine($"the book is Found ? {isFound} and the price is {price}");

            Console.WriteLine("----------------------------");

            // 10

            PrintBookInfo("Clean Code");

            PrintBookInfo("CSharp", 250);

            Console.WriteLine("----------------------------");


            // 11
            PrintBookInfo(pages: 450, title: "ASP .Net");
            
            Console.WriteLine("----------------------------");



            // 12
            string book01 = "Clean Code";
            string book02 = "CSharp";
            string book03 = "ASP .Net";

            PrintAllTitles(book01, book02, book03);


            //Console.WriteLine("Hello, World!");
        }

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }


        static string PrintBookTitle(string title)
        {
            return $"Book title: {title}";
        }

        static int AddBounesPages(int pages)
        {
            return pages + 50;
        }

        static double ApplyDiscount(double[] prices) 
        {
            return prices[0] - 5.0;
        }

        static double ApplyDiscountByRef(ref double[] prices)
        {
            return prices[0] - 5.0;
        }

        static double ReplaceArray(ref double[] prices)
        {
            prices = new double[] { 10.0, 12.5, 15 };
            return prices.Length;
        }

        static bool TryGetPrice(string title , out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }
            else
            {
                price = 0.0;
                return false;
            }
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }

        static void PrintAllTitles(params string[] titles)
        {
            foreach(string title in titles)
            {
                Console.WriteLine($"Title: {title}");
            }
        }

    }
}
