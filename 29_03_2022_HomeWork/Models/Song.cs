using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_03_2022_HomeWork.Models
{
    internal class Song
    {
        private string _name;
        private string _genre;
        private Singer _singer;
        private int[] _ratings = new int[0];
        public Song(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 100) _name = value;
            }
        }
        public string Genre
        {
            get { return _genre; }
            set
            {
                value = value[0].ToString().ToUpper() + value.Substring(1).ToLower();
                if (value == "Jazz" || value == "Rock" || value == "Pop" || value == "Techno") _genre = value;
            }
        }
        public Singer Singer
        {
            get { return _singer; }
            set
            {
                _singer = value;
            }
        }
        public void AddRating(int rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                Array.Resize(ref _ratings, _ratings.Length + 1);
                _ratings[_ratings.Length - 1] = rating;
            }

        }
        public double GetAverageRating()
        {
            return _ratings.Average();
        }
    }
}
