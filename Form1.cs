using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPWP
{
    public partial class Form1 : Form
    {
            
          //  static string[] words = { "b a n a n a", "r a m o t a", "h u m b u g", "l a d a c o", "b l u r b" };
        Dictionary<string, string> words = new Dictionary<string, string>(){
            {"r.a.m.o.t.a", "Kicz literacki"},
            {"h.u.m.b.u.g", "Kłamstwo"},
            {"l.a.d.a.c.o", "Człowiek lekkomyślny"},
            {"b.l.u.r.b", "Notka reklamowa" },
            {"p.r.o.d.i.ż", "Pokolenie w średnim wieku" }
        };
        static int a = 0;
        static string[] tab = words.ElementAt(a).Key.Split('.');
        public Form1()
        {
                 InitializeComponent();
        }

            private void Form1_Load(object sender, EventArgs e)
            {

            }


        private void Input_TextChanged(object sender, EventArgs e)
        {
            Label[] letters = { Letter1, Letter2, Letter3, Letter4, Letter5, Letter6 };
            string checkword = Input.Text;
            Input.Text = null;
            LetterDisplay.Text = checkword;
            if (Array.Exists(tab, element => element == checkword))
            {
                int index = Array.IndexOf(tab, checkword);
                letters[index].Text = checkword;
                tab[index] = null;
                LetterDisplay.BackColor = Color.Green;
            }
            else
            {
                LetterDisplay.BackColor = Color.Red;
                Console.WriteLine("koniec");
            }
           if (checkword == "q")
            {
                LetterDisplay.Text = "Nastepne slowo";
                LetterDisplay.BackColor = Color.Pink;
                if (Array.TrueForAll(tab, el => el == null))
                {
                    a++;
                    tab = words[a].Split('.');
                    Console.WriteLine("aaa");
                    Array.ForEach(letters, letter => letter.Text = "-");
                }
                
            }
            


        }
        private void snake()
        {

        }

            private void Letter1_Click(object sender, EventArgs e)
            {

            }

            private void Letter2_Click(object sender, EventArgs e)
            {

            }

            private void Letter3_Click(object sender, EventArgs e)
            {

            }

            private void Letter4_Click(object sender, EventArgs e)
            {

            }

            private void Letter5_Click(object sender, EventArgs e)
            {

            }

            private void Letter6_Click(object sender, EventArgs e)
            {

            }

    }
    
}
