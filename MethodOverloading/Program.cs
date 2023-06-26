namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //call methods inside the main method
            Console.WriteLine(Add(5, 2));
            Console.WriteLine(Add(5.2m, 4.6m));
            Console.WriteLine(Add(6, 8, true));

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isMoney)
        {
            var sum = num1 + num2;
            if (isMoney == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isMoney == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isMoney == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else {
                return ($"{sum}");
            }
        }

    }
}
