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

namespace sessia3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            frameOut.Navigate(new outFlighs());
            oneBox.ItemsSource = Session3_XXEntities.GetContext().Countries.ToList();
            twoBox.ItemsSource = Session3_XXEntities.GetContext().Countries.ToList();
            threeBox.ItemsSource = Session3_XXEntities.GetContext().CabinTypes.ToList();
            frameToo.Navigate(new tooPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("К сожалению рейсов по вашему запросу нет");
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            twoo tr = new twoo();
            tr.Show();
            Close();
        }
    }
}
