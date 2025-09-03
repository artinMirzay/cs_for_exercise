namespace cs_for_exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Numbers 1-10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/


            /*//Even Numbers
            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }*/


            /*//Multiplication Table
            Console.Write("Write a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} * {i} = {userNumber * i}");
            }*/


            /*//Reverse Countdown
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lift off!");*/


            /*//Sum of Numbers
            int numbers = 0;
            for (int i = 1; i <= 100; i++)
            {
                numbers += i;

                Console.WriteLine($"{i + numbers - 1} {numbers}");
            }*/


            //Stars Pattern
            /*for (String star = "*"; star.Length <= 5; star += "*")
            {
                Console.WriteLine(star);
            }*/


            /*//Factorial (n != n)
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 1;


            for (int i = number; i > 0; i--)
            {
                int factorial = i;
                sum = sum * i;
            }

            Console.WriteLine($"{sum}");*/

        }
    }
}
