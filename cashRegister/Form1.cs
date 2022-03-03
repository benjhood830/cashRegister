using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashRegister
{
    public partial class Burgers : Form
    {
        //Declare global variables
        double burgerNum;
        double fryNum;
        double cokeNum;
        double tenderedNum;

        double burgerPrice = 8;
        double fryPrice = 3;
        double cokePrice = 1.50;
        double tax = 0.13;

        double taxAmount;
        double total;
        double tendered;
        double change;

        double burgerTotal;
        double fryTotal;
        double coketotal;
        double subTotal;
        double taxTotal;
        double totalTotal;
        double changeTotal;

        Random randGen = new Random();
        int randomNum;
        int randomDay;
        int randomMonth;
        int randomYear;



        public Burgers()
        {
            InitializeComponent();
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //try this code
                calculateButton.Enabled = false;
                burgerNum = Convert.ToDouble(burgerInput.Text);
                fryNum = Convert.ToDouble(fryInput.Text);
                cokeNum = Convert.ToDouble(cokeInput.Text);
                //rounding before calucaltion to make sure theres no errors in the math
                burgerTotal = burgerNum * burgerPrice;
                burgerTotal = Math.Round(burgerTotal, 2, MidpointRounding.AwayFromZero);

                fryTotal = fryNum * fryPrice;
                fryTotal = Math.Round(fryTotal, 2, MidpointRounding.AwayFromZero);

                coketotal = cokeNum * cokePrice;
                coketotal = Math.Round(coketotal, 2, MidpointRounding.AwayFromZero);

                subTotal = burgerTotal + fryTotal + coketotal;
                subTotal = Math.Round(subTotal, 2, MidpointRounding.AwayFromZero);

                taxTotal = subTotal * tax;
                taxTotal = Math.Round(taxTotal, 2, MidpointRounding.AwayFromZero);

                totalTotal = taxTotal + subTotal;
                totalTotal = Math.Round(totalTotal, 2);

                subtotalOutput.Text = subTotal.ToString("C");
                taxOutput.Text = taxTotal.ToString("C");
                totalOutput.Text = totalTotal.ToString("C");


            }
            catch
            {
                //Run this if a character other than an integer is entered
                burgerInput.Clear();
                fryInput.Clear();
                cokeInput.Clear();
                tenderedInput.Clear();
                subtotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";

                receiptTitle.Text = "";
                receiptItems.Text = "";
                receiptDate.Text = "";
                burgerInput.Text = "ERROR";
                Refresh();
                Thread.Sleep(3000);

                burgerInput.Clear();

                receiptButton.Enabled = true;
                calculateButton.Enabled = true;
                changeButton.Enabled = true;
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //play sound of coins 
                changeButton.Enabled = false;
                SoundPlayer coins = new SoundPlayer(Properties.Resources.coins);
                coins.Play();

                tenderedNum = Convert.ToDouble(tenderedInput.Text);

                changeTotal = tenderedNum - totalTotal;
                changeTotal = Math.Round(changeTotal, 2, MidpointRounding.AwayFromZero);

                changeOutput.Text = changeTotal.ToString("C");
            }

            catch
            {
                //Run this if a character other than an integer is entered
                burgerInput.Clear();
                fryInput.Clear();
                cokeInput.Clear();
                tenderedInput.Clear();
                subtotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";

                receiptTitle.Text = "";
                receiptItems.Text = "";
                receiptDate.Text = "";
                burgerInput.Text = "ERROR";
                Refresh();
                Thread.Sleep(3000);

                burgerInput.Clear();

                receiptButton.Enabled = true;
                calculateButton.Enabled = true;
                changeButton.Enabled = true;

            }
        }




        private void recieptButton_Click(object sender, EventArgs e)
        {
            try
            {
                //play recepit sound
                receiptButton.Enabled = false;
                SoundPlayer rP = new SoundPlayer(Properties.Resources.printer);
                rP.Play();

                //create random number generator for order number and date

                randomNum = randGen.Next(1, 2001);
                randomDay = randGen.Next(1, 28);
                randomMonth = randGen.Next(1, 13);
                randomYear = randGen.Next(1950, 2050);

                receiptItems.Visible = true;
                receiptTitle.Visible = true;
                receiptDate.Visible = true;
                newButton.Visible = true;

                receiptTitle.Text = "BURGERS BY BEN";
                Refresh();
                Thread.Sleep(500);

                receiptDate.Text = $"Order Number: {randomNum}";
                receiptDate.Text += $"\nDate: {randomDay}/{randomMonth}/{randomYear}";

                Refresh();
                Thread.Sleep(500);
                receiptItems.Text = $"  Burgers     x{burgerNum}     =     {burgerTotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Fries       x{fryNum}     =     {fryTotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Cokes       x{cokeNum}     =     {coketotal.ToString("C")}";

                Refresh();
                Thread.Sleep(500);

                receiptItems.Text += $"\n\n  Subtotal           =     {subTotal.ToString("C")}";
                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Tax                =     {taxTotal.ToString("C")}";
                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Total              =     {totalTotal.ToString("C")}";
                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Tendered           =     {tenderedNum.ToString("C")}";
                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += $"\n\n  Change             =     {changeTotal.ToString("C")}";
                Refresh();
                Thread.Sleep(500);
                receiptItems.Text += "\n\n              HAVE A NICE DAY!!!";




            }
            catch
            {
                //Run this if a character other than an integer is entered
                burgerInput.Clear();
                fryInput.Clear();
                cokeInput.Clear();
                tenderedInput.Clear();
                subtotalOutput.Text = "";
                taxOutput.Text = "";
                totalOutput.Text = "";
                changeOutput.Text = "";

                receiptTitle.Text = "";
                receiptItems.Text = "";
                receiptDate.Text = "";
                burgerInput.Text = "ERROR";
                Refresh();
                Thread.Sleep(3000);

                burgerInput.Clear();

                receiptButton.Enabled = true;
                calculateButton.Enabled = true;
                changeButton.Enabled = true;

            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            //run when user clicks "New Order" button
            receiptButton.Enabled = true;
            calculateButton.Enabled = true;
            changeButton.Enabled = true;

            burgerInput.Clear();
            fryInput.Clear();
            cokeInput.Clear();
            tenderedInput.Clear();

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            receiptTitle.Text = "";
            receiptItems.Text = "";
            receiptDate.Text = "";
        }


    }
}


