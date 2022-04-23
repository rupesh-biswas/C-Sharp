namespace C_Sharp___FreeCodeAcademy
{
    class Program1
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            // G, PG, PG-13, R, NR
            shrek.Rating = "PG-13";
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}