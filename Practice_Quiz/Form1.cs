using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void question01Button_Click(object sender, EventArgs e)
        {
            question1OutputLabel.Text = "Happy Hump Day ";

        }

        private void question2Button_Click(object sender, EventArgs e)
        {
            string username = question2TextBox.Text;
            question2OutputLabel.Text = "Hello " + username + ".";
        }

        private void question3Button_Click(object sender, EventArgs e)
        {
            try
            {
                int int1 = Convert.ToInt16(q3Int1Text.Text);
                int int2 = Convert.ToInt16(q3int2Text.Text);
                int product = int1 * int2;
                question3OutputLabel.Text = int1 +" X "+ int2 +" = " + product;
            }
            catch
            {
                question3OutputLabel.Text = "Please enter an integer and try again.";
            }
        }
    }
}
