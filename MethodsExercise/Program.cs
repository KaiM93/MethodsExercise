namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

    }

    public static int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }

    static void Main(string[] args)
    {

        var amountOfCars = Sum(2, 6);
        var wassup = Multiply(60, 2, 4);

            //Name: Kai
            //Favorite Color: Blue
            //Favorite Animal: Lion
            //Favorite Music Artist: Jay-Z

            Console.WriteLine("Hello - What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hey {userName}, What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"That's cool {userName}, mines is too. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Noicee! And who's your favorite artist?");
            var artist = Console.ReadLine();



            Console.WriteLine($"Cool {userName}, Here is your profile");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Animal: {animal}");
            Console.WriteLine($"Artist: {artist}");


            //---------Exercise 2------------------


           

        }
    }
}