using System.Windows;

namespace WpfApp1
{
    using System.Windows.Documents;

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

        public Data[] ListContents { get; } =
            { new Data("Apples", 12), new Data("Oranges", 13), new Data("Pears", 14), };
    }

    public class Data
    {
        public Data(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; }

        public int Id { get; }
    }
}
