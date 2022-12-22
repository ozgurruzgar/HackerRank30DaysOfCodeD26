using System;

namespace HackerRank30DaysOfCodeD26
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            /* Kodunu buraya yaz. Consoldan gelen değeri oku. Sonucu ekrana bas. Sınıf isminin Solution olması tavsiye edilir.*/

            string[] returnedDateStr = Console.ReadLine().Split(' ');
            int returnedDateDay = int.Parse(returnedDateStr[0]);
            int returnedDateMonth = int.Parse(returnedDateStr[1]);
            int returnedDateYear = int.Parse(returnedDateStr[2]);

            string[] dueDateStr = Console.ReadLine().Split(' ');
            int dueDateDay = int.Parse(dueDateStr[0]);
            int dueDateMonth = int.Parse(dueDateStr[1]);
            int dueDateYear = int.Parse(dueDateStr[2]);

            DateTime returnedDate = new DateTime(returnedDateYear, returnedDateMonth, returnedDateDay);

            DateTime dueDate = new DateTime(dueDateYear, dueDateMonth, dueDateDay);

            NestedLogic(dueDate, returnedDate);
        }

        private static void NestedLogic(DateTime dueDate, DateTime returnedDate)
        {
            int fine = 0;

            if (returnedDate <= dueDate)
            {
                fine = 0;
            }
            else if (returnedDate.Month == dueDate.Month && returnedDate.Year == dueDate.Year)
            {
                fine = 15 * (returnedDate.Day - dueDate.Day);
            }
            else if (returnedDate.Year == dueDate.Year)
            {
                fine = 500 * (returnedDate.Month - dueDate.Month);
            }
            else
            {
                fine = 10000;
            }
            Console.WriteLine(fine);
        }
    }
}
