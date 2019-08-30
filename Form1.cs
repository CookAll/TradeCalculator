using System;
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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            txt_BuyValue.Text = "";
            txt_SellValue.Text = "";
            txt_Leverage.Text = "";
            txt_Investment.Text = "";
            txt_Result.Text = "";
            
        }
        private void Btn_Calculate_Click(object sender, EventArgs e)
        {

            

            if (txt_Leverage.Text == "" || txt_Investment.Text == "" || txt_BuyValue.Text == "" || txt_SellValue.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else
            {
                if (Double.Parse(txt_Leverage.Text) < 1)
                {
                    txt_Leverage.Text = "1";
                }

                if (Double.Parse(txt_Leverage.Text) > 10)
                {
                    txt_Leverage.Text = "10";
                }

                unit = ((Double.Parse(txt_Investment.Text) / Double.Parse(txt_BuyValue.Text)) * Double.Parse(txt_Leverage.Text));

                txt_Result.Text = Math.Round((unit * Double.Parse(txt_SellValue.Text)) - (Double.Parse(txt_Investment.Text) * Double.Parse(txt_Leverage.Text)), 2).ToString();
            }



        }


        #region TOOLTIPS AND VALIDATIONS

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


