using Lesson10.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using System.Data;
using System.Windows.Data;

namespace Lesson10
{
    public partial class ClientViewPage : Page
    {
        private ModificationType modificationType;

        public ClientViewPage()
        {
            InitializeComponent();
        }

        public ModificationType ModificationType { get => modificationType; set => modificationType = value; }

        private void MakeClient(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ClientMakerPage());
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void LoadClientsToTable(object sender, RoutedEventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "data.json");
            ClientMaker clientMaker = new(filePath);
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Имя", Binding = new Binding("FullName") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Телефон", Binding = new Binding("PhoneNumber") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Серия Паспорта", Binding = new Binding("PassportSerie") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Номер Паспорта", Binding = new Binding("PassportNumber") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Дата создания записи", Binding = new Binding("CreatedDateTime") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Дата изменения записи", Binding = new Binding("LastModificationDateTime") });
            //TableClients.Columns.Add(new DataGridTextColumn() { Header = "Автор редактирования", Binding = new Binding("ModificationType") });
            TableClients.ItemsSource = clientMaker.LoadClients();
        }
    }
}
