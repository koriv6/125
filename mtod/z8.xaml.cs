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

namespace mtod
{
    /// <summary>
    /// Interaction logic for z8.xaml
    /// </summary>
    public partial class z8 : Window
    {
      internal int s;
        public z8(MainWindow w)
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int n = s;
            int z = Convert.ToInt32(el.Text);
            if (z > 100 || z < 1)
            {
                string stop = "Введите числовое значение для процента (1-100)";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Close();
            }
        }
    }
}
