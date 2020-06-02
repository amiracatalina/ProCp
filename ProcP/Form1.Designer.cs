namespace ProcP
{
	partial class iBlade
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
            this.components = new System.ComponentModel.Container();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.simulationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehouseSpecificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderSimulationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWSchange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartSim = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainSettings = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AGVtimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTimeLine = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.TabPageSimulation = new System.Windows.Forms.TabPage();
            this.TabPageOrderSettings = new System.Windows.Forms.TabPage();
            this.OrderListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.OrderLIstButtonPanel = new System.Windows.Forms.Panel();
            this.btnSaveOrders = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.TabPageStatistics = new System.Windows.Forms.TabPage();
            this.TabControlSettings = new System.Windows.Forms.TabControl();
            this.TabPageSettingsMain = new System.Windows.Forms.TabPage();
            this.TabPageDuringSimulation = new System.Windows.Forms.TabPage();
            this.TimeLineTimer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.panelMainSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.TabPageSimulation.SuspendLayout();
            this.TabPageOrderSettings.SuspendLayout();
            this.OrderListPanel.SuspendLayout();
            this.OrderLIstButtonPanel.SuspendLayout();
            this.TabControlSettings.SuspendLayout();
            this.TabPageSettingsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simulationToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(1576, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // simulationToolStripMenuItem
            // 
            this.simulationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.warehouseSpecificationsToolStripMenuItem,
            this.orderSimulationDataToolStripMenuItem});
            this.simulationToolStripMenuItem.Name = "simulationToolStripMenuItem";
            this.simulationToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.simulationToolStripMenuItem.Text = "Simulation";
            // 
            // warehouseSpecificationsToolStripMenuItem
            // 
            this.warehouseSpecificationsToolStripMenuItem.Name = "warehouseSpecificationsToolStripMenuItem";
            this.warehouseSpecificationsToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.warehouseSpecificationsToolStripMenuItem.Text = "Warehouse Specifications";
            this.warehouseSpecificationsToolStripMenuItem.Click += new System.EventHandler(this.warehouseSpecificationsToolStripMenuItem_Click);
            // 
            // orderSimulationDataToolStripMenuItem
            // 
            this.orderSimulationDataToolStripMenuItem.Name = "orderSimulationDataToolStripMenuItem";
            this.orderSimulationDataToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.orderSimulationDataToolStripMenuItem.Text = "Order Simulation Data";
            this.orderSimulationDataToolStripMenuItem.Click += new System.EventHandler(this.orderSimulationDataToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyDataToolStripMenuItem,
            this.comparisonToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // historyDataToolStripMenuItem
            // 
            this.historyDataToolStripMenuItem.Name = "historyDataToolStripMenuItem";
            this.historyDataToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.historyDataToolStripMenuItem.Text = "History data";
            this.historyDataToolStripMenuItem.Click += new System.EventHandler(this.historyDataToolStripMenuItem_Click);
            // 
            // comparisonToolStripMenuItem
            // 
            this.comparisonToolStripMenuItem.Name = "comparisonToolStripMenuItem";
            this.comparisonToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.comparisonToolStripMenuItem.Text = "Comparison";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Warehouse Specifications";
            // 
            // btnWSchange
            // 
            this.btnWSchange.BackColor = System.Drawing.Color.PowderBlue;
            this.btnWSchange.Location = new System.Drawing.Point(17, 65);
            this.btnWSchange.Margin = new System.Windows.Forms.Padding(4);
            this.btnWSchange.Name = "btnWSchange";
            this.btnWSchange.Size = new System.Drawing.Size(280, 55);
            this.btnWSchange.TabIndex = 6;
            this.btnWSchange.Text = "Change";
            this.btnWSchange.UseVisualStyleBackColor = false;
            this.btnWSchange.Click += new System.EventHandler(this.btnWSchange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Settings";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.PowderBlue;
            this.btnUpload.Location = new System.Drawing.Point(167, 201);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(133, 55);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload File";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // btnStartSim
            // 
            this.btnStartSim.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnStartSim.Location = new System.Drawing.Point(19, 543);
            this.btnStartSim.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartSim.Name = "btnStartSim";
            this.btnStartSim.Size = new System.Drawing.Size(285, 55);
            this.btnStartSim.TabIndex = 13;
            this.btnStartSim.Text = "START SIMULATION";
            this.btnStartSim.UseVisualStyleBackColor = false;
            this.btnStartSim.Click += new System.EventHandler(this.btnStartSim_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSet.Location = new System.Drawing.Point(17, 201);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(132, 55);
            this.btnSet.TabIndex = 14;
            this.btnSet.Text = "Set Orders";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(20, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 2);
            this.label4.TabIndex = 16;
            // 
            // panelMainSettings
            // 
            this.panelMainSettings.Controls.Add(this.comboBox1);
            this.panelMainSettings.Controls.Add(this.label6);
            this.panelMainSettings.Controls.Add(this.label5);
            this.panelMainSettings.Controls.Add(this.label4);
            this.panelMainSettings.Controls.Add(this.btnSet);
            this.panelMainSettings.Controls.Add(this.btnStartSim);
            this.panelMainSettings.Controls.Add(this.label3);
            this.panelMainSettings.Controls.Add(this.btnUpload);
            this.panelMainSettings.Controls.Add(this.label2);
            this.panelMainSettings.Controls.Add(this.btnWSchange);
            this.panelMainSettings.Controls.Add(this.label1);
            this.panelMainSettings.Location = new System.Drawing.Point(4, 5);
            this.panelMainSettings.Margin = new System.Windows.Forms.Padding(4);
            this.panelMainSettings.Name = "panelMainSettings";
            this.panelMainSettings.Size = new System.Drawing.Size(323, 839);
            this.panelMainSettings.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 364);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 310);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Test data for first iteration:";
            // 
            // AGVtimer
            // 
            this.AGVtimer.Interval = 1000;
            this.AGVtimer.Tick += new System.EventHandler(this.AGVtimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTimeLine
            // 
            this.pbTimeLine.Location = new System.Drawing.Point(3, 4);
            this.pbTimeLine.Margin = new System.Windows.Forms.Padding(4);
            this.pbTimeLine.Name = "pbTimeLine";
            this.pbTimeLine.Size = new System.Drawing.Size(1198, 57);
            this.pbTimeLine.TabIndex = 12;
            this.pbTimeLine.TabStop = false;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.Location = new System.Drawing.Point(4, 69);
            this.pbMain.Margin = new System.Windows.Forms.Padding(4);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(700, 600);
            this.pbMain.TabIndex = 11;
            this.pbMain.TabStop = false;
            this.pbMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMain_Paint);
            this.pbMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMain_MouseUp);
            // 
            // TabControlMain
            // 
            this.TabControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlMain.Controls.Add(this.TabPageSimulation);
            this.TabControlMain.Controls.Add(this.TabPageOrderSettings);
            this.TabControlMain.Controls.Add(this.TabPageStatistics);
            this.TabControlMain.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControlMain.Location = new System.Drawing.Point(340, 33);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1224, 877);
            this.TabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlMain.TabIndex = 4;
            // 
            // TabPageSimulation
            // 
            this.TabPageSimulation.Controls.Add(this.pbTimeLine);
            this.TabPageSimulation.Controls.Add(this.pbMain);
            this.TabPageSimulation.Location = new System.Drawing.Point(4, 5);
            this.TabPageSimulation.Name = "TabPageSimulation";
            this.TabPageSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSimulation.Size = new System.Drawing.Size(1216, 868);
            this.TabPageSimulation.TabIndex = 1;
            this.TabPageSimulation.UseVisualStyleBackColor = true;
            // 
            // TabPageOrderSettings
            // 
            this.TabPageOrderSettings.AutoScroll = true;
            this.TabPageOrderSettings.Controls.Add(this.OrderListPanel);
            this.TabPageOrderSettings.Controls.Add(this.OrderLIstButtonPanel);
            this.TabPageOrderSettings.Location = new System.Drawing.Point(4, 5);
            this.TabPageOrderSettings.Name = "TabPageOrderSettings";
            this.TabPageOrderSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageOrderSettings.Size = new System.Drawing.Size(1216, 868);
            this.TabPageOrderSettings.TabIndex = 0;
            this.TabPageOrderSettings.UseVisualStyleBackColor = true;
            // 
            // OrderListPanel
            // 
            this.OrderListPanel.AllowDrop = true;
            this.OrderListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderListPanel.AutoScroll = true;
            this.OrderListPanel.Controls.Add(this.listBoxOrders);
            this.OrderListPanel.Location = new System.Drawing.Point(0, 0);
            this.OrderListPanel.MaximumSize = new System.Drawing.Size(1200, 720);
            this.OrderListPanel.Name = "OrderListPanel";
            this.OrderListPanel.Size = new System.Drawing.Size(1152, 720);
            this.OrderListPanel.TabIndex = 4;
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.Location = new System.Drawing.Point(3, 3);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(175, 225);
            this.listBoxOrders.TabIndex = 0;
            // 
            // OrderLIstButtonPanel
            // 
            this.OrderLIstButtonPanel.Controls.Add(this.btnSaveOrders);
            this.OrderLIstButtonPanel.Controls.Add(this.btnCancel);
            this.OrderLIstButtonPanel.Controls.Add(this.btnSaveToFile);
            this.OrderLIstButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderLIstButtonPanel.Location = new System.Drawing.Point(3, 730);
            this.OrderLIstButtonPanel.Name = "OrderLIstButtonPanel";
            this.OrderLIstButtonPanel.Size = new System.Drawing.Size(1210, 135);
            this.OrderLIstButtonPanel.TabIndex = 6;
            // 
            // btnSaveOrders
            // 
            this.btnSaveOrders.Location = new System.Drawing.Point(850, 16);
            this.btnSaveOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveOrders.Name = "btnSaveOrders";
            this.btnSaveOrders.Size = new System.Drawing.Size(262, 44);
            this.btnSaveOrders.TabIndex = 1;
            this.btnSaveOrders.Text = "Save Orders";
            this.btnSaveOrders.UseVisualStyleBackColor = true;
            this.btnSaveOrders.Click += new System.EventHandler(this.btnSaveOrders_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 17);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(268, 43);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(84, 17);
            this.btnSaveToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(281, 43);
            this.btnSaveToFile.TabIndex = 3;
            this.btnSaveToFile.Text = "Save to file";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // TabPageStatistics
            // 
            this.TabPageStatistics.Location = new System.Drawing.Point(4, 5);
            this.TabPageStatistics.Name = "TabPageStatistics";
            this.TabPageStatistics.Size = new System.Drawing.Size(1216, 868);
            this.TabPageStatistics.TabIndex = 2;
            this.TabPageStatistics.Text = "TabPageStatistics";
            this.TabPageStatistics.UseVisualStyleBackColor = true;
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControlSettings.Controls.Add(this.TabPageSettingsMain);
            this.TabControlSettings.Controls.Add(this.TabPageDuringSimulation);
            this.TabControlSettings.ItemSize = new System.Drawing.Size(0, 1);
            this.TabControlSettings.Location = new System.Drawing.Point(6, 33);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedIndex = 0;
            this.TabControlSettings.Size = new System.Drawing.Size(338, 877);
            this.TabControlSettings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControlSettings.TabIndex = 18;
            // 
            // TabPageSettingsMain
            // 
            this.TabPageSettingsMain.Controls.Add(this.panelMainSettings);
            this.TabPageSettingsMain.Location = new System.Drawing.Point(4, 5);
            this.TabPageSettingsMain.Name = "TabPageSettingsMain";
            this.TabPageSettingsMain.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSettingsMain.Size = new System.Drawing.Size(330, 868);
            this.TabPageSettingsMain.TabIndex = 0;
            this.TabPageSettingsMain.UseVisualStyleBackColor = true;
            // 
            // TabPageDuringSimulation
            // 
            this.TabPageDuringSimulation.Location = new System.Drawing.Point(4, 5);
            this.TabPageDuringSimulation.Name = "TabPageDuringSimulation";
            this.TabPageDuringSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageDuringSimulation.Size = new System.Drawing.Size(330, 868);
            this.TabPageDuringSimulation.TabIndex = 1;
            this.TabPageDuringSimulation.UseVisualStyleBackColor = true;
            // 
            // TimeLineTimer
            // 
            this.TimeLineTimer.Interval = 2000;
            this.TimeLineTimer.Tick += new System.EventHandler(this.TimeLineTimer_Tick);
            // 
            // iBlade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1576, 927);
            this.Controls.Add(this.TabControlSettings);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.TabControlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "iBlade";
            this.Text = "iBlade Warehouse Simulation";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.panelMainSettings.ResumeLayout(false);
            this.panelMainSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.TabPageSimulation.ResumeLayout(false);
            this.TabPageOrderSettings.ResumeLayout(false);
            this.OrderListPanel.ResumeLayout(false);
            this.OrderLIstButtonPanel.ResumeLayout(false);
            this.TabControlSettings.ResumeLayout(false);
            this.TabPageSettingsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem simulationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWSchange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.PictureBox pbTimeLine;
        private System.Windows.Forms.Button btnStartSim;
        private System.Windows.Forms.ToolStripMenuItem warehouseSpecificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderSimulationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparisonToolStripMenuItem;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveOrders;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMainSettings;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer AGVtimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage TabPageOrderSettings;
        private System.Windows.Forms.TabPage TabPageSimulation;
        private System.Windows.Forms.TabControl TabControlSettings;
        private System.Windows.Forms.TabPage TabPageSettingsMain;
        private System.Windows.Forms.TabPage TabPageDuringSimulation;
        private UIelements.SimulationControlPanel duringSimPanel;
        private System.Windows.Forms.FlowLayoutPanel OrderListPanel;
        private System.Windows.Forms.Panel OrderLIstButtonPanel;
        private UIelements.SimulationControlPanel simControlPanel;
        private System.Windows.Forms.TabPage TabPageStatistics;
        private System.Windows.Forms.Timer TimeLineTimer;
        private System.Windows.Forms.ListBox listBoxOrders;
    }
}

