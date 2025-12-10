namespace Tyuiu.DanilovAS.Sprint6.Task2.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTaskInfo_DAS = new GroupBox();
            labelTaskInfo_DAS = new Label();
            groupBoxInPutVars_DAS = new GroupBox();
            textBoxStopValue_DAS = new TextBox();
            textBoxStartValue_DAS = new TextBox();
            labelVarStopValue_DAS = new Label();
            labelVarStartValue_DAS = new Label();
            groupBoxOutPut_DAS = new GroupBox();
            chartOutPutResult_DAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            labelOutPutResult_DAS = new Label();
            dataGridViewOutPutResult_DAS = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            buttonHelp_DAS = new Button();
            buttonDone_DAS = new Button();
            groupBoxTaskInfo_DAS.SuspendLayout();
            groupBoxInPutVars_DAS.SuspendLayout();
            groupBoxOutPut_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartOutPutResult_DAS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutResult_DAS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTaskInfo_DAS
            // 
            groupBoxTaskInfo_DAS.Controls.Add(labelTaskInfo_DAS);
            groupBoxTaskInfo_DAS.Location = new Point(11, 16);
            groupBoxTaskInfo_DAS.Name = "groupBoxTaskInfo_DAS";
            groupBoxTaskInfo_DAS.Size = new Size(498, 305);
            groupBoxTaskInfo_DAS.TabIndex = 0;
            groupBoxTaskInfo_DAS.TabStop = false;
            groupBoxTaskInfo_DAS.Text = "Условие";
            // 
            // labelTaskInfo_DAS
            // 
            labelTaskInfo_DAS.AutoSize = true;
            labelTaskInfo_DAS.Location = new Point(10, 23);
            labelTaskInfo_DAS.Name = "labelTaskInfo_DAS";
            labelTaskInfo_DAS.Size = new Size(558, 140);
            labelTaskInfo_DAS.TabIndex = 0;
            labelTaskInfo_DAS.Text = resources.GetString("labelTaskInfo_DAS.Text");
            // 
            // groupBoxInPutVars_DAS
            // 
            groupBoxInPutVars_DAS.Controls.Add(textBoxStopValue_DAS);
            groupBoxInPutVars_DAS.Controls.Add(textBoxStartValue_DAS);
            groupBoxInPutVars_DAS.Controls.Add(labelVarStopValue_DAS);
            groupBoxInPutVars_DAS.Controls.Add(labelVarStartValue_DAS);
            groupBoxInPutVars_DAS.Location = new Point(15, 342);
            groupBoxInPutVars_DAS.Name = "groupBoxInPutVars_DAS";
            groupBoxInPutVars_DAS.Size = new Size(304, 96);
            groupBoxInPutVars_DAS.TabIndex = 1;
            groupBoxInPutVars_DAS.TabStop = false;
            groupBoxInPutVars_DAS.Text = "Ввод данных:";
            // 
            // textBoxStopValue_DAS
            // 
            textBoxStopValue_DAS.Location = new Point(137, 54);
            textBoxStopValue_DAS.Name = "textBoxStopValue_DAS";
            textBoxStopValue_DAS.Size = new Size(125, 27);
            textBoxStopValue_DAS.TabIndex = 5;
            textBoxStopValue_DAS.KeyPress += textBoxStopValue_DAS_KeyPress;
            // 
            // textBoxStartValue_DAS
            // 
            textBoxStartValue_DAS.Location = new Point(6, 54);
            textBoxStartValue_DAS.Name = "textBoxStartValue_DAS";
            textBoxStartValue_DAS.Size = new Size(125, 27);
            textBoxStartValue_DAS.TabIndex = 4;
            textBoxStartValue_DAS.KeyPress += textBoxStartValue_DAS_KeyPress;
            // 
            // labelVarStopValue_DAS
            // 
            labelVarStopValue_DAS.AutoSize = true;
            labelVarStopValue_DAS.Location = new Point(137, 31);
            labelVarStopValue_DAS.Name = "labelVarStopValue_DAS";
            labelVarStopValue_DAS.Size = new Size(108, 20);
            labelVarStopValue_DAS.TabIndex = 3;
            labelVarStopValue_DAS.Text = "Конец шага:";
            // 
            // labelVarStartValue_DAS
            // 
            labelVarStartValue_DAS.AutoSize = true;
            labelVarStartValue_DAS.Location = new Point(6, 31);
            labelVarStartValue_DAS.Name = "labelVarStartValue_DAS";
            labelVarStartValue_DAS.Size = new Size(108, 20);
            labelVarStartValue_DAS.TabIndex = 2;
            labelVarStartValue_DAS.Text = "Старт шага:";
            // 
            // groupBoxOutPut_DAS
            // 
            groupBoxOutPut_DAS.Controls.Add(chartOutPutResult_DAS);
            groupBoxOutPut_DAS.Controls.Add(labelOutPutResult_DAS);
            groupBoxOutPut_DAS.Controls.Add(dataGridViewOutPutResult_DAS);
            groupBoxOutPut_DAS.Location = new Point(515, 16);
            groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            groupBoxOutPut_DAS.Size = new Size(590, 422);
            groupBoxOutPut_DAS.TabIndex = 2;
            groupBoxOutPut_DAS.TabStop = false;
            groupBoxOutPut_DAS.Text = "Вывод данных:";
            // 
            // chartOutPutResult_DAS
            // 
            chartArea1.Name = "ChartArea1";
            chartOutPutResult_DAS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartOutPutResult_DAS.Legends.Add(legend1);
            chartOutPutResult_DAS.Location = new Point(209, 47);
            chartOutPutResult_DAS.Name = "chartOutPutResult_DAS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOutPutResult_DAS.Series.Add(series1);
            chartOutPutResult_DAS.Size = new Size(375, 375);
            chartOutPutResult_DAS.TabIndex = 2;
            chartOutPutResult_DAS.Text = "chart1";
            // 
            // labelOutPutResult_DAS
            // 
            labelOutPutResult_DAS.AutoSize = true;
            labelOutPutResult_DAS.Location = new Point(14, 36);
            labelOutPutResult_DAS.Name = "labelOutPutResult_DAS";
            labelOutPutResult_DAS.Size = new Size(99, 20);
            labelOutPutResult_DAS.TabIndex = 1;
            labelOutPutResult_DAS.Text = "Результат:";
            // 
            // dataGridViewOutPutResult_DAS
            // 
            dataGridViewOutPutResult_DAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPutResult_DAS.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewOutPutResult_DAS.Location = new Point(14, 59);
            dataGridViewOutPutResult_DAS.Name = "dataGridViewOutPutResult_DAS";
            dataGridViewOutPutResult_DAS.RowHeadersVisible = false;
            dataGridViewOutPutResult_DAS.RowHeadersWidth = 51;
            dataGridViewOutPutResult_DAS.Size = new Size(168, 348);
            dataGridViewOutPutResult_DAS.TabIndex = 0;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 65;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.Width = 90;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.BackColor = Color.DodgerBlue;
            buttonHelp_DAS.Location = new Point(325, 358);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(85, 65);
            buttonHelp_DAS.TabIndex = 3;
            buttonHelp_DAS.Text = "Справка";
            buttonHelp_DAS.UseVisualStyleBackColor = false;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.BackColor = Color.Green;
            buttonDone_DAS.Location = new Point(408, 358);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(101, 65);
            buttonDone_DAS.TabIndex = 4;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = false;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            buttonDone_DAS.MouseDown += buttonDone_DAS_MouseDown;
            buttonDone_DAS.MouseEnter += buttonDone_DAS_MouseEnter;
            buttonDone_DAS.MouseLeave += buttonDone_DAS_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 450);
            Controls.Add(buttonDone_DAS);
            Controls.Add(buttonHelp_DAS);
            Controls.Add(groupBoxOutPut_DAS);
            Controls.Add(groupBoxInPutVars_DAS);
            Controls.Add(groupBoxTaskInfo_DAS);
            Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 2 | Вариант 25 | Данилов А.С.";
            groupBoxTaskInfo_DAS.ResumeLayout(false);
            groupBoxTaskInfo_DAS.PerformLayout();
            groupBoxInPutVars_DAS.ResumeLayout(false);
            groupBoxInPutVars_DAS.PerformLayout();
            groupBoxOutPut_DAS.ResumeLayout(false);
            groupBoxOutPut_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartOutPutResult_DAS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPutResult_DAS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTaskInfo_DAS;
        private GroupBox groupBoxInPutVars_DAS;
        private GroupBox groupBoxOutPut_DAS;
        private Button buttonHelp_DAS;
        private Button buttonDone_DAS;
        private Label labelTaskInfo_DAS;
        private Label labelVarStopValue_DAS;
        private Label labelVarStartValue_DAS;
        private Label labelOutPutResult_DAS;
        private DataGridView dataGridViewOutPutResult_DAS;
        private TextBox textBoxStopValue_DAS;
        private TextBox textBoxStartValue_DAS;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOutPutResult_DAS;
    }
}
