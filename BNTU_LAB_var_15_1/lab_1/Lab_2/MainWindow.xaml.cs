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

namespace Lab_2
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

        private double Func(double X) {
            if ((bool)radioTypeFunc1.IsChecked)
            {
                return Math.Sinh(X);
            }
            else
            if ((bool)radioTypeFunc2.IsChecked)
            {
                return Math.Pow(X, 2);
            }
            else
            if ((bool)radioTypeFunc3.IsChecked)
            {
                return Math.Pow(Math.E, X);
            }
            else return 0;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double X, Y, Z, result;

            try
            {
                X = double.Parse(inputX.Text);
                Y = double.Parse(inputY.Text);
                Z = double.Parse(inputZ.Text);
                double firstPart, secondPart, thirdPart;
                //firstPart = ((Math.Pow(X, (Y + 1))) + (Math.Pow(Math.E, (Y - 1)))) / ((1 + X * (Math.Abs(Y - Math.Tan(Z)))));
                //secondPart = 1 + Math.Abs(Y - X);
                //thirdPart = ((Math.Pow(Math.Abs(Y - X), 2)) / 2) - ((Math.Pow(Math.Abs(Y - X), 3)) / 3);
                result = Math.Max(Math.Min(Func(X), Y), Z);
                resultBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inputX_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
