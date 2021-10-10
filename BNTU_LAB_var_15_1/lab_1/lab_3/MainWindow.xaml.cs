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

namespace lab_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int N= 18;
        private const double Xstart = 0.1;
        private const double Xend= 0.8;
        private double H = (Xend -Xstart)/N;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FuncX()
        {
            //double[] arr = new double[18] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            //double result = 0;
            //for (int n = 1;n<=N;n++) {
            //    for (double x = Xstart; x < Xend; x += H)
            //    {
            //        arr[n-1] += (Math.Pow((-1), n) * (Math.Pow(x, 2 * n) / (2 * n * (2 * n - 1))));
            //        resultBox.Text += $"X = {x}, N = {n} F({x}) = ${arr[(n-1)]} Y(x): {FuncY(x)}\n";
            //    }
            //    resultBox.Text += "\n";
            //}

            //for (int n =0;n<N;n++) { 
            //    resultBox.Text += $"N = {n} F(x) = ${arr[n]} Y(x): {FuncY(0.8)}\n";
            //}





            //List<double> list = new List<double>();
            double[] arr = new double[(int)((Xend - Xstart) / ((Xend - Xstart) / 18))+1];

            for (int i =0;i<arr.Length;i++) {
                arr[i] = 0;
            }

            int counter = 0;

            for (double x = Xstart; x < Xend; x += H)
            {
                for (int n = 1; n <= N; n++)
                {
                    arr[counter]+=(Math.Pow(-1, n+1) *    (Math.Pow(x, 2 * n) / (2 * n * (2 * n - 1))));
                }
                resultBox.Text += $"X = {x}, F({x}) = {arr[counter]} Y(x): {FuncY(x)}\n";
                counter++;
            }

            //double result = 0;
            //for (int n = 1; n <= N; n++)
            //{   
            //    for (double x = Xstart; x < Xend; x += H)
            //    {
            //        arr[n - 1] += (Math.Pow((-1), n) * (Math.Pow(x, 2 * n) / (2 * n * (2 * n - 1))));
            //        resultBox.Text += $"X = {x}, N = {n} F({x}) = ${arr[(n - 1)]} Y(x): {FuncY(x)}\n";
            //    }
            //    resultBox.Text += "\n";
            //}

            //for (int n = 0; n < N; n++)
            //{
            //    resultBox.Text += $"N = {n} F(x) = ${arr[n]} Y(x): {FuncY(0.8)}\n";
            //}
        }

        private double FuncY(double x) {
            double result = 0;
            return result += x * Math.Atan(x) - Math.Log10(Math.Sqrt(1 + Math.Pow(x, 2)));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";
            FuncX();
        }
    }
}
