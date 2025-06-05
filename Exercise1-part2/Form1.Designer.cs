using System;

namespace Exercise1_part2
{
    partial class Form1
   
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblCostPerSqFt = new System.Windows.Forms.Label();
            this.txtCostPerSqFoot = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblDivider = new System.Windows.Forms.Label();
            this.LblTotalFloorCost = new System.Windows.Forms.Label();
            this.lblInstallationHours = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(195, 51);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(116, 20);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length of floor:";
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(195, 108);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(107, 20);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width of floor:";
            // 
            // lblCostPerSqFt
            // 
            this.lblCostPerSqFt.AutoSize = true;
            this.lblCostPerSqFt.Location = new System.Drawing.Point(195, 165);
            this.lblCostPerSqFt.Name = "lblCostPerSqFt";
            this.lblCostPerSqFt.Size = new System.Drawing.Size(158, 20);
            this.lblCostPerSqFt.TabIndex = 2;
            this.lblCostPerSqFt.Text = "Cost per square foot:";
            // 
            // txtCostPerSqFoot
            // 
            this.txtCostPerSqFoot.Location = new System.Drawing.Point(380, 165);
            this.txtCostPerSqFoot.Name = "txtCostPerSqFoot";
            this.txtCostPerSqFoot.Size = new System.Drawing.Size(100, 26);
            this.txtCostPerSqFoot.TabIndex = 3;
            this.txtCostPerSqFoot.TextChanged += new System.EventHandler(this.txtCostPerSqFoot_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(380, 108);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 26);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(380, 51);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 26);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // lblDivider
            // 
            this.lblDivider.AutoSize = true;
            this.lblDivider.Location = new System.Drawing.Point(195, 220);
            this.lblDivider.Name = "lblDivider";
            this.lblDivider.Size = new System.Drawing.Size(179, 20);
            this.lblDivider.TabIndex = 6;
            this.lblDivider.Text = "----------------------------------";
            this.lblDivider.Click += new System.EventHandler(this.lblDivider_Click);
            // 
            // LblTotalFloorCost
            // 
            this.LblTotalFloorCost.AutoSize = true;
            this.LblTotalFloorCost.Location = new System.Drawing.Point(216, 260);
            this.LblTotalFloorCost.Name = "LblTotalFloorCost";
            this.LblTotalFloorCost.Size = new System.Drawing.Size(179, 20);
            this.LblTotalFloorCost.TabIndex = 7;
            this.LblTotalFloorCost.Text = "Cost of total floor size: $";
            this.LblTotalFloorCost.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblInstallationHours
            // 
            this.lblInstallationHours.AutoSize = true;
            this.lblInstallationHours.Location = new System.Drawing.Point(216, 311);
            this.lblInstallationHours.Name = "lblInstallationHours";
            this.lblInstallationHours.Size = new System.Drawing.Size(268, 20);
            this.lblInstallationHours.TabIndex = 8;
            this.lblInstallationHours.Text = "Number of hours to install the floor: $";
            this.lblInstallationHours.Click += new System.EventHandler(this.lblInstallationHours_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(206, 352);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(314, 20);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "The total finished cost for the new floor is: $";
            this.lblGrandTotal.Click += new System.EventHandler(this.lblGrandTotal_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(298, 398);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(136, 40);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 40);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblInstallationHours);
            this.Controls.Add(this.LblTotalFloorCost);
            this.Controls.Add(this.lblDivider);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtCostPerSqFoot);
            this.Controls.Add(this.lblCostPerSqFt);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblDivider_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblCostPerSqFt;
        private System.Windows.Forms.TextBox txtCostPerSqFoot;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblDivider;
        private System.Windows.Forms.Label LblTotalFloorCost;
        private System.Windows.Forms.Label lblInstallationHours;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private EventHandler lblLength_Click;
        private EventHandler label4_Click;
    }
}

