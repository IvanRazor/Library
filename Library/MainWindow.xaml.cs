using Library.Interfaces;
using Library.Services;
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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IAutorService autorService)
        {
            InitializeComponent();
            AutorService = autorService;
        }

        public IAutorService AutorService { get; }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AutorWindow autorWindow = new AutorWindow(AutorService);
            autorWindow.Show();
        }
    }
}
