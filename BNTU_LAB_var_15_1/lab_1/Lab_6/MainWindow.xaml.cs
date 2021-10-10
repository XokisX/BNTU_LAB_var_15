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
        OpenFileDialog openFileDialog;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeButtonVisible() {
            if (ButtonWrite.Visibility == Visibility.Hidden) ButtonWrite.Visibility = Visibility.Visible;
            else ButtonWrite.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == true)
            {
                ChangeButtonVisible();
                string result = File.ReadAllText(openFileDialog.FileName);
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {

                    string currentString;
                    while ((currentString = streamReader.ReadLine()) != null) {
                        //MessageBox.Show(currentString);
                        List<string> words = new List<string>();
                        words = GetWords(currentString);
                        list.Add(new Ticket(words[0], words[1], words[2], words[3]));
                    }
                    ResultGrid.ItemsSource = null;
                    ResultGrid.ItemsSource = list;
                }
            }
        }

        private void ButtonWrite_Click(object sender, RoutedEventArgs e)
        {
            if (InputName.Text != "" && InputMark.Text != "" && InputDate.SelectedDate != null && InputStatus.SelectedItem != null) {
                list.Add(new Ticket(InputName.Text, InputMark.Text, InputDate.SelectedDate.Value.ToString("dd.MM.yyyy"), InputStatus.SelectedItem.ToString()));
                ; }
            ResultGrid.ItemsSource = null;
            ResultGrid.ItemsSource = list;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //save button
            if (openFileDialog != null) {
                using (StreamWriter streamWriter = new StreamWriter(openFileDialog.FileName))
                {
                    for (short i = 0; i < list.Count; i++) {
                        streamWriter.WriteLine(list[i].ToString());
                    }
                }
            }
        }

         private List<string> GetWords(string str)
        {
            List<string> list = new List<string>();
            string word = "";
            for (short i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    if (word.Length != 0)
                    {
                        list.Add(word);
                    }
                    word = "";
                }
                if (word.Length != 0 && i == str.Length - 1)
                {
                    list.Add(word);
                }
            }
            return (list);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            openFileDialog = null;
            ChangeButtonVisible();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            List<Ticket> sortedList = new List<Ticket>();
            if (list.Count!=0) {
                for (short i =0;i<list.Count;i++) {
                    if (DateTime.Now.ToString("dd.MM.yyyy")==list[i].dateReceived) {
                        sortedList.Add(list[i]);
                    }
                }
                ResultGrid.ItemsSource = null;
                ResultGrid.ItemsSource = sortedList;
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (list.Count != 0)
            {
                
                ResultGrid.ItemsSource = null;
                ResultGrid.ItemsSource = list;
            }
        }
    }
}
