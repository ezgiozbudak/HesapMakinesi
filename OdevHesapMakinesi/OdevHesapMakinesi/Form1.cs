using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevHesapMakinesi
{
    public partial class Form1 : Form
    {
        public double sayi1;
        public string operator1;
        System.Media.SoundPlayer player;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch(e.KeyChar)
            {
                #region 0-9 arası sayıların ekrana yazdırılması
                case '1': textBox1.Text += btn1.Text;break;
                case '2': textBox1.Text += btn2.Text;break;
                case '3': textBox1.Text += btn3.Text; break;
                case '4': textBox1.Text += btn4.Text; break;
                case '5': textBox1.Text += btn5.Text; break;
                case '6': textBox1.Text += btn6.Text; break;
                case '7': textBox1.Text += btn7.Text; break;
                case '8': textBox1.Text += btn8.Text; break;
                case '9': textBox1.Text += btn9.Text; break;
                case '0': textBox1.Text += btn0.Text; break;
                #endregion
                #region işlemleri yapabilmek için ilk sayıyı bir değişkene atadım , operatör atadıktan sonra text'i sıfırladım
                case '*':
                    sayi1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text += btnCarp.Text;
                    player = new System.Media.SoundPlayer(Properties.Resources.WAIT_WHAT___SOUND_EFFECT);
                    player.Play();
                    operator1 = btnCarp.Text;
                    textBox1.Text= "";
                    break;
                case '/':
                    player = new System.Media.SoundPlayer(Properties.Resources.Investigations__Kevin_MacLeod____Gaming_Background_Music__HD_);
                    player.Play();
                    sayi1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text += btnBol.Text;
                    operator1 = btnBol.Text;
                    textBox1.Text = "";
                    break;
                case '-':
                    player = new System.Media.SoundPlayer(Properties.Resources.The_Curious_Kitten__Aaron_Kenny____Comedy_Background_Music__HD_);
                    player.Play();
                    sayi1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text += btnCikar.Text;
                    operator1 = btnCikar.Text;
                    textBox1.Text = "";
                    break;
                case '+':
                    player = new System.Media.SoundPlayer(Properties.Resources.Spongebob_Music___Background_Music__HD_);
                    player.Play();
                    sayi1 = Convert.ToDouble(textBox1.Text);
                    operator1 = btnTopla.Text;
                    textBox1.Text += btnTopla.Text;               
                    textBox1.Text = "";
                    break;
                    #endregion
            }
            #region enter tuşuna basıldığında sonucun yazdırılması ve müziğin durdurulması
            if (e.KeyChar == (char)Keys.Enter)
            {
                player.Stop();
                switch (operator1)
                {
                    case "+": textBox1.Text = (sayi1 + Double.Parse(textBox1.Text)).ToString(); break;
                    case "-": textBox1.Text = (sayi1 - Double.Parse(textBox1.Text)).ToString(); break;
                    case "/": textBox1.Text = (sayi1 / Double.Parse(textBox1.Text)).ToString(); break;
                    case "*": textBox1.Text = (sayi1 * Double.Parse(textBox1.Text)).ToString(); break;

                    default: break;
                }
            }
            #endregion
            #region c tuşu ile textbox'ın sıfırlanması
            if (e.KeyChar == 'c'  || e.KeyChar == 'C')
            {
                btnSil_Click(sender, e);
            }
            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            player.Stop();
            textBox1.Clear();
            sayi1 = 0;
            operator1 = null;
        }
    }
}
