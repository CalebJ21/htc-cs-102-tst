using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheJokaBaby
{
    public class Moviecs
    {
        public string Title { get; set; }
        //public string Title;
        //public List<string> Actors;

        //public string Genre;
        public string Genre { get; set; }
        // public  double ReviewScore;
        public double ReviewScore { get; set; }



    public Moviecs(string title, string genre, double reviewScore)
        {
            Title = title;
            Genre = genre;
            ReviewScore = reviewScore;
        }

        public void DisplayInfo()
        {
            MessageBox.Show($"Title:{Title} \n Genre'{Genre} \n ReviewScore:{ReviewScore}");

        }
        
    }
}
