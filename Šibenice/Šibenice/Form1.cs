using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Šibenice
{
    public partial class Form1 : Form
    {
        public Bitmap[] stádia = { global::Šibenice.Properties.Resources._1, global::Šibenice.Properties.Resources._2, global::Šibenice.Properties.Resources._3, global::Šibenice.Properties.Resources._4, global::Šibenice.Properties.Resources._5, global::Šibenice.Properties.Resources._6, global::Šibenice.Properties.Resources._7, global::Šibenice.Properties.Resources.END_GOOD, global::Šibenice.Properties.Resources.END_BAD };
        public int chyby = 0;
        public string kopieSlova = "";
        public string slovo;
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer2;
        public Form1()
        {
            
            InitializeComponent();
            InitWindow();
            _soundPlayer = new SoundPlayer(Properties.Resources.LOSS);
            _soundPlayer2 = new SoundPlayer(Properties.Resources.WIN);
            
        }


        void InitWindow()
        {
            this.Size = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void přípravaHry()
        {
            chyby = 0;
            pb_image.Image = stádia[chyby];
            slovo = Slova.ZískejSlovo();
            kopieSlova = "";
            for (int i = 0; i < slovo.Length; i++)
            {
                kopieSlova += "_";
            }
            ukažKopiiSlova();
        }

        public void ukažKopiiSlova()
        {
            showWord.Text = "";
            for (int i = 0; i < kopieSlova.Length; i++)
            {
                showWord.Text += kopieSlova.Substring(i,1);
                showWord.Text += " ";
            }
        }
        public void btnClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (slovo.Contains(choice.Text))
            {
                char[] temp = kopieSlova.ToCharArray();
                char[] find = slovo.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);

                for (int i = 0; i < find.Length; i++)
                {
                    if(find[i] == guessChar)
                    {
                        temp[i] = guessChar;
                    }
                }
                kopieSlova = new string(temp);
                ukažKopiiSlova();


            }
            else
            {
                chyby++; 
            }
            if (chyby < 7)
            {
                lbl_chyby.Text = "Chyby: " + chyby + "/7";
                pb_image.Image = stádia[chyby];
            }
            else
            {
                lbl_chyby.Text = "Chyby: 7/7";
                lblResult.Text = "Konec hry";
                _soundPlayer.Play();
                DisableBtns();
                pb_image.Image = stádia[8];
                lbl_hadaneSlovo.Text = "Hádané slovo bylo: " + slovo.ToUpper() + ".";
            }
            if (kopieSlova.Equals(slovo))
            {
                lblResult.Text = "Uhádl jsi slovo!";
                DisableBtns();
                _soundPlayer2.Play();
                pb_image.Image = stádia[7];
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            přípravaHry();
            TODO();
            lbl_chyby.Text = "Chyby: 0/7";
        }

        public void TODO()
        {
            lbl_todo.Text = "";
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            přípravaHry();
            lbl_chyby.Text = "";
            lblResult.Text = "";
            lbl_hadaneSlovo.Text = "";
            EnableBtns();
            


        }
        public void EnableBtns()
        {
            btnA.Enabled = true;
            button1.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button2.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }
        public void DisableBtns()
        {
            btnA.Enabled = false;
            button1.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button2.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
    }
}