namespace Tyuiu.DanilovAS.Sprint6.Task4.V2
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelTask_DAS = new Panel();
            buttonDone_DAS = new Button();
            buttonSaveFile_DAS = new Button();
            buttonHelp_DAS = new Button();
            groupBoxTask_DAS = new GroupBox();
            labelTask_DAS = new Label();
            labelStopStep_DAS = new Label();
            labelStartStep_DAS = new Label();
            textBoxStopValue_DAS = new TextBox();
            textBoxStartValue_DAS = new TextBox();
            panelResultChart_DAS = new Panel();
            chartFunction_DAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelResultDataGridView_DAS = new Panel();
            groupBoxResult_DAS = new GroupBox();
            textBoxResult_DAS = new TextBox();
            panelTask_DAS.SuspendLayout();
            groupBoxTask_DAS.SuspendLayout();
            panelResultChart_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_DAS).BeginInit();
            panelResultDataGridView_DAS.SuspendLayout();
            groupBoxResult_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_DAS
            // 
            panelTask_DAS.BackColor = SystemColors.Control;
            panelTask_DAS.Controls.Add(buttonDone_DAS);
            panelTask_DAS.Controls.Add(buttonSaveFile_DAS);
            panelTask_DAS.Controls.Add(buttonHelp_DAS);
            panelTask_DAS.Controls.Add(groupBoxTask_DAS);
            panelTask_DAS.Dock = DockStyle.Top;
            panelTask_DAS.Location = new Point(0, 0);
            panelTask_DAS.Name = "panelTask_DAS";
            panelTask_DAS.Size = new Size(982, 98);
            panelTask_DAS.TabIndex = 0;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.BackColor = Color.Lime;
            buttonDone_DAS.Location = new Point(647, 16);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(156, 62);
            buttonDone_DAS.TabIndex = 3;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = false;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // buttonSaveFile_DAS
            // 
            buttonSaveFile_DAS.BackColor = Color.Turquoise;
            buttonSaveFile_DAS.Location = new Point(809, 16);
            buttonSaveFile_DAS.Name = "buttonSaveFile_DAS";
            buttonSaveFile_DAS.Size = new Size(93, 62);
            buttonSaveFile_DAS.TabIndex = 2;
            buttonSaveFile_DAS.Text = "Сохранить";
            buttonSaveFile_DAS.UseVisualStyleBackColor = false;
            buttonSaveFile_DAS.Click += buttonSaveFile_DAS_Click;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DAS.BackColor = Color.Cyan;
            buttonHelp_DAS.Location = new Point(908, 16);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(62, 62);
            buttonHelp_DAS.TabIndex = 1;
            buttonHelp_DAS.Text = "?";
            buttonHelp_DAS.UseVisualStyleBackColor = false;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTask_DAS);
            groupBoxTask_DAS.Controls.Add(labelStopStep_DAS);
            groupBoxTask_DAS.Controls.Add(labelStartStep_DAS);
            groupBoxTask_DAS.Controls.Add(textBoxStopValue_DAS);
            groupBoxTask_DAS.Controls.Add(textBoxStartValue_DAS);
            groupBoxTask_DAS.Location = new Point(4, 3);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(637, 89);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTask_DAS
            // 
            labelTask_DAS.Location = new Point(6, 23);
            labelTask_DAS.Name = "labelTask_DAS";
            labelTask_DAS.Size = new Size(368, 66);
            labelTask_DAS.TabIndex = 4;
            labelTask_DAS.Text = "Написать программу, которая выводит\r\nтаблицу значений функции на заданном\r\nдиапазоне [-5;5] с шагом 1.\r\n\r\n\r\n\r\n";
            // 
            // labelStopStep_DAS
            // 
            labelStopStep_DAS.AutoSize = true;
            labelStopStep_DAS.Location = new Point(506, 33);
            labelStopStep_DAS.Name = "labelStopStep_DAS";
            labelStopStep_DAS.Size = new Size(83, 20);
            labelStopStep_DAS.TabIndex = 3;
            labelStopStep_DAS.Text = "Стоп шага:";
            // 
            // labelStartStep_DAS
            // 
            labelStartStep_DAS.AutoSize = true;
            labelStartStep_DAS.Location = new Point(375, 33);
            labelStartStep_DAS.Name = "labelStartStep_DAS";
            labelStartStep_DAS.Size = new Size(88, 20);
            labelStartStep_DAS.TabIndex = 2;
            labelStartStep_DAS.Text = "Старт шага:";
            // 
            // textBoxStopValue_DAS
            // 
            textBoxStopValue_DAS.Location = new Point(506, 56);
            textBoxStopValue_DAS.Name = "textBoxStopValue_DAS";
            textBoxStopValue_DAS.Size = new Size(125, 27);
            textBoxStopValue_DAS.TabIndex = 1;
            textBoxStopValue_DAS.KeyPress += textBoxStopValue_DAS_KeyPress;
            // 
            // textBoxStartValue_DAS
            // 
            textBoxStartValue_DAS.Location = new Point(375, 56);
            textBoxStartValue_DAS.Name = "textBoxStartValue_DAS";
            textBoxStartValue_DAS.Size = new Size(125, 27);
            textBoxStartValue_DAS.TabIndex = 0;
            textBoxStartValue_DAS.KeyPress += textBoxStartValue_DAS_KeyPress;
            // 
            // panelResultChart_DAS
            // 
            panelResultChart_DAS.BackColor = SystemColors.Control;
            panelResultChart_DAS.Controls.Add(chartFunction_DAS);
            panelResultChart_DAS.Location = new Point(250, 98);
            panelResultChart_DAS.Name = "panelResultChart_DAS";
            panelResultChart_DAS.Size = new Size(732, 355);
            panelResultChart_DAS.TabIndex = 0;
            // 
            // chartFunction_DAS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_DAS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_DAS.Legends.Add(legend1);
            chartFunction_DAS.Location = new Point(21, 6);
            chartFunction_DAS.Name = "chartFunction_DAS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_DAS.Series.Add(series1);
            chartFunction_DAS.Size = new Size(699, 337);
            chartFunction_DAS.TabIndex = 0;
            chartFunction_DAS.Text = "chart1";
            // 
            // panelResultDataGridView_DAS
            // 
            panelResultDataGridView_DAS.BackColor = SystemColors.Control;
            panelResultDataGridView_DAS.Controls.Add(groupBoxResult_DAS);
            panelResultDataGridView_DAS.Dock = DockStyle.Left;
            panelResultDataGridView_DAS.Location = new Point(0, 98);
            panelResultDataGridView_DAS.Name = "panelResultDataGridView_DAS";
            panelResultDataGridView_DAS.Size = new Size(250, 355);
            panelResultDataGridView_DAS.TabIndex = 0;
            // 
            // groupBoxResult_DAS
            // 
            groupBoxResult_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxResult_DAS.Location = new Point(4, 6);
            groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            groupBoxResult_DAS.Padding = new Padding(10);
            groupBoxResult_DAS.Size = new Size(240, 337);
            groupBoxResult_DAS.TabIndex = 0;
            groupBoxResult_DAS.TabStop = false;
            groupBoxResult_DAS.Text = "Вывод данных:";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.Dock = DockStyle.Fill;
            textBoxResult_DAS.Location = new Point(10, 30);
            textBoxResult_DAS.Multiline = true;
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.Size = new Size(220, 297);
            textBoxResult_DAS.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(panelResultDataGridView_DAS);
            Controls.Add(panelResultChart_DAS);
            Controls.Add(panelTask_DAS);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт #6 | Таск 4 | Вариант 2 | Данилов А.С.";
            panelTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.PerformLayout();
            panelResultChart_DAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_DAS).EndInit();
            panelResultDataGridView_DAS.ResumeLayout(false);
            groupBoxResult_DAS.ResumeLayout(false);
            groupBoxResult_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_DAS;
        private Panel panelResultChart_DAS;
        private Panel panelResultDataGridView_DAS;
        private GroupBox groupBoxTask_DAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_DAS;
        private GroupBox groupBoxResult_DAS;
        private Button buttonDone_DAS;
        private Button buttonSaveFile_DAS;
        private Button buttonHelp_DAS;
        private TextBox textBoxStopValue_DAS;
        private TextBox textBoxStartValue_DAS;
        private Label labelStartStep_DAS;
        private Label labelStopStep_DAS;
        private Label labelTask_DAS;
        private TextBox textBoxResult_DAS;
    }
}
