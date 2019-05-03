using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class form1 : Form
    {
        //Initialize random number generator
        //Create random numbers

        Random randomizer = new Random();

        //Store variables for addition problem
        int addend1;
        int addend2;
        //Start the quiz and fill the question mark
        public form1()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

        }

        public void StartTheQuiz()
        {
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //Convert the random numbers into strings
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
    }
}
