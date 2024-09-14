using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_scabrats
{
    public partial class frmScabrats : Form
    {
        public frmScabrats()
        {
            InitializeComponent();
        }


        // Initialize Fees

        const int membershipDiscount = 50;
        const int toGoFee = 10;
        const double ptsPerTransactionIfMember = 0.03;


        // Initialize var to be used globally

        double currTotal = 0;


        // hold Total ng isang Order
        double totalCream = 0;
        double totalSalted = 0;
        double totalVanilla = 0;
        double totalBurnt = 0;
        double totalHot = 0;
        double totalIced = 0;
        double totalGreen = 0;
        double totalJava = 0;


        //// hold numValue ng isang Order
        //double numValueCream = 0;
        //double numValueSalted = 0;
        //double numValueVanilla = 0;
        //double numValueBurnt = 0;
        //double numValueHot = 0;
        //double numValueIced = 0;
        //double numValueJava = 0;





        private void frmScabrats_Load(object sender, EventArgs e)
        {
            numCream.Enabled = false;
            numSalted.Enabled = false;
            numVanilla.Enabled = false;
            numBurnt.Enabled = false;
            numHot.Enabled = false;
            numIced.Enabled = false;
            numGreen.Enabled = false;
            numJava.Enabled = false;
        }


        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {


            currTotal = totalCream + totalSalted + totalVanilla + totalBurnt + totalHot + totalIced + totalGreen + totalJava;


            lblTotal.Text = "Total: " + currTotal;
            

        }



        private void chkCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCream.Checked)
            {
                numCream.Enabled = true;
            }
            else
            {
                numCream.Enabled = false;
                numCream.Value = 0;
            }
        }

        private void chkSalted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSalted.Checked)
            {
                numSalted.Enabled = true;
            }
            else
            {
                numSalted.Enabled = false;
                numSalted.Value = 0;
            }
        }

        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanilla.Checked)
            {
                numVanilla.Enabled = true;
            }
            else
            {
                numVanilla.Enabled = false;
                numVanilla.Value = 0;
            }
        }

        private void chkBurnt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurnt.Checked)
            {
                numBurnt.Enabled = true;
            }
            else
            {
                numBurnt.Enabled = false;
                numBurnt.Value = 0;
            }
        }

        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHot.Checked)
            {
                numHot.Enabled = true;
            }
            else
            {
                numHot.Enabled = false;
                numHot.Value = 0;
            }
        }

        private void chkIced_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIced.Checked)
            {
                numIced.Enabled = true;
            }
            else
            {
                numIced.Enabled = false;
                numIced.Value = 0;
            }
        }

        private void chkGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGreen.Checked)
            {
                numGreen.Enabled = true;
            }
            else
            {
                numGreen.Enabled = false;
                numGreen.Value = 0;
            }
        }

        private void chkJava_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJava.Checked)
            {
                numJava.Enabled = true;
            }
            else
            {
                numJava.Enabled = false;
                numJava.Value = 0;
            }
        }

        private void numCream_ValueChanged(object sender, EventArgs e)
        {
            totalCream = (int)numCream.Value * 120;
        }

        private void numSalted_ValueChanged(object sender, EventArgs e)
        {
            totalSalted = (int)numSalted.Value * 110;
        }

        private void numVanilla_ValueChanged(object sender, EventArgs e)
        {
            totalVanilla = (int)numVanilla.Value * 125;
        }

        private void numBurnt_ValueChanged(object sender, EventArgs e)
        {
            totalBurnt = (int)numBurnt.Value * 150;
        }

        private void numHot_ValueChanged(object sender, EventArgs e)
        {
            totalHot = (int)numHot.Value * 90;
        }

        private void numIced_ValueChanged(object sender, EventArgs e)
        {
            totalIced = (int)numIced.Value * 135;
        }

        private void numGreen_ValueChanged(object sender, EventArgs e)
        {
            totalGreen = (int)numGreen.Value * 155;
        }

        private void numJava_ValueChanged(object sender, EventArgs e)
        {
            totalJava = (int)numJava.Value * 162;
        }
    }
}
