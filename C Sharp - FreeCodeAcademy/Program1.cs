﻿namespace C_Sharp___FreeCodeAcademy
{
    class Program1
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
             Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);




            Console.ReadLine();

        }
    }
}