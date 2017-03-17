using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        string mainChoice;
        public Form1()
        {
            InitializeComponent();
            //test comment to test git commit
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //first method to get shape selection from shape group of radio buttons
            string sendName = ((RadioButton)sender).Name.ToString().Remove(0, 2);
            mainChoice = sendName;
            setOptions();
        }
        private void setOptions()
        {
            if (mainChoice == "Hamburger")
            {
                cbOption1.Text = "Lettuce, tomato, and onions";
                cbOption2.Text = "Mayonnaise and mustard";
                cbOption3.Text = "French fries";
            }
            else if (mainChoice == "Pizza")
            {
                cbOption1.Text = "Pepperoni";
                cbOption2.Text = "Sausage";
                cbOption3.Text = "Olives";
            }
            else if (mainChoice == "Salad")
            {
                cbOption1.Text = "Croutons";
                cbOption2.Text = "Bacon bits";
                cbOption3.Text = "Bread sticks";
            }
        }
    }

}