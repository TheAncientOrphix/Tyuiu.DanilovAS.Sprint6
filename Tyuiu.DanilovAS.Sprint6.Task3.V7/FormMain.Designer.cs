namespace Tyuiu.DanilovAS.Sprint6.Task3.V7
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
            buttonHelp_DAS = new Button();
            groupBoxTask_DAS = new GroupBox();
            labelTask_DAS = new Label();
            dataGridViewMatrix_DAS = new DataGridView();
            groupBoxResult_DAS = new GroupBox();
            textBoxResult_DAS = new TextBox();
            labelResult_DAS = new Label();
            buttonDone_DAS = new Button();
            groupBoxTask_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_DAS).BeginInit();
            groupBoxResult_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.Location = new Point(558, 340);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(54, 45);
            buttonHelp_DAS.TabIndex = 0;
            buttonHelp_DAS.Text = "?";
            buttonHelp_DAS.UseVisualStyleBackColor = true;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTask_DAS);
            groupBoxTask_DAS.Controls.Add(dataGridViewMatrix_DAS);
            groupBoxTask_DAS.Location = new Point(12, 12);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(540, 326);
            groupBoxTask_DAS.TabIndex = 1;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTask_DAS
            // 
            labelTask_DAS.AutoSize = true;
            labelTask_DAS.Location = new Point(10, 36);
            labelTask_DAS.Name = "labelTask_DAS";
            labelTask_DAS.Size = new Size(302, 260);
            labelTask_DAS.TabIndex = 1;
            labelTask_DAS.Text = resources.GetString("labelTask_DAS.Text");
            // 
            // dataGridViewMatrix_DAS
            // 
            dataGridViewMatrix_DAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_DAS.ColumnHeadersVisible = false;
            dataGridViewMatrix_DAS.Location = new Point(318, 26);
            dataGridViewMatrix_DAS.Name = "dataGridViewMatrix_DAS";
            dataGridViewMatrix_DAS.RowHeadersVisible = false;
            dataGridViewMatrix_DAS.RowHeadersWidth = 51;
            dataGridViewMatrix_DAS.Size = new Size(216, 215);
            dataGridViewMatrix_DAS.TabIndex = 0;
            // 
            // groupBoxResult_DAS
            // 
            groupBoxResult_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxResult_DAS.Controls.Add(labelResult_DAS);
            groupBoxResult_DAS.Location = new Point(558, 23);
            groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            groupBoxResult_DAS.Size = new Size(230, 182);
            groupBoxResult_DAS.TabIndex = 2;
            groupBoxResult_DAS.TabStop = false;
            groupBoxResult_DAS.Text = "Вывод данных:";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.ImeMode = ImeMode.Disable;
            textBoxResult_DAS.Location = new Point(12, 69);
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.Size = new Size(212, 27);
            textBoxResult_DAS.TabIndex = 1;
            // 
            // labelResult_DAS
            // 
            labelResult_DAS.AutoSize = true;
            labelResult_DAS.Location = new Point(11, 33);
            labelResult_DAS.Name = "labelResult_DAS";
            labelResult_DAS.Size = new Size(78, 20);
            labelResult_DAS.TabIndex = 0;
            labelResult_DAS.Text = "Результат:";
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.Location = new Point(626, 340);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(162, 45);
            buttonDone_DAS.TabIndex = 3;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = true;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(buttonDone_DAS);
            Controls.Add(groupBoxResult_DAS);
            Controls.Add(groupBoxTask_DAS);
            Controls.Add(buttonHelp_DAS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 3 | Вариант 7 | Данилов А.С.";
            Load += FormMain_Load;
            groupBoxTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_DAS).EndInit();
            groupBoxResult_DAS.ResumeLayout(false);
            groupBoxResult_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonHelp_DAS;
        private GroupBox groupBoxTask_DAS;
        private DataGridView dataGridViewMatrix_DAS;
        private GroupBox groupBoxResult_DAS;
        private Button buttonDone_DAS;
        private Label labelTask_DAS;
        private TextBox textBoxResult_DAS;
        private Label labelResult_DAS;
    }
}
