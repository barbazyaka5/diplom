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

namespace sessia3
{
    /// <summary>
    /// Логика взаимодействия для twoo.xaml
    /// </summary>
    public partial class twoo : Window
    {
        public twoo()
        {
            InitializeComponent();
            frameOut.Navigate(new addPass());
            frameToo.Navigate(new passen());
        }

        private void bck_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Новый пассажир добавлен!");
        }
    }
}
