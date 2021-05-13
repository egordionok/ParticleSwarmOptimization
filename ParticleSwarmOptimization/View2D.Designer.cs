namespace ParticleSwarmOptimization
{
    partial class View2D
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SS_button = new System.Windows.Forms.Button();
            this.numericUpDownOXmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOXmax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOYmin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownOYmax = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ParamButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RoyТumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionBox = new System.Windows.Forms.TextBox();
            this.DrawFButton = new System.Windows.Forms.Button();
            this.AnswerLable = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.GraficColor = new System.Windows.Forms.ToolStripMenuItem();
            this.PointsColor = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.aboutDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOXmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOXmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOYmax)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoyТumericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(269, 31);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(519, 382);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // SS_button
            // 
            this.SS_button.BackColor = System.Drawing.Color.Thistle;
            this.SS_button.Location = new System.Drawing.Point(18, 397);
            this.SS_button.Name = "SS_button";
            this.SS_button.Size = new System.Drawing.Size(118, 41);
            this.SS_button.TabIndex = 1;
            this.SS_button.Text = "Start/Stop";
            this.SS_button.UseVisualStyleBackColor = false;
            this.SS_button.Click += new System.EventHandler(this.SS_button_Click);
            // 
            // numericUpDownOXmin
            // 
            this.numericUpDownOXmin.Location = new System.Drawing.Point(6, 40);
            this.numericUpDownOXmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOXmin.Name = "numericUpDownOXmin";
            this.numericUpDownOXmin.Size = new System.Drawing.Size(46, 22);
            this.numericUpDownOXmin.TabIndex = 2;
            this.numericUpDownOXmin.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.numericUpDownOXmin.ValueChanged += new System.EventHandler(this.numericUpDownOXmin_ValueChanged);
            // 
            // numericUpDownOXmax
            // 
            this.numericUpDownOXmax.Location = new System.Drawing.Point(6, 68);
            this.numericUpDownOXmax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOXmax.Name = "numericUpDownOXmax";
            this.numericUpDownOXmax.Size = new System.Drawing.Size(46, 22);
            this.numericUpDownOXmax.TabIndex = 3;
            this.numericUpDownOXmax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownOXmax.ValueChanged += new System.EventHandler(this.numericUpDownOXmax_ValueChanged);
            // 
            // numericUpDownOYmin
            // 
            this.numericUpDownOYmin.Location = new System.Drawing.Point(6, 96);
            this.numericUpDownOYmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOYmin.Name = "numericUpDownOYmin";
            this.numericUpDownOYmin.Size = new System.Drawing.Size(46, 22);
            this.numericUpDownOYmin.TabIndex = 4;
            this.numericUpDownOYmin.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownOYmin.ValueChanged += new System.EventHandler(this.numericUpDownOYmin_ValueChanged);
            // 
            // numericUpDownOYmax
            // 
            this.numericUpDownOYmax.Location = new System.Drawing.Point(6, 124);
            this.numericUpDownOYmax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownOYmax.Name = "numericUpDownOYmax";
            this.numericUpDownOYmax.Size = new System.Drawing.Size(46, 22);
            this.numericUpDownOYmax.TabIndex = 5;
            this.numericUpDownOYmax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownOYmax.ValueChanged += new System.EventHandler(this.numericUpDownOYmax_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownOYmin);
            this.groupBox1.Controls.Add(this.numericUpDownOYmax);
            this.groupBox1.Controls.Add(this.numericUpDownOXmax);
            this.groupBox1.Controls.Add(this.numericUpDownOXmin);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 156);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки графика";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "OYmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "OYmin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "OXmax";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "OXmin";
            // 
            // ParamButton
            // 
            this.ParamButton.BackColor = System.Drawing.Color.Thistle;
            this.ParamButton.Location = new System.Drawing.Point(18, 345);
            this.ParamButton.Name = "ParamButton";
            this.ParamButton.Size = new System.Drawing.Size(118, 46);
            this.ParamButton.TabIndex = 7;
            this.ParamButton.Text = "Сгенерировать рой";
            this.ParamButton.UseVisualStyleBackColor = false;
            this.ParamButton.Click += new System.EventHandler(this.ParamButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "колл-во точек роя";
            // 
            // RoyТumericUpDown
            // 
            this.RoyТumericUpDown.Location = new System.Drawing.Point(12, 203);
            this.RoyТumericUpDown.Name = "RoyТumericUpDown";
            this.RoyТumericUpDown.Size = new System.Drawing.Size(46, 22);
            this.RoyТumericUpDown.TabIndex = 10;
            this.RoyТumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RoyТumericUpDown.ValueChanged += new System.EventHandler(this.RoyТumericUpDown_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.algoritmToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutDeveloper});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(81, 26);
            this.toolStripMenuItem1.Text = "Справка";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // algoritmToolStripMenuItem
            // 
            this.algoritmToolStripMenuItem.Name = "algoritmToolStripMenuItem";
            this.algoritmToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.algoritmToolStripMenuItem.Text = "Алгоритм";
            this.algoritmToolStripMenuItem.Click += new System.EventHandler(this.algoritmToolStripMenuItem_Click);
            // 
            // functionBox
            // 
            this.functionBox.Location = new System.Drawing.Point(64, 249);
            this.functionBox.Name = "functionBox";
            this.functionBox.Size = new System.Drawing.Size(192, 22);
            this.functionBox.TabIndex = 13;
            this.functionBox.Text = "x*x*exp(x) + 1";
            // 
            // DrawFButton
            // 
            this.DrawFButton.BackColor = System.Drawing.Color.Thistle;
            this.DrawFButton.Location = new System.Drawing.Point(18, 293);
            this.DrawFButton.Name = "DrawFButton";
            this.DrawFButton.Size = new System.Drawing.Size(118, 46);
            this.DrawFButton.TabIndex = 14;
            this.DrawFButton.Text = "Нарисовать график";
            this.DrawFButton.UseVisualStyleBackColor = false;
            this.DrawFButton.Click += new System.EventHandler(this.DrawFButton_Click);
            // 
            // AnswerLable
            // 
            this.AnswerLable.AutoSize = true;
            this.AnswerLable.Location = new System.Drawing.Point(266, 424);
            this.AnswerLable.Name = "AnswerLable";
            this.AnswerLable.Size = new System.Drawing.Size(130, 17);
            this.AnswerLable.TabIndex = 15;
            this.AnswerLable.Text = "Точка минимума:  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "f(x) =";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GraficColor,
            this.PointsColor});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 26);
            this.toolStripMenuItem2.Text = "Настройки";
            // 
            // GraficColor
            // 
            this.GraficColor.Name = "GraficColor";
            this.GraficColor.Size = new System.Drawing.Size(224, 26);
            this.GraficColor.Text = "Цвет графика";
            this.GraficColor.Click += new System.EventHandler(this.GraficColor_Click);
            // 
            // PointsColor
            // 
            this.PointsColor.Name = "PointsColor";
            this.PointsColor.Size = new System.Drawing.Size(224, 26);
            this.PointsColor.Text = "Цвет точек";
            this.PointsColor.Click += new System.EventHandler(this.PointsColor_Click);
            // 
            // aboutDeveloper
            // 
            this.aboutDeveloper.Name = "aboutDeveloper";
            this.aboutDeveloper.Size = new System.Drawing.Size(135, 26);
            this.aboutDeveloper.Text = "О разработчике";
            this.aboutDeveloper.Click += new System.EventHandler(this.aboutDeveloper_Click);
            // 
            // View2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnswerLable);
            this.Controls.Add(this.DrawFButton);
            this.Controls.Add(this.functionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoyТumericUpDown);
            this.Controls.Add(this.ParamButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SS_button);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label6);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "View2D";
            this.Text = "Particle Swarm Optimization";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOXmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOXmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOYmax)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RoyТumericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button SS_button;
        private System.Windows.Forms.NumericUpDown numericUpDownOXmin;
        private System.Windows.Forms.NumericUpDown numericUpDownOXmax;
        private System.Windows.Forms.NumericUpDown numericUpDownOYmin;
        private System.Windows.Forms.NumericUpDown numericUpDownOYmax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ParamButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown RoyТumericUpDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem algoritmToolStripMenuItem;
        private System.Windows.Forms.TextBox functionBox;
        private System.Windows.Forms.Button DrawFButton;
        private System.Windows.Forms.Label AnswerLable;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem GraficColor;
        private System.Windows.Forms.ToolStripMenuItem PointsColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem aboutDeveloper;
    }
}