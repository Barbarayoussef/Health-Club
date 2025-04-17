using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Club
{
    public partial class frmain : Form
    {
        private decimal MonthlyFee=0;
        private decimal TotalFee=0;
        private int NumberOfMonths;
        public frmain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            MonthlyFee = 0;
            TotalFee = 0;

            if (radAdult.Checked || radChild.Checked || radSenior.Checked || radStudent.Checked)
            {
                if (radAdult.Checked)
                {
                    MonthlyFee += 40;
                }
                else if (radChild.Checked)
                {
                    MonthlyFee += 20;
                }
                else if (radStudent.Checked)
                {
                    MonthlyFee += 25;
                }
                else
                {
                    MonthlyFee += 30;
                }

                if (chkKarate.Checked)
                {
                    MonthlyFee += 30;
                }
                if (chkTrainer.Checked)
                {
                    MonthlyFee += 50;
                }
                if (chkYoga.Checked)
                {
                    MonthlyFee += 10;
                }
                if (txtMonths.Text == "" || !int.TryParse(txtMonths.Text, out NumberOfMonths))
                {
                    MessageBox.Show("Enter a number of months");
                }
                else
                {
                    lblMonthlyFee.Text = MonthlyFee.ToString("c");
                    TotalFee = MonthlyFee * NumberOfMonths;
                    lblTotalFee.Text = TotalFee.ToString("c");
                }
            }
            else
            {
                MessageBox.Show("You have to choose a type of membership");
            }
            
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            radAdult.Checked = false;
            radChild.Checked = false;
            radStudent.Checked = false;
            radSenior.Checked = false;
            chkKarate.Checked = false;
            chkTrainer.Checked = false;
            chkYoga.Checked = false;
            txtMonths.Text = "";
            lblMonthlyFee.Text = "";
            lblTotalFee.Text = "";
            MonthlyFee = 0;
            TotalFee = 0;
        }

        
    }

}
