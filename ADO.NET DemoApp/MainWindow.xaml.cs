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

namespace ADO.NET_DemoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TestTbContextContainer context = new TestTbContextContainer();

            //Person magnus = new Person {id = 1, Name = "Magnus" };
            //Pet dog = new Pet { Id = 1, Name = "The dog", Owner = "magnus" };

            //context.PersonSet.Add(magnus);
            //context.PetSet.Add(dog);
            //context.SaveChanges();

            foreach (var item in context.PersonSet)
            {
                MessageBox.Show($"{ item.Name}", "info", MessageBoxButton.OK);
            }
        }
    }
}
