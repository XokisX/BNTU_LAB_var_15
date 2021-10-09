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

namespace Lab_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private List<string> GetWords(string str) {
            List<string> list = new List<string>();
            string word = "";
            for (short i = 0;i< str.Length;i++) {
                if (str[i] != ' ')
                {
                    word += str[i];
                }
                else
                {
                    if (word.Length !=0) {
                        list.Add(word);
                    }
                    word = "";
                }
                if (word.Length!=0&&i==str.Length-1) {
                    list.Add(word);
                }
            }
            return (list);
        }

        private string GetShortWord(List<string> list) {
            string word=list[0];
            for (short i = 0;i<list.Count;i++) {
                if (word.Length>list[i].Length) {
                    word = list[i];
                }
            }
            return word;
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultBox.Text = "";
            try {
                List<string> list = GetWords(InputText.Text);
                string word = GetShortWord(list);
                ResultBox.Text=$"Word {word} length: {word.Length} index: {list.IndexOf(word)}";
                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
