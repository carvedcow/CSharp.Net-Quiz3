﻿using System;
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

namespace CSharp.Net_Quiz3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IList<Student> studentList = new List<Student>();
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            studentList.Add(new Student(Int32.Parse(sID.Text), fName.Text, lName.Text, iReg.IsChecked ?? false));

            MessageBox.Show("Total Students Added: " + studentList.Count().ToString(), "Added Students");
        }
    }
}
