/*Author: Miguel Torres Perez */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            double seconds;
            seconds = double.Parse(secTB.Text);
            double days;
            double hours;
            double minutes;

            try
            {
                if(seconds >= 86400)
                {
                    days = seconds / 86400;
                    resultLabel.Text = days + " days";
                }
                else if(seconds >= 3600){
                    hours = seconds / 3600;
                    resultLabel.Text = hours + " hours";
                }
                else if(seconds >= 60)
                {
                    minutes = seconds / 60;
                    resultLabel.Text = minutes + " minutes";
                }
                else
                {
                    resultLabel.Text = seconds + " seconds";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = " ";
            secTB.Text = " ";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
