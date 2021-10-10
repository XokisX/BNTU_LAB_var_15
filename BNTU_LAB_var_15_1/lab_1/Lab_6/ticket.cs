using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    

    class Ticket
    {
        public string name { get; set; }
        public string mark { get; set; }
        public string dateReceived { get; set; }
        public string status { get; set; }



        public Ticket(string name,string mark,string dateReceived,string status) {
            this.name = name;
            this.mark = mark;
            this.dateReceived = dateReceived;
            this.status = status;
        }

        public Ticket(string fullStr) {
            
            List<string> words = GetWords(fullStr);
            try
            {
                this.name = words[0];
                this.mark = words[1];
                this.dateReceived = words[2];
                this.status = words[3];
            }
            catch (Exception ex) {
                throw new Exception("Wrong format");
            }
            
        }

        public override string ToString()
        {
            return ($"{name} {mark} {dateReceived} {status}");
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
    }
}
