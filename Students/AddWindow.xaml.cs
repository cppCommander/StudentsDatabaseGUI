using System;
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
using System.Windows.Shapes;

namespace Students
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BirthdayNameText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            PersonModel p = new PersonModel();

            p.FirstName = firstNameText.Text;
            p.LastName = lastNameText.Text;
            p.Birthday = birthdayText.Text;
            p.Address = addressText.Text;

            SqliteDataAccess.SavePerson(p);

            this.Close();
        }
    }
}
