namespace tasl1
{
    internal class Program
    {
        static void Main()
        {

            #region Q1

            // Get user input for a number
            Console.Write("Enter a number: ");
                string number = Console.ReadLine();
                Console.WriteLine("You entered: " + number);
            #endregion


            #region Q2
            Console.WriteLine("Enter Number: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 12 == 0 && num % 9 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
            #endregion


            #region Q3
            Console.WriteLine("Enter the First Number:  ");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the seconed Number: ");
            int num2 = int.Parse(Console.ReadLine()); 
            int maxNum;

            if (num1 > num2)
            {
                maxNum = num1;
            }
            else
            {
                maxNum = num2;
            }
            Console.WriteLine("The Maximum number is: " +maxNum);
            #endregion


            #region Q4
            Console.WriteLine("Enter the Number: ");
            string input = Console.ReadLine(); 

            if (int.TryParse(input, out int number)) 
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative");
                }
                else
                {
                    Console.WriteLine("positive");
                }
            }
            #endregion


            #region Q5
            Console.WriteLine("Enter the First Number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second Number: ");
            int num2 = int.Parse(Console.ReadLine());  

            Console.WriteLine("Enter the third Number: ");
            int num3 = int.Parse(Console.ReadLine());
            
            int max = Math.Max(Math.Max(num1, num2), num3);
            int min = Math.Min(Math.Max(num1, num2), num3);

            Console.WriteLine($"Maximum element: {max}");
            Console.WriteLine($"Minimum element: {min}");

            #endregion

            #region Q6
            Console.Write("Enter an integer number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine((y % 2 == 0) ? "Even" : "Odd");
            #endregion

            #region Q7
            List<char> chars = new List<char> { 'a', 'o', 'i', 'y', 'u' };
            Console.WriteLine("Enter a character to check if its vowel or consonent: ");
            Console.WriteLine((chars.Contains(char.Parse(Console.ReadLine()))) ? "vowel" : "Consonent");
            #endregion

            #region Q8
            Console.Write("Enter number: ");
            int flag = int.Parse(Console.ReadLine());
            for (int i = 0; i < flag + 1; i++)
            {
                Console.Write(i);
                Console.Write(',');
            }
            #endregion

            #region Q9
            Console.Write("Enter number: ");
            int numberQ9 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 13; i++)
            {
                Console.Write(numberQ9 * i);
                Console.Write(' ');
            }
            #endregion


            #region Q10
            Console.Write("Enter number: ");
            int numberQ10 = int.Parse(Console.ReadLine());
            for (int i = 1; i < numberQ10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
        }
    }
}