using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int rnd = 0, counter = 0;
        int minnumber = 100;
        int maxnumber = 999;
        int input;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            rnd = r.Next(100,999);
            label1.Text = rnd.ToString();
            label2.Text = "Round: " + counter.ToString();




            try
            {

                do
                {
                    input = (minnumber + maxnumber) / 2;

                    textBox1.Text=input.ToString();
                    button1.PerformClick();
                    textBox1.Text = "";


                    if (input > 999 || input < 100)
                    {
                        MessageBox.Show("Number is not in range");
                        return;
                    }
                    counter++;
                    label2.Text = "Round: " + counter.ToString();
                    if (counter > 10)
                    {
                        MessageBox.Show("Game Over!");
                        button1.Enabled = false;
                        return;
                    }
                    listBox1.Items.Add(input);
                    if (input > rnd)
                    {
                        MessageBox.Show("Your Guess > this Number");
                        maxnumber = input + 1;
                    }
                    else if (input < rnd)
                    {
                        MessageBox.Show("Your Guess < this Number");
                        minnumber = input + 1;
                    }
                    else
                    {
                        MessageBox.Show("WIN");
                        label2.Text += " - You WIN";
                        button1.Enabled = false;
                    }
                } while (input != rnd);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
