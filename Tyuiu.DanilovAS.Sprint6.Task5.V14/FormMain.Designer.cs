namespace Tyuiu.DanilovAS.Sprint6.Task5.V14
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
            buttonHelp_DAS = new Button();
            buttonOpenFile_DAS = new Button();
            buttonDone_DAS = new Button();
            groupBoxTask_DAS = new GroupBox();
            labelTask_DAS = new Label();
            panelResult_DAS = new Panel();
            groupBoxResult_DAS = new GroupBox();
            dataGridViewResult_DAS = new DataGridView();
            panelChartResult_DAS = new Panel();
            chartResult_DAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelTask_DAS.SuspendLayout();
            groupBoxTask_DAS.SuspendLayout();
            panelResult_DAS.SuspendLayout();
            groupBoxResult_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAS).BeginInit();
            panelChartResult_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_DAS).BeginInit();
            SuspendLayout();
            // 
            // panelTask_DAS
            // 
            panelTask_DAS.Controls.Add(buttonHelp_DAS);
            panelTask_DAS.Controls.Add(buttonOpenFile_DAS);
            panelTask_DAS.Controls.Add(buttonDone_DAS);
            panelTask_DAS.Controls.Add(groupBoxTask_DAS);
            panelTask_DAS.Dock = DockStyle.Top;
            panelTask_DAS.Location = new Point(0, 0);
            panelTask_DAS.Name = "panelTask_DAS";
            panelTask_DAS.Size = new Size(967, 125);
            panelTask_DAS.TabIndex = 0;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.BackColor = Color.Cyan;
            buttonHelp_DAS.Location = new Point(866, 21);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(89, 77);
            buttonHelp_DAS.TabIndex = 3;
            buttonHelp_DAS.Text = "?";
            buttonHelp_DAS.UseVisualStyleBackColor = false;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonOpenFile_DAS
            // 
            buttonOpenFile_DAS.BackColor = Color.DarkViolet;
            buttonOpenFile_DAS.Location = new Point(763, 21);
            buttonOpenFile_DAS.Name = "buttonOpenFile_DAS";
            buttonOpenFile_DAS.Size = new Size(97, 77);
            buttonOpenFile_DAS.TabIndex = 2;
            buttonOpenFile_DAS.Text = "Открыть файл";
            buttonOpenFile_DAS.UseVisualStyleBackColor = false;
            buttonOpenFile_DAS.Click += buttonOpenFile_DAS_Click;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone_DAS.Location = new Point(658, 21);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(99, 77);
            buttonDone_DAS.TabIndex = 1;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = false;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTask_DAS);
            groupBoxTask_DAS.Location = new Point(7, 6);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(645, 113);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTask_DAS
            // 
            labelTask_DAS.Location = new Point(11, 30);
            labelTask_DAS.Name = "labelTask_DAS";
            labelTask_DAS.Size = new Size(613, 80);
            labelTask_DAS.TabIndex = 0;
            labelTask_DAS.Text = "Прочитать данные из файла. Вывести в dataGridView.\r\nВывести все числа, больше или равные 10. \r\nПостроить диаграмму по этим значениям\r\n";
            // 
            // panelResult_DAS
            // 
            panelResult_DAS.Controls.Add(groupBoxResult_DAS);
            panelResult_DAS.Dock = DockStyle.Left;
            panelResult_DAS.Location = new Point(0, 125);
            panelResult_DAS.Name = "panelResult_DAS";
            panelResult_DAS.Padding = new Padding(10);
            panelResult_DAS.Size = new Size(250, 369);
            panelResult_DAS.TabIndex = 1;
            // 
            // groupBoxResult_DAS
            // 
            groupBoxResult_DAS.Controls.Add(dataGridViewResult_DAS);
            groupBoxResult_DAS.Dock = DockStyle.Fill;
            groupBoxResult_DAS.Location = new Point(10, 10);
            groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            groupBoxResult_DAS.Size = new Size(230, 349);
            groupBoxResult_DAS.TabIndex = 0;
            groupBoxResult_DAS.TabStop = false;
            groupBoxResult_DAS.Text = "Вывод данных:";
            // 
            // dataGridViewResult_DAS
            // 
            dataGridViewResult_DAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_DAS.ColumnHeadersVisible = false;
            dataGridViewResult_DAS.Dock = DockStyle.Fill;
            dataGridViewResult_DAS.Location = new Point(3, 23);
            dataGridViewResult_DAS.Name = "dataGridViewResult_DAS";
            dataGridViewResult_DAS.RowHeadersVisible = false;
            dataGridViewResult_DAS.RowHeadersWidth = 51;
            dataGridViewResult_DAS.Size = new Size(224, 323);
            dataGridViewResult_DAS.TabIndex = 0;
            // 
            // panelChartResult_DAS
            // 
            panelChartResult_DAS.Controls.Add(chartResult_DAS);
            panelChartResult_DAS.Dock = DockStyle.Fill;
            panelChartResult_DAS.Location = new Point(250, 125);
            panelChartResult_DAS.Name = "panelChartResult_DAS";
            panelChartResult_DAS.Size = new Size(717, 369);
            panelChartResult_DAS.TabIndex = 2;
            // 
            // chartResult_DAS
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_DAS.ChartAreas.Add(chartArea1);
            chartResult_DAS.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResult_DAS.Legends.Add(legend1);
            chartResult_DAS.Location = new Point(0, 0);
            chartResult_DAS.Name = "chartResult_DAS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_DAS.Series.Add(series1);
            chartResult_DAS.Size = new Size(717, 369);
            chartResult_DAS.TabIndex = 0;
            chartResult_DAS.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(250, 125);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 369);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 494);
            Controls.Add(splitter1);
            Controls.Add(panelChartResult_DAS);
            Controls.Add(panelResult_DAS);
            Controls.Add(panelTask_DAS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MinimumSize = new Size(985, 541);
            Name = "FormMain";
            Text = "Спринт #6 | Таск 5 | Вариант 14 | Данилов А.С.";
            panelTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.ResumeLayout(false);
            panelResult_DAS.ResumeLayout(false);
            groupBoxResult_DAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_DAS).EndInit();
            panelChartResult_DAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_DAS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_DAS;
        private Panel panelResult_DAS;
        private Panel panelChartResult_DAS;
        private Splitter splitter1;
        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxResult_DAS;
        private Button buttonHelp_DAS;
        private Button buttonOpenFile_DAS;
        private Button buttonDone_DAS;
        private Label labelTask_DAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_DAS;
        private DataGridView dataGridViewResult_DAS;
    }
}
