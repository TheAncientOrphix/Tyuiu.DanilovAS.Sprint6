namespace Tyuiu.DanilovAS.Sprint6.Task1.V14
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
            groupBoxTask_DAS = new GroupBox();
            labelTaskInfo_DAS = new Label();
            groupBoxOutPut_DAS = new GroupBox();
            labelResult_DAS = new Label();
            textBoxResult_DAS = new TextBox();
            groupBoxInPut_DAS = new GroupBox();
            labelStopValue_DAS = new Label();
            labelStartValue_DAS = new Label();
            textBoxStopValue_DAS = new TextBox();
            textBoxStartValue_DAS = new TextBox();
            buttonHelp_DAS = new Button();
            buttonResult_DAS = new Button();
            groupBoxTask_DAS.SuspendLayout();
            groupBoxOutPut_DAS.SuspendLayout();
            groupBoxInPut_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTaskInfo_DAS);
            groupBoxTask_DAS.Location = new Point(14, 17);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(570, 294);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTaskInfo_DAS
            // 
            labelTaskInfo_DAS.AutoSize = true;
            labelTaskInfo_DAS.Location = new Point(15, 34);
            labelTaskInfo_DAS.Name = "labelTaskInfo_DAS";
            labelTaskInfo_DAS.Size = new Size(482, 100);
            labelTaskInfo_DAS.TabIndex = 0;
            labelTaskInfo_DAS.Text = resources.GetString("labelTaskInfo_DAS.Text");
            // 
            // groupBoxOutPut_DAS
            // 
            groupBoxOutPut_DAS.Controls.Add(labelResult_DAS);
            groupBoxOutPut_DAS.Controls.Add(textBoxResult_DAS);
            groupBoxOutPut_DAS.Location = new Point(610, 23);
            groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            groupBoxOutPut_DAS.Size = new Size(274, 376);
            groupBoxOutPut_DAS.TabIndex = 1;
            groupBoxOutPut_DAS.TabStop = false;
            groupBoxOutPut_DAS.Text = "Вывод данных";
            // 
            // labelResult_DAS
            // 
            labelResult_DAS.AutoSize = true;
            labelResult_DAS.Location = new Point(13, 22);
            labelResult_DAS.Name = "labelResult_DAS";
            labelResult_DAS.Size = new Size(78, 20);
            labelResult_DAS.TabIndex = 1;
            labelResult_DAS.Text = "Результат:";
            // 
            // textBoxResult_DAS
            // 
            textBoxResult_DAS.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_DAS.Location = new Point(13, 45);
            textBoxResult_DAS.Multiline = true;
            textBoxResult_DAS.Name = "textBoxResult_DAS";
            textBoxResult_DAS.ReadOnly = true;
            textBoxResult_DAS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_DAS.Size = new Size(255, 325);
            textBoxResult_DAS.TabIndex = 0;
            // 
            // groupBoxInPut_DAS
            // 
            groupBoxInPut_DAS.Controls.Add(labelStopValue_DAS);
            groupBoxInPut_DAS.Controls.Add(labelStartValue_DAS);
            groupBoxInPut_DAS.Controls.Add(textBoxStopValue_DAS);
            groupBoxInPut_DAS.Controls.Add(textBoxStartValue_DAS);
            groupBoxInPut_DAS.Location = new Point(14, 317);
            groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            groupBoxInPut_DAS.Size = new Size(305, 82);
            groupBoxInPut_DAS.TabIndex = 2;
            groupBoxInPut_DAS.TabStop = false;
            groupBoxInPut_DAS.Text = "Ввод данных";
            // 
            // labelStopValue_DAS
            // 
            labelStopValue_DAS.AutoSize = true;
            labelStopValue_DAS.Location = new Point(164, 23);
            labelStopValue_DAS.Name = "labelStopValue_DAS";
            labelStopValue_DAS.Size = new Size(94, 20);
            labelStopValue_DAS.TabIndex = 3;
            labelStopValue_DAS.Text = "Конец шага:";
            // 
            // labelStartValue_DAS
            // 
            labelStartValue_DAS.AutoSize = true;
            labelStartValue_DAS.Location = new Point(10, 23);
            labelStartValue_DAS.Name = "labelStartValue_DAS";
            labelStartValue_DAS.Size = new Size(88, 20);
            labelStartValue_DAS.TabIndex = 2;
            labelStartValue_DAS.Text = "Старт шага:";
            // 
            // textBoxStopValue_DAS
            // 
            textBoxStopValue_DAS.Location = new Point(164, 49);
            textBoxStopValue_DAS.Name = "textBoxStopValue_DAS";
            textBoxStopValue_DAS.Size = new Size(125, 27);
            textBoxStopValue_DAS.TabIndex = 1;
            // 
            // textBoxStartValue_DAS
            // 
            textBoxStartValue_DAS.Location = new Point(10, 49);
            textBoxStartValue_DAS.Name = "textBoxStartValue_DAS";
            textBoxStartValue_DAS.Size = new Size(125, 27);
            textBoxStartValue_DAS.TabIndex = 0;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.BackColor = Color.DodgerBlue;
            buttonHelp_DAS.Location = new Point(328, 317);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(94, 82);
            buttonHelp_DAS.TabIndex = 3;
            buttonHelp_DAS.Text = "Справка";
            buttonHelp_DAS.UseVisualStyleBackColor = false;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonResult_DAS
            // 
            buttonResult_DAS.BackColor = Color.DarkGreen;
            buttonResult_DAS.Location = new Point(428, 317);
            buttonResult_DAS.Name = "buttonResult_DAS";
            buttonResult_DAS.Size = new Size(156, 82);
            buttonResult_DAS.TabIndex = 4;
            buttonResult_DAS.Text = "Выполнить";
            buttonResult_DAS.UseVisualStyleBackColor = false;
            buttonResult_DAS.Click += buttonResult_DAS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 412);
            Controls.Add(buttonResult_DAS);
            Controls.Add(buttonHelp_DAS);
            Controls.Add(groupBoxInPut_DAS);
            Controls.Add(groupBoxOutPut_DAS);
            Controls.Add(groupBoxTask_DAS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 1 | Вариант 14 | Данилов А.С.";
            groupBoxTask_DAS.ResumeLayout(false);
            groupBoxTask_DAS.PerformLayout();
            groupBoxOutPut_DAS.ResumeLayout(false);
            groupBoxOutPut_DAS.PerformLayout();
            groupBoxInPut_DAS.ResumeLayout(false);
            groupBoxInPut_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxOutPut_DAS;
        private GroupBox groupBoxInPut_DAS;
        private Button buttonHelp_DAS;
        private Button buttonResult_DAS;
        private TextBox textBoxStopValue_DAS;
        private TextBox textBoxStartValue_DAS;
        private Label labelStopValue_DAS;
        private Label labelStartValue_DAS;
        private Label labelTaskInfo_DAS;
        private Label labelResult_DAS;
        private TextBox textBoxResult_DAS;
    }
}
