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

namespace Кадровое_агенство
{
    /// <summary>
    /// Логика взаимодействия для Entry.xaml
    /// </summary>
    public partial class Entry : Window
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (log_vhod.Text.Length > 0)
            {
                if (pass_vhod.Password.Length > 0)
                {
                    MainWindow mainw = new MainWindow();
                    mainw.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Введите пароль", "Ошибка входа",MessageBoxButton.OK,MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Введите логин", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
