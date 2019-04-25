namespace DiscountManagerApp
{
    partial class DiscountManagerView
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblCalculatedValue = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(22, 24);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(22, 65);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(22, 110);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(34, 13);
            this.lblYears.TabIndex = 5;
            this.lblYears.Text = "Years";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbType.Location = new System.Drawing.Point(74, 62);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(100, 21);
            this.cmbType.TabIndex = 6;
            // 
            // lblCalculatedValue
            // 
            this.lblCalculatedValue.AutoSize = true;
            this.lblCalculatedValue.Location = new System.Drawing.Point(238, 64);
            this.lblCalculatedValue.Name = "lblCalculatedValue";
            this.lblCalculatedValue.Size = new System.Drawing.Size(86, 13);
            this.lblCalculatedValue.TabIndex = 7;
            this.lblCalculatedValue.Text = "Calculated value";
            // 
            // numPrice
            // 
            this.numPrice.Location = new System.Drawing.Point(74, 22);
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(100, 20);
            this.numPrice.TabIndex = 8;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // numYears
            // 
            this.numYears.Location = new System.Drawing.Point(74, 108);
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(100, 20);
            this.numYears.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiscountManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numYears);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.lblCalculatedValue);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAmount);
            this.Name = "DiscountManagerView";
            this.Text = "Discount manager";
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCalculatedValue;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.Button button1;
    }
}

