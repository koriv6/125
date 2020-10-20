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
    /// Interaction logic for _5z.xaml
    /// </summary>
    public partial class _5z : Window
    {
        internal int s;
        public _5z(MainWindow w)
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int n = s;
            int z = Convert.ToInt32(el.Text);
            if (z > n || z < 1)
            {
                string stop = "Необходимо выбрать элемент, который является частью массива";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                Close();
            }
        }
    }
}
