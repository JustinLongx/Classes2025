namespace Classes2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new instance of the Car class
            Car car1 = new Car();
            //Set values in the properties for the object
            car1.Make = "Ford";
            car1.Model = "F150";
            car1.Year = 2018;
            //Print the values of each property to the Console
            Console.WriteLine($"A cool vehicle is a {car1.Year} {car1.Make} {car1.Model}.");
        }
    }
}
