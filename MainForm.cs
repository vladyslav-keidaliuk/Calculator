using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction();
        String operation;
        public Calculator()
        {

            InitializeComponent();
            txt_field.AutoSize = false;


            txt_display.Enabled = false;
            txt_display.Text = "";

            txt_display.Height = 50;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_fraction_Click(object sender, EventArgs e)
        {
            txt_field.Text = txt_field.Text+ "/";
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            
            if (txt_field.Text.Length >0)
            {
                txt_field.Text = txt_field.Text.Substring(0, txt_field.Text.Length - 1);
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            operation = "";
            txt_field.Text = "";
            txt_display.Text = "";

        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_result_Click(object sender, EventArgs e)
        {
            fraction2 = txt_field.Text;

            txt_display.Text += txt_field.Text + "=";

            txt_field.Text = result();

        }

        public void btn_operation_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn = (Button)sender;
            operation = btn.Text;
            fraction1 = txt_field.Text;
            txt_display.Text += txt_field.Text;
            txt_display.Text += btn.Text;
            txt_field.Text = "";
        }

        private void btn_number_Click(object sender, EventArgs e)
        {
            

            Button btn = new Button();
            btn = (Button)sender;
            txt_field.Text += btn.Text;
        }

        private string result()
        {
            Fraction rez = new Fraction();

            switch (operation)
            {
                case "+":
                    rez = fraction1 + fraction2;
                    break;

                case "-":
                    rez = fraction1 - fraction2;
                    break;

                case "*":
                    rez = fraction1 * fraction2;
                    break;

                case "÷":
                    rez = fraction1 / fraction2;
                    break;  
            }
            return rez;
        }

    }
}
