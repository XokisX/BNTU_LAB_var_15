using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Ticket> list = new List<Ticket>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeButtonVisible() {
            if(ButtonWrite.Visibility==Visibility.Hidden) ButtonWrite.Visibility = Visibility.Visible;
            else ButtonWrite.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ChangeButtonVisible();
                string result = File.ReadAllText(openFileDialog.FileName);
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    string currentString;
                    while ((currentString = streamReader.ReadLine()) !=null) {
                        //MessageBox.Show(currentString);
                    }
                }
            }
        }

        private void ButtonWrite_Click(object sender, RoutedEventArgs e)
        {
            if (InputName.Text != "" && InputMark.Text != "" && InputDate.SelectedDate != null && InputStatus.SelectedItem != null) {
                list.Add(new Ticket(InputName.Text, InputMark.Text,InputDate.SelectedDate.ToString(), InputStatus.SelectedItem.ToString()));
;           }
            ResultGrid.ItemsSource = list;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //save button
        }
    }
}
