using OxyPlot.Wpf;
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

namespace Lab_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const double h = 0.1;
        public MainWindow()
        {
            InitializeComponent();
            
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
                firstPart = ((Math.Pow(X, (Y + 1))) + (Math.Pow(Math.E, (Y - 1)))) / ((1 + X * (Math.Abs(Y - Math.Tan(Z)))));
                secondPart = 1 + Math.Abs(Y - X);
                thirdPart = ((Math.Pow(Math.Abs(Y - X), 2)) / 2) - ((Math.Pow(Math.Abs(Y - X), 3)) / 3);
                result = firstPart * secondPart + thirdPart;
                resultBox.Text = result.ToString();
                double[] x = new double[200];
                double[] y = new double[200];
                double num = 0;
                for (short i = 0;i<x.Length;i++,num+=h) {
                    x[i] = num;
                    y[i] = num;
                }
                linegraph.Plot(x, y);
                PlotView pv = new PlotView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
