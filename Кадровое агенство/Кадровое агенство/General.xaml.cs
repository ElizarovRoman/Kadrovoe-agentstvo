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
    /// Логика взаимодействия для General.xaml
    /// </summary>
    public partial class General : Window
    {
        public General()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Entry entrywin = new Entry();
            entrywin.Show();
            this.Close();
        }

        private void ToREG_Click(object sender, RoutedEventArgs e)
        {
            Registration regwin = new Registration();
            regwin.Show();
            this.Close();
        }
    }
}
