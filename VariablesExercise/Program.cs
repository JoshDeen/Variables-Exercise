namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a dog name:");
            
            string? dogName = Console.ReadLine();
            int dogAge = 4;
            char dogMiddleInitial = 'A';
            bool isDogHappy = true;
            double poundsOfFood = 22.7;
            decimal dogFoodCost = 1436.98m;

            Console.WriteLine($"My dog's name is {dogName} and his middle name starts with {dogMiddleInitial}.  He is {dogAge} years old today.\nFor his birthday we got him {poundsOfFood} pounds of food" +
                $" and it cost ${dogFoodCost}.  It is {isDogHappy} that {dogName} was happy.");
            Console.ReadLine();
        }
    }
}
