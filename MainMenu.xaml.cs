using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Lesson10
{
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ClickEnter(object sender, RoutedEventArgs e)
        {
            if (SpecialistSelector.SelectedItem is ListBoxItem selectedListBoxItem &&
                selectedListBoxItem.Content != null)
            {
                string selectedValue = selectedListBoxItem.Content.ToString();
                ClientViewPage clientViewPage = new ClientViewPage();

                if (selectedValue == "Менеджер")
                {
                    clientViewPage.ModificationType = Data.ModificationType.Менеджер;
                }
                else
                {
                    clientViewPage.ModificationType = Data.ModificationType.Консультант;
                }

                NavigationService.Navigate(new ClientViewPage());
            }
        }
    }
}
