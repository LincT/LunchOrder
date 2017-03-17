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
        decimal extraPrice;
        

        SortedList<string, decimal> mainPrice = new SortedList<string, decimal>
        { { "Hamburger", 6.95m}, {"Pizza", 5.95m }, {"Salad",4.95m } };


        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            //method to get selection from group of radio buttons
            mainChoice = ((RadioButton)sender).Name.ToString().Remove(0, 2);
            setOptions();
            gbxOptions.Text = "Add-on items (" + extraPrice.ToString("c") + " each)";
            cbOption1.Checked = false;
            cbOption2.Checked = false;
            cbOption3.Checked = false;
            itemPrice();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            itemPrice();           
        }
        private void setOptions()
        {
            if (mainChoice == "Hamburger")
            {
                cbOption1.Text = "Lettuce, tomato, and onions";
                cbOption2.Text = "Mayonnaise and mustard";
                cbOption3.Text = "French fries";
                extraPrice = .75m;
               
            }
            else if (mainChoice == "Pizza")
            {
                cbOption1.Text = "Pepperoni";
                cbOption2.Text = "Sausage";
                cbOption3.Text = "Olives";
                extraPrice = .50m;
            }
            else if (mainChoice == "Salad")
            {
                cbOption1.Text = "Croutons";
                cbOption2.Text = "Bacon bits";
                cbOption3.Text = "Bread sticks";
                extraPrice = .25m;
            }

        
        }
        private void itemPrice()
        {
            decimal tax = .0775m;
            decimal tempCalc = mainPrice[mainChoice];
            if (cbOption1.Checked) { tempCalc += extraPrice; }
            if (cbOption2.Checked) { tempCalc += extraPrice; }
            if (cbOption3.Checked) { tempCalc += extraPrice; }
            decimal taxCalc = tempCalc * tax;
            lblSubTotal.Text = tempCalc.ToString("c");
            lblTax.Text = taxCalc.ToString("c");
            lblTotal.Text = (tempCalc + taxCalc).ToString("c");
        }
        public List<string> getOptions()
        {
            List<string> preOptions = new List<string> { };
            if (cbOption1.Checked) { preOptions.Add(cbOption1.Text); }
            if (cbOption2.Checked) { preOptions.Add(cbOption2.Text); }
            if (cbOption3.Checked) { preOptions.Add(cbOption3.Text); }
            return (preOptions);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(lbPreview.Items.Count == 0)
            {
                MessageBox.Show("No items in order.");
            }
            else
            {
                string receiptString = "Order receipt:\n";
                foreach(object item in lbPreview.Items)
                {
                    receiptString += lbPreview.GetItemText(item) + "\n";
                }
                receiptString += 
                MessageBox.Show(receiptString);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal grandTotal;
                //txtPreview.Text += mainChoice + "\n\t" + getOptions() + "\n\t" + lblTotal.Text + "\n";
                lbPreview.Items.Add(mainChoice);
                List<string> optionItems = getOptions();
                if (optionItems.Count > 0)
                {
                    foreach (string optionItem in optionItems)
                    {
                        lbPreview.Items.Add(optionItem);
                    }
                }
                     
                lbPreview.Items.Add("Item Total: " + lblTotal.Text);
                //preventative check to avoid null value errors
                if (lblGrand.Text == "") { lblGrand.Text = (0.00m).ToString("c"); }
                grandTotal = Convert.ToDecimal(lblGrand.Text.Remove(0,1)) +
                    Convert.ToDecimal(lblTotal.Text.Remove(0,1));
                lblGrand.Text = grandTotal.ToString("c");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbPreview.Items.Clear();
            lblGrand.Text = "";
        }
    }

}