﻿using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace TradeCalculator
{
    public partial class Form1 : Form
    {
        public double unit = 0;
        public double unitR = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        #region V 1.0.2 CODE

        private void Btn_CalculateR_Click(object sender, EventArgs e)
        {

            double investValwLmod = (Double.Parse(txt_InvestmentR.Text) * Double.Parse(txt_LeverageR.Text));
            double returnVal = Double.Parse(txt_RequiredReturn.Text);


            // Checks wether feilds have been filled
            if (txt_LeverageR.Text == "" || txt_InvestmentR.Text == "" || txt_BuyValueR.Text == "" || txt_RequiredReturn.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else
            {
                // Sets default Leverage to 1
                if (Double.Parse(txt_LeverageR.Text) < 1)
                {
                    txt_Leverage.Text = "1";
                }
                // Caps Leverage to 10
                if (Double.Parse(txt_LeverageR.Text) > 10)
                {
                    txt_Leverage.Text = "10";
                }

                // Calculates how many units were bought (leverage applied)
                unitR = ((Double.Parse(txt_InvestmentR.Text) / Double.Parse(txt_BuyValueR.Text)) * Double.Parse(txt_LeverageR.Text));

                rtb_Log.Text = unitR.ToString(); // Log -- Will Delete

                //Storing current Value
                double currentVal = Double.Parse(txt_BuyValueR.Text) * unitR;
                
                rtb_Log.AppendText("\n" + currentVal.ToString()); // Log -- Will Delete

                //Code to work out what value to sell at to meet the required return
                // goes here ..

                // Placeholder..
                
                //
                //



                
            }
        }

        #endregion

        #region V 1.0.1 CODE

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {


            // Checks wether feilds have been filled
            if (txt_Leverage.Text == "" || txt_Investment.Text == "" || txt_BuyValue.Text == "" || txt_SellValue.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else
            {
                // Sets default Leverage to 1
                if (Double.Parse(txt_Leverage.Text) < 1)
                {
                    txt_Leverage.Text = "1";
                }
                // Caps Leverage to 10
                if (Double.Parse(txt_Leverage.Text) > 10)
                {
                    txt_Leverage.Text = "10";
                }

                // Calculates how many units were bought (leverage applied)
                unit = ((Double.Parse(txt_Investment.Text) / Double.Parse(txt_BuyValue.Text)) * Double.Parse(txt_Leverage.Text));

                // Calculated profit / loss, initial investment * leverage have been subtracted from total 
                txt_Result.Text = Math.Round((unit * Double.Parse(txt_SellValue.Text)) - (Double.Parse(txt_Investment.Text) * Double.Parse(txt_Leverage.Text)), 2).ToString();
            }



        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_BuyValue.Text = "";
            txt_SellValue.Text = "";
            txt_Leverage.Text = "";
            txt_Investment.Text = "";
            txt_Result.Text = "";

        }

        #endregion


        #region TOOLTIPS AND VALIDATIONS (all versions)

        private void Txt_Investment_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && (e.KeyChar != '.') && c != 8)
            {
                e.Handled = true;
                
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1) {
                e.Handled = true;
            };
        }



        private void Txt_BuyValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && (e.KeyChar != '.') && c != 8)
            {
                e.Handled = true;
                
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            };
        }

        private void Txt_Leverage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                
            }

        }

        private void Txt_SellValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && (e.KeyChar != '.') && c != 8)
            {
                e.Handled = true;
               
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            };
        }

        private void Txt_BuyValue_Enter(object sender, EventArgs e)
        {
            ssl_Info.Text = "This is the value you bought/plan to buy units at";
        }

        private void Txt_Investment_Enter(object sender, EventArgs e)
        {
            ssl_Info.Text = "This is the amount of money you plan to/have invested";
        }

        private void Txt_Leverage_Enter(object sender, EventArgs e)
        {
            ssl_Info.Text = "This is the leverage you put on the trade ( if left blank will default to 1, caps at 10)";
        }

        private void Txt_SellValue_Enter(object sender, EventArgs e)
        {
            ssl_Info.Text = "This is the value you sold/plan to sell units at";
        }

        private void Txt_Result_Enter(object sender, EventArgs e)
        {
            ssl_Info.Text = "This is your return value minus the initial investment sum (leverage mod applied)";
        }

        
    }
    #endregion

}


