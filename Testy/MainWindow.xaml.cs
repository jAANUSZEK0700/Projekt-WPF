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

namespace Testy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int topScore = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Test_Click(object sender, RoutedEventArgs e)
        {
            Test window = new Test(topScore);
            Close();
            window.ShowDialog();
        }

        private void Button_New_Question_Click(object sender, RoutedEventArgs e)
        {
            NewQuestion window = new NewQuestion();
            Close();
            window.ShowDialog();
        }

        private void Button_Zakoncz_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
