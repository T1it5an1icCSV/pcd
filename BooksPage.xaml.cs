using Practica_EF;
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
    /// Логика взаимодействия для Books.xaml
    /// </summary>
    public partial class BooksPage : Page
    {
        private Practica1Entities3 Context = new Practica1Entities3();

        public BooksPage()
        {
            InitializeComponent();
            Practica1DataGrid.ItemsSource = Context.Books.ToList();
        }
        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}