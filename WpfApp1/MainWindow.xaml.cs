﻿using System.Windows;

namespace WpfApp1
{
    using System.Diagnostics;
    using System.Windows.Documents;
    using System.Windows.Input;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        public Fruit[] ListContents { get; } =
            { new Fruit("Apples", 12), new Fruit("Oranges", 13), new Fruit("Pears", 14), };

        public ICommand DeleteCommand { get; } = new DelegateCommand(e => Trace.WriteLine("Command triggered"));
    }

    public class Fruit
    {
        public Fruit(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; }

        public int Id { get; }
    }
}
