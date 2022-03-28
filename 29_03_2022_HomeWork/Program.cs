using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _29_03_2022_HomeWork.Models;

namespace _29_03_2022_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Rock'n Roll 1999", "rock");
            song1.Singer = new Singer("Abraham", "Lincoln", 87);
            Console.WriteLine($"--Musician Detailes--:\nName - {song1.Singer.Name}, Surname - {song1.Singer.Surname}, Age - {song1.Singer.Age}");
            Console.WriteLine($"--Song Detailes--:\nSong Name - {song1.Name}, Genre - {song1.Genre}");
            song1.AddRating(9);
            song1.AddRating(10);
            song1.AddRating(8);
            song1.AddRating(9);
            Console.WriteLine("Average rating: "+song1.GetAverageRating());
            Console.ReadLine();

        }
    }
}
