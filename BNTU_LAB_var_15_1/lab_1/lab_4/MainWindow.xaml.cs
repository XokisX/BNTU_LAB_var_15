using System;
using System.Collections.Generic;
using System.Data;
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

namespace lab_4
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
        private int row = 0;
        private int colums = 0;
        int[,] matr;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            row = int.Parse(matrixSize.Text);
            colums = int.Parse(matrixSize.Text);
            matr = new int[row,colums];
            for (short i = 0; i < colums;i++) {
                for (short j = 0; j < row; j++)
                {
                    matr[i,j] = rnd.Next(-100,100);
                }
            }
            
            dataGrid2D.ItemsSource2D = matr;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (colums>1&&row>1) {
                int delRow = 0;
                int delCol = 0;
                int value = 0;
                for (short i = 0; i < colums; i++)
                {
                    for (short j = 0; j < row; j++)
                    {
                        if (Math.Abs(matr[j, i]) > value)
                        {
                            value = Math.Abs(matr[j, i]);
                            delRow = i;
                            delCol = j;
                        }
                    }
                }

                int[,] m = new int[row - 1, colums - 1];
                for (short i = 0, newI = 0; i < colums; i++)
                {
                    for (short j = 0, newJ = 0; j < row; j++)
                    {
                        if (delRow != j && delCol != i)
                        {
                            m[newI, newJ] = matr[i, j];
                            newJ++;
                        }
                    }
                    if (delCol != i) newI++;
                }
                row--;
                colums--;
                matr = m;
                dataGrid2D.ItemsSource2D = m;
            }
            
        }
    }
}
