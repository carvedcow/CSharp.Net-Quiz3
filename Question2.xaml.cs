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
using System.Windows.Shapes;

namespace CSharp.Net_Quiz3
{
    /// <summary>
    /// Interaction logic for Question2.xaml
    /// </summary>
    public partial class Question2 : Window
    {
        IList<Student> studentList = new List<Student>()
        {
            new Student(1, "John", "Doe", true),
            new Student(2, "Jim", "Doe", false),
            new Student(3, "Joe", "Doe", false),
            new Student(4, "Jan", "Doe", true)
        };
        public Question2()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            sList.ItemsSource = studentList;
        }
    }
}
