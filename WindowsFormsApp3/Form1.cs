using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder stringBuilder = new StringBuilder();

        private void Form1_Load(object sender, EventArgs e)
        {

            //button2.Text= ((char)0x00F7).ToString();
            button2.Text = "%";
            button3.Text = ((char)0x221A).ToString();
            button4.Text= "x"+((char)0x00B2).ToString();
            button5.Text = "1/x";
            button6.Text = "CE";
            button7.Text = "C";
            button8.Text = "⌫";
            button9.Text=  ((char)0x00F7).ToString();
            button10.Text = "1";
            button11.Text = "2";
            button12.Text = "3";
            button13.Text = "×";
            button14.Text = "4";
            button15.Text = "5";
            button16.Text = "6";
            button17.Text = "—";
            button18.Text = "7";
            button19.Text = "8";
            button20.Text = "9";
            button21.Text = "+";
            button22.Text = "±";
            button23.Text = "0";
            button24.Text = ".";
            button25.Text = "=";
            label2.Text = "0";
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button senderCast = sender as Button;

            stringBuilder.ToString().Last(); //axirinci chari qaytarir
            stringBuilder.Append(senderCast.Text);
            label2.Text = stringBuilder.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
