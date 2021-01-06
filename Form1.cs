using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JPWP
{
    public partial class Form1 : Form
    {

     
        static Dictionary<string, string> words = new Dictionary<string, string>(){
           {"r.a.m.o.t.a", "Kicz literacki"},
            {"h.u.m.b.u.g", "Kłamstwo"},
            {"l.a.d.a.c.o", "Człowiek lekkomyślny"},
            {"b.l.u.r.b", "Notka reklamowa" },
            {"p.r.o.d.i.ż", "Pokolenie w średnim wieku" }
        };
        //ramota  to jest words.ElementAt(0).Key lub words["Kicz literacki"]
        static int a = 0;
        static string[] tab = words.ElementAt(a).Key.Split('.');
        static bool start = false;//zmienna start, uzywamy jej do rozpoczecia gry kiedy wcisnie sie 1

        public Form1()
        {
            InitializeComponent();

        }


        private void Input_TextChanged(object sender, EventArgs e)
        {
            Label[] letters = { Letter1, Letter2, Letter3, Letter4, Letter5, Letter6 }; //tablica obiektow typu Label (literki)
            string checkword = Input.Text;
            if (checkword == "1")//jesli wcisniesz 1
            {
                start = true;
            }
            Input.Text = null;
            LetterDisplay.Text = checkword;//checkword - to co wpisujesz
            Definition.Text = words.ElementAt(a).Value;//Definition - nazwa obiektu Label. Tekst sie zmienia na wartosc "value" odpowiedniego miejsca w tablicy words. Tzn ze value dla slowa to jego definicja
            if (Array.Exists(tab, element => element == checkword) & start == true)//jesli sie zgadza i jednoczesnie start = true
            {
               
                int index = Array.IndexOf(tab, checkword);//bierzemy indeks takiego miejsca w tablocy tab (tab - tablica literek danego slowa), ktory odpowiada wpisanej loterce
                letters[index].Text = checkword;//Ustawiamy tekst labela o takim indeksie, ktory odpowiada indeksowi literki 
                tab[index] = null;//nullujemy, juz wiesz po co
                LetterDisplay.BackColor = Color.Green;//kolor zielony
            }
            else if (!Array.Exists(tab, element => element == checkword))//jesli litera jest zla
            {
                
                LetterDisplay.BackColor = Color.Red;//czerowny Letter display - label literki ktora sie pokazuje

                if (checkword != "1")//jesli nie jest 1 
                {
                      //tutaj wpisz kod, ktory chcesz wykonac wtedy kiedy litera jest zla (np. Console.WriteLine(źle))                    
                    Used.Text = Used.Text + "  " + checkword;//uzywane literki; Used - nazwa labela 
                }
            }
            if (checkword == "q")//jesli q
            {
                Used.Text = "Wykorzystane literki:";
                Definition.Text = words.ElementAt(a + 1).Value;//definicja (a+1, bo sie zmienialo na jakies gowno wczensiej, mozesz zobaczyc cop sie dzieje, gdy to zakomentujesz)
                LetterDisplay.Text = "Nastepne slowo";
                LetterDisplay.BackColor = Color.Pink;
                if (Array.TrueForAll(tab, el => el == null))// jesli wszystkie sa nullami
                {
                    a++;//zwiekszamy indeks tablicy words
                    tab = words.ElementAt(a).Key.Split('.');//Key - slowo , tablica tab to teraz tablica literek nastepnego slowa
                    Array.ForEach(letters, letter => letter.Text = "-");//zamieniamy znowu na myslniki; foreach - zmieniamy kazdy element tablicy 
                }

            }
            if (checkword == "1")//napis start 
            {
                LetterDisplay.BackColor = Color.Black;
                LetterDisplay.Text = "START";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //tutaj mozesz rysowac, np. Rysowanie linii od punktu (1,5) do punktu (2,6)
          //Graphics g = e.Graphics;
          // Pen myPen = new Pen(System.Drawing.Color.Red, 5);
           // g.DrawLine(myPen, 1, 5, 2, 6);

        }


    }

}
