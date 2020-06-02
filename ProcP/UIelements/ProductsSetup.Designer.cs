namespace ProcP.UIelements
{
	partial class ProductsSetup
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
            this.CBpossibleProds = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFillRack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurrentProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBpossibleProds
            // 
            this.CBpossibleProds.FormattingEnabled = true;
            this.CBpossibleProds.Location = new System.Drawing.Point(217, 56);
            this.CBpossibleProds.Name = "CBpossibleProds";
            this.CBpossibleProds.Size = new System.Drawing.Size(181, 24);
            this.CBpossibleProds.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Possible products to fill with:";
            // 
            // btnFillRack
            // 
            this.btnFillRack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnFillRack.Location = new System.Drawing.Point(27, 106);
            this.btnFillRack.Name = "btnFillRack";
            this.btnFillRack.Size = new System.Drawing.Size(371, 34);
            this.btnFillRack.TabIndex = 7;
            this.btnFillRack.Text = "Fill rack";
            this.btnFillRack.UseVisualStyleBackColor = false;
            this.btnFillRack.Click += new System.EventHandler(this.btnFillRack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current product on this rack:";
            // 
            // lblCurrentProd
            // 
            this.lblCurrentProd.AutoSize = true;
            this.lblCurrentProd.Location = new System.Drawing.Point(218, 10);
            this.lblCurrentProd.Name = "lblCurrentProd";
            this.lblCurrentProd.Size = new System.Drawing.Size(46, 17);
            this.lblCurrentProd.TabIndex = 9;
            this.lblCurrentProd.Text = "label3";
            // 
            // ProductsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 162);
            this.Controls.Add(this.lblCurrentProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFillRack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBpossibleProds);
            this.Name = "ProductsSetup";
            this.Text = "ProductsSetup";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.ComboBox CBpossibleProds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFillRack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentProd;
    }
}