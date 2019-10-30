using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.Collections.ObjectModel;

namespace TheJokaBaby
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)


        {
            ObservableCollection<Moviecs> movieList = new ObservableCollection<Moviecs>();

           

            Moviecs submittedMovie = new Moviecs(textBox.Text,genrebox.Text,Convert.ToDouble(reviewbox.Text));

            movieList.Add(submittedMovie);
           // submittedMovie.Title = textBox.Text;
            //submittedMovie.Genre = genrebox.Text;
             //submittedMovie.ReviewScore= Convert.ToDouble(reviewbox.Text);

            submittedMovie.DisplayInfo();

            textBox.Clear();
            genrebox.Clear();
            reviewbox.Clear();

        }
    }
}
