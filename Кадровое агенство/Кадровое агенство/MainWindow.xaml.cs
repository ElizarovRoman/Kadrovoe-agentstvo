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

namespace Кадровое_агенство
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

        private void ToReg_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Toreg_Click_1(object sender, RoutedEventArgs e)
        {
            Registration registr = new Registration();
            registr.Show();
            this.Close();
        }

        private void Togen_Click(object sender, RoutedEventArgs e)
        {
            General genwin = new General();
            genwin.Show();
            this.Close();
        }
    }
}
