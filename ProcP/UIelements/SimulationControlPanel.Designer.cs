namespace ProcP.UIelements
{
    partial class SimulationControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPauseSimulation = new System.Windows.Forms.Button();
            this.btnStopSimulation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonChairs = new System.Windows.Forms.Button();
            this.buttonSofas = new System.Windows.Forms.Button();
            this.buttonTables = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPauseSimulation
            // 
            this.btnPauseSimulation.BackColor = System.Drawing.Color.PowderBlue;
            this.btnPauseSimulation.Location = new System.Drawing.Point(14, 502);
            this.btnPauseSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnPauseSimulation.Name = "btnPauseSimulation";
            this.btnPauseSimulation.Size = new System.Drawing.Size(260, 45);
            this.btnPauseSimulation.TabIndex = 0;
            this.btnPauseSimulation.Text = "Pause Simulation";
            this.btnPauseSimulation.UseVisualStyleBackColor = false;
            // 
            // btnStopSimulation
            // 
            this.btnStopSimulation.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopSimulation.Location = new System.Drawing.Point(14, 555);
            this.btnStopSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopSimulation.Name = "btnStopSimulation";
            this.btnStopSimulation.Size = new System.Drawing.Size(260, 45);
            this.btnStopSimulation.TabIndex = 1;
            this.btnStopSimulation.Text = "Stop Simulation";
            this.btnStopSimulation.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(15, 52);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(135, 244);
            this.listBox1.TabIndex = 3;
            // 
            // buttonChairs
            // 
            this.buttonChairs.Location = new System.Drawing.Point(154, 52);
            this.buttonChairs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChairs.Name = "buttonChairs";
            this.buttonChairs.Size = new System.Drawing.Size(120, 42);
            this.buttonChairs.TabIndex = 4;
            this.buttonChairs.Text = "Fill with chairs";
            this.buttonChairs.UseVisualStyleBackColor = true;
            this.buttonChairs.Click += new System.EventHandler(this.buttonChairs_Click);
            // 
            // buttonSofas
            // 
            this.buttonSofas.Location = new System.Drawing.Point(154, 98);
            this.buttonSofas.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSofas.Name = "buttonSofas";
            this.buttonSofas.Size = new System.Drawing.Size(120, 41);
            this.buttonSofas.TabIndex = 5;
            this.buttonSofas.Text = "Fill with sofas";
            this.buttonSofas.UseVisualStyleBackColor = true;
            this.buttonSofas.Click += new System.EventHandler(this.buttonSofas_Click);
            // 
            // buttonTables
            // 
            this.buttonTables.Location = new System.Drawing.Point(154, 143);
            this.buttonTables.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTables.Name = "buttonTables";
            this.buttonTables.Size = new System.Drawing.Size(120, 41);
            this.buttonTables.TabIndex = 6;
            this.buttonTables.Text = "Fill with tables";
            this.buttonTables.UseVisualStyleBackColor = true;
            this.buttonTables.Click += new System.EventHandler(this.buttonTables_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnShowList.Location = new System.Drawing.Point(14, 302);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(135, 44);
            this.btnShowList.TabIndex = 7;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Empty Racks";
            // 
            // SimulationControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.buttonTables);
            this.Controls.Add(this.buttonSofas);
            this.Controls.Add(this.buttonChairs);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStopSimulation);
            this.Controls.Add(this.btnPauseSimulation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimulationControlPanel";
            this.Size = new System.Drawing.Size(290, 772);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPauseSimulation;
        private System.Windows.Forms.Button btnStopSimulation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonChairs;
        private System.Windows.Forms.Button buttonSofas;
        private System.Windows.Forms.Button buttonTables;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Label label1;
    }
}
