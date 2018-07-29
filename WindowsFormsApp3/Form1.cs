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
            button2.Text = "%";
            button3.Text = ((char)0x221A).ToString();
            button4.Text= "x"+((char)0x00B2).ToString();
            button5.Text = "1/x";
            button6.Text = "CE";
            button7.Text = "C";
            button8.Text = "⌫";
            button9.Text= "÷";
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
        int[] numbers=new int[100];
        string[] numbers1;
        int count = -1;
        Button senderCast;
        private void button10_Click(object sender, EventArgs e)
        {
            senderCast = sender as Button;

            if (senderCast.Text != "+"&& senderCast.Text != "—"&& senderCast.Text != "×" && senderCast.Text != "÷")
            {
                stringBuilder.Append(senderCast.Text);
                label2.Text = stringBuilder.ToString();
            }
            else
            {
                

                if (stringBuilder.ToString().Last().ToString()== "+"|| stringBuilder.ToString().Last().ToString() == "—" || stringBuilder.ToString().Last().ToString() == "×" || stringBuilder.ToString().Last().ToString() == "÷")
                {
                    stringBuilder.Remove(stringBuilder.Length - 1, senderCast.Text.Length);
                    stringBuilder.Append(senderCast.Text);
                    label2.Text = stringBuilder.ToString();
                }
                else
                {
                    Beraberlik();
                    numbers1 = label2.Text.Split('×');
                    count++;
                    numbers[count] = Convert.ToInt32(numbers1[count]);
                    stringBuilder.Clear();
                    stringBuilder.Append(numbers1[count]);

                    stringBuilder.Append(senderCast.Text);
                    label2.Text = stringBuilder.ToString();  
                }  
            }                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int a = 1;
        private void button25_Click(object sender, EventArgs e) //beraberlik buttonu (Burdan davam et)
        {
             //a = 1;
            numbers1 = label2.Text.Split('×');
            count++;
            try
            {
                numbers[count] = Convert.ToInt32(senderCast.Text);
                MessageBox.Show("Try");
            }
            catch (Exception)
            {
                MessageBox.Show("Exp");
                numbers[count] = Convert.ToInt32(numbers1[count-1]);
            }
            
            //MessageBox.Show(numbers1[count]);
            label2.Text = "";
            
            for (int i = 0; i < count+1; i++)
            {
                a*=numbers[i];
            }
            label2.Text = a.ToString();
           // a = Convert.ToInt32(label2.Text);
            count = -1;
        }

        void Beraberlik()
        {
            int a = 1;
            numbers1 = label2.Text.Split('×');
            count++;
            try
            {
                numbers[count] = Convert.ToInt32(numbers1[count]);
                MessageBox.Show("Try");
            }
            catch (Exception)
            {
                MessageBox.Show("Exp");
                numbers[count] = Convert.ToInt32(numbers1[count - 1]);
            }

            //MessageBox.Show(numbers1[count]);
            label2.Text = "";

            for (int i = 0; i < count + 1; i++)
            {
                a *= numbers[i];
            }
            label2.Text = a.ToString();
            // a = Convert.ToInt32(label2.Text);
            count = -1;
        }
    }
}
