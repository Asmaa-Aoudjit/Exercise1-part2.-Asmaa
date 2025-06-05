using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1_part2
{
    public partial class Form1 : Form
    {
        private const double INSTALLATION_COST_PER_HOUR = 35.75;
        private const double SQ_FT_PER_HOUR = 40.0;
        private object txtCostPerSqFt;
        private object totalInstallationCost;
        private object totalHours;
        private object grandTotal;
        private object totalFlooringCost;
        private object totalSquareFeet;
       

        public string lblTotalFloorCostt { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {

        }

        private object GetTxtCostPerSqFt()
        {
            return txtCostPerSqFt;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int length = int.Parse(txtLength.Text);
            int width = int.Parse(txtWidth.Text);
            double costPerSqFt = double.Parse(this.txtCostPerSqFoot.Text);

            // Calculate total area
            int totalSquareFeet = length * width;

            // Calculate costs
            double totalFlooringCost = totalSquareFeet * costPerSqFt;
            double totalHours = totalSquareFeet / SQ_FT_PER_HOUR;
            double totalInstallationCost = totalHours * INSTALLATION_COST_PER_HOUR;
            double grandTotal = totalFlooringCost + totalInstallationCost;

            LblTotalFloorCost.Text = $"Cost of total floor size of {totalSquareFeet}: {totalFlooringCost:C}";
            lblInstallationHours.Text = $"Number of hours to install the floor: {totalHours:F2}  At a cost of {totalInstallationCost:C}";
            lblGrandTotal.Text = $"The total finished cost for the new floor is: {grandTotal:C}";



        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();     
        }
        

        

        private void txtCostPerSqFoot_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInstallationHours_Click(object sender, EventArgs e)
        {
           
        }

       

        private void lblGrandTotal_Click(object sender, EventArgs e)
        {
          
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
