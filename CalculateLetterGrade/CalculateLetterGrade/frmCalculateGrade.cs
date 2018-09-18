using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        // function for Calculate button Click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get input from the user, and convert string txtNumberGrade to decimal
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            // initialize string letterGrade to ""
            string letterGrade = "";
            // if decimal numberGrade is between 88 to 100
            if (numberGrade >= 88 && numberGrade <= 100) 
            {
                letterGrade = "A"; // string letterGrade is "A"
            }
            // if decimal numberGrade is between 80 to 87
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B"; // string letterGrade is "B"
            }
            // if decimal numberGrade is between 68 to 79
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C"; // string letterGrade is "C"
            }
            // if decimal numberGrade is between 60 to 67
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D"; // string letterGrade is "D"
            }
            // if decimal numberGrade is not in range [60, 100]
            else 
            {
                letterGrade = "F"; // string letterGrade is "F"
            }

            // change the value of txtLetterGrade to letterGrade  
            txtLetterGrade.Text = letterGrade;
            // move the focus back to txtNumberGrade
            txtNumberGrade.Focus(); 
        }

        // function for Exit button Click
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // close the form
        }
    }
}
