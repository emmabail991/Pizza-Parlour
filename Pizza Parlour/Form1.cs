//Emmanuel Bailey
//2021-05-04
//Pizza parlor
//MR.T 3U computer science




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Parlour
{
    public partial class Form1 : Form
    {   //variables
        double toppingPrice = 1.25;
        double basePrice = 7.00;
        double toppingAmount;
        double totalPrice;


        public Form1()
        {
            InitializeComponent();
        }

        //Calculate button output message
        private void calculateButton_Click(object sender, EventArgs e)
        {    
            try
            {   //totalprice claculations 
                toppingAmount = Convert.ToDouble(inputTopping.Text);
                totalPrice = toppingAmount * toppingPrice + basePrice;
               
                //price message 
                outputLabel.Text = $"The total price of the pizza with {toppingAmount} toppings is {totalPrice.ToString("c")} ";
            }
            catch
            {   //error message 
                outputLabel.Text = "please but in a number to indicate the amount of toppings";

            }
        }
    }
}
