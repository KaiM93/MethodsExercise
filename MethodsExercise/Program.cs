namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

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

        }
    }
}
