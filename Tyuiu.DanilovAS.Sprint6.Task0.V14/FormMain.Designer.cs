namespace Tyuiu.DanilovAS.Sprint6.Task0.V14
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
            groupBoxTask_DAS = new GroupBox();
            pictureBoxFormula_DAS = new PictureBox();
            textBoxTask_DAS = new TextBox();
            groupBoxVars_DAS = new GroupBox();
            labelVarX_DAS = new Label();
            textBoxInPutX_DAS = new TextBox();
            groupBoxResult_DAS = new GroupBox();
            label2 = new Label();
            textBoxResult_DAS = new TextBox();
            buttonDone_DAS = new Button();
            buttonHelp_DAS = new Button();
            groupBoxTask_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAS).BeginInit();
            groupBoxVars_DAS.SuspendLayout();
            groupBoxResult_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(pictureBoxFormula_DAS);
            groupBoxTask_DAS.Controls.Add(textBoxTask_DAS);
            groupBoxTask_DAS.Location = new Point(16, 12);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(759, 228);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // pictureBoxFormula_DAS
            // 
            pictureBoxFormula_DAS.Image = Properties.Resources.Formula;
            pictureBoxFormula_DAS.Location = new Point(529, 31);
            pictureBoxFormula_DAS.Name = "pictureBoxFormula_DAS";
            pictureBoxFormula_DAS.Size = new Size(192, 86);
            pictureBoxFormula_DAS.TabIndex = 1;
            pictureBoxFormula_DAS.TabStop = false;
            // 
            // textBoxTask_DAS
            // 
            textBoxTask_DAS.BorderStyle = BorderStyle.None;
            textBoxTask_DAS.Location = new Point(6, 26);
            textBoxTask_DAS.Name = "textBoxTask_DAS";
            textBoxTask_DAS.ReadOnly = true;
            textBoxTask_DAS.Size = new Size(492, 20);
            textBoxTask_DAS.TabIndex = 0;
            textBoxTask_DAS.Text = "Вычислить выражение по формуле\r\n";
            // 
            // groupBoxVars_DAS
            // 
            groupBoxVars_DAS.Controls.Add(labelVarX_DAS);
            groupBoxVars_DAS.Controls.Add(textBoxInPutX_DAS);
            groupBoxVars_DAS.Location = new Point(16, 262);
            groupBoxVars_DAS.Name = "groupBoxVars_DAS";
            groupBoxVars_DAS.Size = new Size(485, 109);
            groupBoxVars_DAS.TabIndex = 1;
            groupBoxVars_DAS.TabStop = false;
            groupBoxVars_DAS.Text = "Ввод данных";
            // 
            // labelVarX_DAS
            // 
            labelVarX_DAS.AutoSize = true;
            labelVarX_DAS.Location = new Point(6, 41);
            labelVarX_DAS.Name = "labelVarX_DAS";
            labelVarX_DAS.Size = new Size(123, 20);
            labelVarX_DAS.TabIndex = 1;
            labelVarX_DAS.Text = "Переменнная X:";
            // 
            // textBoxInPutX_DAS
            // 
            textBoxInPutX_DAS.Location = new Point(6, 64);
            textBoxInPutX_DAS.Name = "textBoxInPutX_DAS";
            textBoxInPutX_DAS.Size = new Size(135, 27);
            textBoxInPutX_DAS.TabIndex = 0;
            textBoxInPutX_DAS.KeyPress += textBoxInPutX_DAS_KeyPress;
            // 
            // groupBoxResult_DAS
            // 
            groupBoxResult_DAS.Controls.Add(label2);
            groupBoxResult_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxResult_DAS.Location = new Point(525, 262);
            groupBoxResult_DAS.Name = "groupBoxResult_DAS";
            groupBoxResult_DAS.Size = new Size(250, 109);
            groupBoxResult_DAS.TabIndex = 2;
            groupBoxResult_DAS.TabStop = false;
            groupBoxResult_DAS.Text = "Вывод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 31);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Результат:";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.Location = new Point(16, 54);
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.Size = new Size(228, 27);
            textBoxResult_DAS.TabIndex = 0;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.Location = new Point(601, 377);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(174, 61);
            buttonDone_DAS.TabIndex = 3;
            buttonDone_DAS.Text = "Выполнить";
            buttonDone_DAS.UseVisualStyleBackColor = true;
            buttonDone_DAS.Click += button1_Click;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.Location = new Point(525, 377);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(70, 61);
            buttonHelp_DAS.TabIndex = 4;
            buttonHelp_DAS.Text = "?";
            buttonHelp_DAS.UseVisualStyleBackColor = true;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_DAS);
            Controls.Add(buttonDone_DAS);
            Controls.Add(groupBoxResult_DAS);
            Controls.Add(groupBoxVars_DAS);
            Controls.Add(groupBoxTask_DAS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 0 | Вариант 14 | Данилов А.С. ";
            Load += Form1_Load;
            groupBoxTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_DAS).EndInit();
            groupBoxVars_DAS.ResumeLayout(false);
            groupBoxVars_DAS.PerformLayout();
            groupBoxResult_DAS.ResumeLayout(false);
            groupBoxResult_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxVars_DAS;
        private GroupBox groupBoxResult_DAS;
        private Button buttonDone_DAS;
        private Button buttonHelp_DAS;
        private TextBox textBoxTask_DAS;
        private Label labelVarX_DAS;
        private TextBox textBoxInPutX_DAS;
        private Label label2;
        private TextBox textBoxResult_DAS;
        private PictureBox pictureBoxFormula_DAS;
    }
}
