using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_3___Chapter_Problems
{
    public partial class BasicInput : Form
    {
        string userName;
        int userAge;
        double userHeight;
        public BasicInput()
        {
            InitializeComponent();
        }

        private void txtNameInput_TextChanged(object sender, EventArgs e)
        {
            userName = Convert.ToString(txtNameInput.Text);
        }

        private void txtAgeInput_TextChanged(object sender, EventArgs e)
        {
            userAge = Convert.ToInt32(txtAgeInput.Text);
        }

        private void txtHeightInput_TextChanged(object sender, EventArgs e)
        {
            userHeight = Convert.ToDouble(txtHeightInput.Text);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ($"Hello {userName}! You're {userAge}? That means you have an expected {82 - userAge} years remaining! If you're actually {userHeight}, that measns the tallest person in the world is {2.72 - userHeight} meters taller than you! That's all I've got for you, Have a good day!");
        }
    }
}
