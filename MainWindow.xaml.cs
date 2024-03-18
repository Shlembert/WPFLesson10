using System.Windows;

namespace Lesson10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new MainMenu();
        }
    }
}
