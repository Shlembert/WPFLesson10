using Lesson10.Data;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Lesson10
{
    public partial class ClientMakerPage : Page
    {
        private ClientMaker clientMaker;

        public ClientMakerPage()
        {
            InitializeComponent();
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            clientMaker = new ClientMaker(filePath);
        }

        private void CreateClient(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client(
                FullNameTextBox.Text,
                PhoneNumberTextBox.Text,
                PassportSeriesTextBox.Text,
                PassportNumberTextBox.Text
            );

            // Сохраняем клиента
            clientMaker.SaveClient(newClient);

            MessageBox.Show("Client created successfully!");
        }
    }
}
