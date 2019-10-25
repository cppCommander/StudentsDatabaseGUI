using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace Students
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        List<PersonModel> people = new List<PersonModel>();

        public MainWindow()
        {

            
            InitializeComponent();
        }

        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            var list = new BindingList<PersonModel>(people);
            DataGrid1.ItemsSource = list;
        }

        private void RefreshListButton_Click(object sender, RoutedEventArgs e)
        {
            LoadPeopleList();
        }

        private void AddListButton_Click(object sender, RoutedEventArgs e)
        {

            var window = new AddWindow();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.Show();
            
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    
}
