namespace Tyuiu.DanilovAS.Sprint6.Task6.V6
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_DAS = new Button();
            buttonDone_DAS = new Button();
            buttonOpenFile_DAS = new Button();
            panel2 = new Panel();
            groupBoxTask_DAS = new GroupBox();
            labelTask_DAS = new Label();
            panel3 = new Panel();
            groupBoxInPut_DAS = new GroupBox();
            textBoxInPut_DAS = new TextBox();
            panel4 = new Panel();
            groupBoxOutPut_DAS = new GroupBox();
            textBoxOutPut_DAS = new TextBox();
            openFileDialogTask_DAS = new OpenFileDialog();
            toolTipHelp_DAS = new ToolTip(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_DAS.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxInPut_DAS.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxOutPut_DAS.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_DAS);
            panel1.Controls.Add(buttonDone_DAS);
            panel1.Controls.Add(buttonOpenFile_DAS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 83);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.Image = Properties.Resources.help;
            buttonHelp_DAS.Location = new Point(847, 12);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(78, 65);
            buttonHelp_DAS.TabIndex = 2;
            toolTipHelp_DAS.SetToolTip(buttonHelp_DAS, "Сведение о программе");
            buttonHelp_DAS.UseVisualStyleBackColor = true;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.Enabled = false;
            buttonDone_DAS.Image = Properties.Resources.page_go;
            buttonDone_DAS.Location = new Point(96, 12);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(78, 65);
            buttonDone_DAS.TabIndex = 1;
            toolTipHelp_DAS.SetToolTip(buttonDone_DAS, "Нажмите, чтобы выполнить программу");
            buttonDone_DAS.UseVisualStyleBackColor = true;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // buttonOpenFile_DAS
            // 
            buttonOpenFile_DAS.Image = (Image)resources.GetObject("buttonOpenFile_DAS.Image");
            buttonOpenFile_DAS.Location = new Point(12, 12);
            buttonOpenFile_DAS.Name = "buttonOpenFile_DAS";
            buttonOpenFile_DAS.Size = new Size(78, 65);
            buttonOpenFile_DAS.TabIndex = 0;
            toolTipHelp_DAS.SetToolTip(buttonOpenFile_DAS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_DAS.UseVisualStyleBackColor = true;
            buttonOpenFile_DAS.Click += buttonOpenFile_DAS_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_DAS);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(937, 102);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTask_DAS);
            groupBoxTask_DAS.Location = new Point(12, 6);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(913, 87);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTask_DAS
            // 
            labelTask_DAS.Location = new Point(6, 23);
            labelTask_DAS.Name = "labelTask_DAS";
            labelTask_DAS.Size = new Size(901, 76);
            labelTask_DAS.TabIndex = 0;
            labelTask_DAS.Text = resources.GetString("labelTask_DAS.Text");
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxInPut_DAS);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 185);
            panel3.Name = "panel3";
            panel3.Size = new Size(468, 312);
            panel3.TabIndex = 2;
            // 
            // groupBoxInPut_DAS
            // 
            groupBoxInPut_DAS.Controls.Add(textBoxInPut_DAS);
            groupBoxInPut_DAS.Location = new Point(12, 16);
            groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            groupBoxInPut_DAS.Size = new Size(453, 288);
            groupBoxInPut_DAS.TabIndex = 0;
            groupBoxInPut_DAS.TabStop = false;
            groupBoxInPut_DAS.Text = "Ввод:";
            // 
            // textBoxInPut_DAS
            // 
            textBoxInPut_DAS.Location = new Point(10, 26);
            textBoxInPut_DAS.Multiline = true;
            textBoxInPut_DAS.Name = "textBoxInPut_DAS";
            textBoxInPut_DAS.Size = new Size(437, 209);
            textBoxInPut_DAS.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxOutPut_DAS);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(474, 185);
            panel4.Name = "panel4";
            panel4.Size = new Size(463, 312);
            panel4.TabIndex = 3;
            // 
            // groupBoxOutPut_DAS
            // 
            groupBoxOutPut_DAS.Controls.Add(textBoxOutPut_DAS);
            groupBoxOutPut_DAS.Location = new Point(10, 16);
            groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            groupBoxOutPut_DAS.Size = new Size(441, 288);
            groupBoxOutPut_DAS.TabIndex = 1;
            groupBoxOutPut_DAS.TabStop = false;
            groupBoxOutPut_DAS.Text = "Вывод: ";
            // 
            // textBoxOutPut_DAS
            // 
            textBoxOutPut_DAS.Location = new Point(-2, 26);
            textBoxOutPut_DAS.Multiline = true;
            textBoxOutPut_DAS.Name = "textBoxOutPut_DAS";
            textBoxOutPut_DAS.Size = new Size(437, 209);
            textBoxOutPut_DAS.TabIndex = 1;
            // 
            // openFileDialogTask_DAS
            // 
            openFileDialogTask_DAS.FileName = "openFileDialog1";
            // 
            // toolTipHelp_DAS
            // 
            toolTipHelp_DAS.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_DAS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 497);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Спринт #6 | Таск 6 | Вариант 6 | Данилов А.С.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_DAS.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxInPut_DAS.ResumeLayout(false);
            groupBoxInPut_DAS.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxOutPut_DAS.ResumeLayout(false);
            groupBoxOutPut_DAS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button buttonHelp_DAS;
        private Button buttonDone_DAS;
        private Button buttonOpenFile_DAS;
        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxInPut_DAS;
        private GroupBox groupBoxOutPut_DAS;
        private Label labelTask_DAS;
        private OpenFileDialog openFileDialogTask_DAS;
        private ToolTip toolTipHelp_DAS;
        private TextBox textBoxInPut_DAS;
        private TextBox textBoxOutPut_DAS;
    }
}
