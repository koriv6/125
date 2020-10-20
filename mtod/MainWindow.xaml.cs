﻿using System;
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
using System.Collections;
using Microsoft.Win32;
using System.Windows.Forms.DataVisualization.Charting;

namespace mtod
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }




        private void Menuitem_Click_r1(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_r2(object sender, RoutedEventArgs e)
        {
            int i;
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    Coll.Sort();
                    lbMain.Items.Add("Отсортированный массив");
                    foreach (int elem in Coll)
                    {
                        lbMain.Items.Add(elem);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }

        private void Menuitem_Click_z1(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    int j = 0;
                    lbMain.Items.Add("Кол-во чисел меньших своих соседей");
                    for (int i = 1; i < n - 1; i++)
                    {
                        if ((int)Coll[i] < (int)Coll[i - 1] && (int)Coll[i] < (int)Coll[i + 1])
                        {
                            j++;
                        }
                    }
                    lbMain.Items.Add(j);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }


        }

        private void Menuitem_Click_z2(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Номер первого числа, которое больше числа 25");
                    for (int i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > 25)
                        {
                            lbMain.Items.Add(i + 1);
                            break;
                        }
                        else if (i == n - 1)
                        {
                            lbMain.Items.Add("Такого числа нет");
                        }
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_z3(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 2)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее 2";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int sum = 0;
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Сумма чисел, больших 2 элемента массива");
                    for (int i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > (int)Coll[1])
                        {
                            sum += (int)Coll[i];
                        }
                    }
                    if (sum == 0)
                    {
                        lbMain.Items.Add("Таких чисел нет");
                    }
                    else
                    {
                        lbMain.Items.Add(sum);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести неотрицательное числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Menuitem_Click_z4(object sender, RoutedEventArgs e)
        {

            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    mtod._4z w = new mtod._4z();
                    w.ShowDialog();
                    int p = Convert.ToInt32(w.el.Text);
                    lbMain.Items.Add("Номер первого числа, большего чем " + p);
                    for (int i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > p)
                        {
                            lbMain.Items.Add(i + 1);
                            break;
                        }
                        else if (i == n - 1)
                        {
                            lbMain.Items.Add("Такого числа нет");
                        }
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_z5(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    mtod._5z w = new mtod._5z(this);
                    w.s = n;
                    w.ShowDialog();
                    int p = Convert.ToInt32(w.el.Text);
                    int sum = 0;
                    lbMain.Items.Add("Сумма чисел, больших элемента массива под номером " + p);
                    for (int i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > (int)Coll[p - 1])
                        {
                            sum += (int)Coll[i];
                        }
                    }
                    if (sum == 0)
                    {
                        lbMain.Items.Add("Таких чисел нет");
                    }
                    else
                    {
                        lbMain.Items.Add(sum);
                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tbN.Clear();
            lbMain.Items.Clear();
        }


        private void Menuitem_Click_zz2(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    int j = 0;
                    lbMain.Items.Add("Кол-во чисел меньших своих соседей");
                    for (int i = 1; i < n - 1; i++)
                    {
                        if ((int)Coll[i] < (int)Coll[i - 1] && (int)Coll[i] < (int)Coll[i + 1])
                        {
                            j++;
                        }
                    }
                    if ((int)Coll[0] < (int)Coll[1] && (int)Coll[0] < (int)Coll[n - 1])
                    {
                        j++;
                    }
                    if ((int)Coll[n - 1] < (int)Coll[n - 2] && (int)Coll[n - 1] < (int)Coll[0])
                    {
                        j++;
                    }
                    lbMain.Items.Add(j);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void Menuitem_Click_zz3(object sender, RoutedEventArgs e)
        {
            try
            {
                lbMain.Items.Clear();
                int n = Convert.ToInt32(tbN.Text);
                int i;
                int sum = 0;
                int r = 201;
                int l = 0;
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Номер наименьшего значения, большего среднего значения массива");
                    for (i = 0; i < n; i++)
                    {
                        sum = sum + (int)Coll[i];
                    }
                    sum = sum / n;
                    for (i = 0; i < n; i++)
                    {
                        if ((int)Coll[i] > sum)
                        {
                            if ((int)Coll[i] < r)
                            {
                                r = (int)Coll[i];
                                l = i;
                            }
                        }
                    }
                    lbMain.Items.Add(l + 1);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_zz1(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    hist Hist = new hist();
                    Hist.CreatingHistogram(Coll);
                    Hist.Show();
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        public void Menuitem_Click_zz5(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Элементы массива составляют со своими\nсоседями упорядоченную последовательность:");
                    AllFunc.bro(Coll);
                    AllFunc.Tes(Coll, lbMain);

                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void Menuitem_Click_zz4(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньшее единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Кол-во элементов массива составляющих со своими\nсоседями упорядоченную последовательность:");
                    lbMain.Items.Add(AllFunc.broi(Coll));

                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_zz6 (object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    lbMain.Items.Add("Отклонения от среднего значения элементов массива:");
                    double sum = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (int)Coll[i];
                    }
                    sum =  Math.Round(sum, 1) / n;
                    for (int i = 0; i < n; i++)
                    {
                        lbMain.Items.Add(Coll[i] + " - " + sum + " = " + (Coll[i] = (int)Coll[i] - sum));
                    }
                    //  Tes(Coll, lbMain);
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_zz7(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum +=(double)((int)Coll[i]);
                    }
                    sum = sum / (double)n;
                    lbMain.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p = p + m[i]; 
                    }
                       lbMain.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p/2)
                        {
                            Coll[i] = sum;
                        }
                    }
                    lbMain.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbMain.Items.Add(Coll[i]);

                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_zz8(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    mtod.z8 w = new mtod.z8(this);
                    w.s = n;
                    w.ShowDialog();
                    int q = Convert.ToInt32(w.el.Text);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (double)((int)Coll[i]);
                    }
                    sum = sum / (double)n;
                    lbMain.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p = p + m[i];
                    }
                    p = p / n;
                    lbMain.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    p = (p / 100) * q;
                    lbMain.Items.Add("L процентов от среднего отклонения всех элементов: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p)
                        {
                            Coll[i] = sum;
                        }
                    }
                    lbMain.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbMain.Items.Add(Coll[i]);

                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Menuitem_Click_zz9(object sender, RoutedEventArgs e)
        {
            lbMain.Items.Clear();
            try
            {
                int n = Convert.ToInt32(tbN.Text);
                if (n < 1)
                {
                    string stop1 = "Необходимо ввести числовое значение не меньше единицы.";
                    MessageBox.Show(stop1, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    ArrayList Coll = AllFunc.NewCol(n);
                    lbMain.Items.Add("Исходный массив");
                    AllFunc.Tes(Coll, lbMain);
                    mtod.z8 w = new mtod.z8(this);
                    w.s = n;
                    w.ShowDialog();
                    mtod.z9 r = new mtod.z9();
                    r.ShowDialog();
                    int z = Convert.ToInt32(r.el.Text);
                    int q = Convert.ToInt32(w.el.Text);
                    double sum = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += (double)((int)Coll[i]);
                    }
                    sum = sum / (double)n;
                    lbMain.Items.Add("Среднее значение в массиве: " + Math.Round(sum, 1));
                    double[] m = new double[n];
                    for (int i = 0; i < n; i++)
                    {
                        m[i] = (double)((int)Coll[i]) - sum;
                    }
                    double p = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        p = p + m[i];
                    }
                    p = p / n;
                    lbMain.Items.Add("Среднее отклонение в массиве: " + Math.Round(p, 1));
                    p = (p / 100) * q;
                    lbMain.Items.Add("L процентов от среднего отклонения всех элементов: " + Math.Round(p, 1));
                    for (int i = 0; i < n; i++)
                    {
                        if (m[i] > p)
                        {
                            Coll[i] = z;
                        }
                    }
                    lbMain.Items.Add("Преобразованный массив: ");
                    for (int i = 0; i < n; i++)
                    {
                        lbMain.Items.Add(Coll[i]);

                    }
                }
            }
            catch
            {
                string stop = "Необходимо ввести числовое значение";
                MessageBox.Show(stop, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void lbMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
