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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica_EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Authors_Button_Click(object sender, RoutedEventArgs e)
        {
            AuthorsPage AuthorPage1= new AuthorsPage();
            this.Content = AuthorPage1;
        }

        private void Books_Button_Click(object sender, RoutedEventArgs e)
        {
            BooksPage BooksPage1 = new BooksPage();
            this.Content = BooksPage1;
        }
    }
}
