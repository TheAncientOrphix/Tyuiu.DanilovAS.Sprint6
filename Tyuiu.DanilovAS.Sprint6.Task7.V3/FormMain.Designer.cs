namespace Tyuiu.DanilovAS.Sprint6.Task7.V3
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
            panelButtons_DAS = new Panel();
            buttonSave_DAS = new Button();
            buttonHelp_DAS = new Button();
            buttonDone_DAS = new Button();
            buttonOpenFile_DAS = new Button();
            panelTaskInfo_DAS = new Panel();
            groupBoxTask_DAS = new GroupBox();
            labelTask_DAS = new Label();
            panelInPut_DAS = new Panel();
            groupBoxInPut_DAS = new GroupBox();
            dataGridViewInPut_DAS = new DataGridView();
            splitter1 = new Splitter();
            panelOutPut_DAS = new Panel();
            groupBoxOutPut_DAS = new GroupBox();
            dataGridViewOutPut_DAS = new DataGridView();
            toolTipHelp_DAS = new ToolTip(components);
            openFileDialog_DAS = new OpenFileDialog();
            saveFileDialog_DAS = new SaveFileDialog();
            panelButtons_DAS.SuspendLayout();
            panelTaskInfo_DAS.SuspendLayout();
            groupBoxTask_DAS.SuspendLayout();
            panelInPut_DAS.SuspendLayout();
            groupBoxInPut_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_DAS).BeginInit();
            panelOutPut_DAS.SuspendLayout();
            groupBoxOutPut_DAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_DAS).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_DAS
            // 
            panelButtons_DAS.Controls.Add(buttonSave_DAS);
            panelButtons_DAS.Controls.Add(buttonHelp_DAS);
            panelButtons_DAS.Controls.Add(buttonDone_DAS);
            panelButtons_DAS.Controls.Add(buttonOpenFile_DAS);
            panelButtons_DAS.Dock = DockStyle.Top;
            panelButtons_DAS.Location = new Point(0, 0);
            panelButtons_DAS.Name = "panelButtons_DAS";
            panelButtons_DAS.Size = new Size(1098, 68);
            panelButtons_DAS.TabIndex = 0;
            // 
            // buttonSave_DAS
            // 
            buttonSave_DAS.Enabled = false;
            buttonSave_DAS.Image = Properties.Resources.page_save;
            buttonSave_DAS.Location = new Point(163, 6);
            buttonSave_DAS.Name = "buttonSave_DAS";
            buttonSave_DAS.Size = new Size(74, 56);
            buttonSave_DAS.TabIndex = 3;
            toolTipHelp_DAS.SetToolTip(buttonSave_DAS, "Сохранить файл");
            buttonSave_DAS.UseVisualStyleBackColor = true;
            buttonSave_DAS.Click += buttonSave_DAS_Click;
            // 
            // buttonHelp_DAS
            // 
            buttonHelp_DAS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_DAS.Image = Properties.Resources.help;
            buttonHelp_DAS.Location = new Point(1012, 6);
            buttonHelp_DAS.Name = "buttonHelp_DAS";
            buttonHelp_DAS.Size = new Size(74, 56);
            buttonHelp_DAS.TabIndex = 2;
            toolTipHelp_DAS.SetToolTip(buttonHelp_DAS, "Справка о разработчике");
            buttonHelp_DAS.UseVisualStyleBackColor = true;
            buttonHelp_DAS.Click += buttonHelp_DAS_Click;
            // 
            // buttonDone_DAS
            // 
            buttonDone_DAS.Enabled = false;
            buttonDone_DAS.Image = Properties.Resources.page_go;
            buttonDone_DAS.Location = new Point(83, 6);
            buttonDone_DAS.Name = "buttonDone_DAS";
            buttonDone_DAS.Size = new Size(74, 56);
            buttonDone_DAS.TabIndex = 1;
            toolTipHelp_DAS.SetToolTip(buttonDone_DAS, "Выполнить программу");
            buttonDone_DAS.UseVisualStyleBackColor = true;
            buttonDone_DAS.Click += buttonDone_DAS_Click;
            // 
            // buttonOpenFile_DAS
            // 
            buttonOpenFile_DAS.Image = Properties.Resources.folder_page;
            buttonOpenFile_DAS.Location = new Point(3, 6);
            buttonOpenFile_DAS.Name = "buttonOpenFile_DAS";
            buttonOpenFile_DAS.Size = new Size(74, 56);
            buttonOpenFile_DAS.TabIndex = 0;
            toolTipHelp_DAS.SetToolTip(buttonOpenFile_DAS, "Открыть файл");
            buttonOpenFile_DAS.UseVisualStyleBackColor = true;
            buttonOpenFile_DAS.Click += buttonOpenFile_DAS_Click;
            // 
            // panelTaskInfo_DAS
            // 
            panelTaskInfo_DAS.Controls.Add(groupBoxTask_DAS);
            panelTaskInfo_DAS.Dock = DockStyle.Top;
            panelTaskInfo_DAS.Location = new Point(0, 68);
            panelTaskInfo_DAS.Name = "panelTaskInfo_DAS";
            panelTaskInfo_DAS.Size = new Size(1098, 68);
            panelTaskInfo_DAS.TabIndex = 1;
            // 
            // groupBoxTask_DAS
            // 
            groupBoxTask_DAS.Controls.Add(labelTask_DAS);
            groupBoxTask_DAS.Dock = DockStyle.Fill;
            groupBoxTask_DAS.Location = new Point(0, 0);
            groupBoxTask_DAS.Name = "groupBoxTask_DAS";
            groupBoxTask_DAS.Size = new Size(1098, 68);
            groupBoxTask_DAS.TabIndex = 0;
            groupBoxTask_DAS.TabStop = false;
            groupBoxTask_DAS.Text = "Условие";
            // 
            // labelTask_DAS
            // 
            labelTask_DAS.Location = new Point(7, 23);
            labelTask_DAS.Name = "labelTask_DAS";
            labelTask_DAS.Size = new Size(1079, 70);
            labelTask_DAS.TabIndex = 0;
            labelTask_DAS.Text = "Дан файл InPutFileTask7V3.csv в котором хранится матрица целочисленных значений. \r\nЗагрузить файл через openFileDialog в объект dataGridViewIn. Изменить в первом столбце четные значения на -1 ";
            // 
            // panelInPut_DAS
            // 
            panelInPut_DAS.Controls.Add(groupBoxInPut_DAS);
            panelInPut_DAS.Dock = DockStyle.Left;
            panelInPut_DAS.Location = new Point(0, 136);
            panelInPut_DAS.Name = "panelInPut_DAS";
            panelInPut_DAS.Size = new Size(583, 367);
            panelInPut_DAS.TabIndex = 1;
            // 
            // groupBoxInPut_DAS
            // 
            groupBoxInPut_DAS.Controls.Add(dataGridViewInPut_DAS);
            groupBoxInPut_DAS.Dock = DockStyle.Fill;
            groupBoxInPut_DAS.Location = new Point(0, 0);
            groupBoxInPut_DAS.Name = "groupBoxInPut_DAS";
            groupBoxInPut_DAS.Size = new Size(583, 367);
            groupBoxInPut_DAS.TabIndex = 0;
            groupBoxInPut_DAS.TabStop = false;
            groupBoxInPut_DAS.Text = "Ввод:";
            // 
            // dataGridViewInPut_DAS
            // 
            dataGridViewInPut_DAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_DAS.Dock = DockStyle.Fill;
            dataGridViewInPut_DAS.Location = new Point(3, 23);
            dataGridViewInPut_DAS.Name = "dataGridViewInPut_DAS";
            dataGridViewInPut_DAS.RowHeadersWidth = 51;
            dataGridViewInPut_DAS.Size = new Size(577, 341);
            dataGridViewInPut_DAS.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(583, 136);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 367);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelOutPut_DAS
            // 
            panelOutPut_DAS.Controls.Add(groupBoxOutPut_DAS);
            panelOutPut_DAS.Dock = DockStyle.Fill;
            panelOutPut_DAS.Location = new Point(587, 136);
            panelOutPut_DAS.Name = "panelOutPut_DAS";
            panelOutPut_DAS.Size = new Size(511, 367);
            panelOutPut_DAS.TabIndex = 3;
            // 
            // groupBoxOutPut_DAS
            // 
            groupBoxOutPut_DAS.Controls.Add(dataGridViewOutPut_DAS);
            groupBoxOutPut_DAS.Dock = DockStyle.Fill;
            groupBoxOutPut_DAS.Location = new Point(0, 0);
            groupBoxOutPut_DAS.Name = "groupBoxOutPut_DAS";
            groupBoxOutPut_DAS.Size = new Size(511, 367);
            groupBoxOutPut_DAS.TabIndex = 0;
            groupBoxOutPut_DAS.TabStop = false;
            groupBoxOutPut_DAS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_DAS
            // 
            dataGridViewOutPut_DAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_DAS.Dock = DockStyle.Fill;
            dataGridViewOutPut_DAS.Location = new Point(3, 23);
            dataGridViewOutPut_DAS.Name = "dataGridViewOutPut_DAS";
            dataGridViewOutPut_DAS.RowHeadersWidth = 51;
            dataGridViewOutPut_DAS.Size = new Size(505, 341);
            dataGridViewOutPut_DAS.TabIndex = 0;
            // 
            // toolTipHelp_DAS
            // 
            toolTipHelp_DAS.ToolTipIcon = ToolTipIcon.Info;
            toolTipHelp_DAS.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog_DAS
            // 
            openFileDialog_DAS.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 503);
            Controls.Add(panelOutPut_DAS);
            Controls.Add(splitter1);
            Controls.Add(panelInPut_DAS);
            Controls.Add(panelTaskInfo_DAS);
            Controls.Add(panelButtons_DAS);
            MinimumSize = new Size(1116, 550);
            Name = "FormMain";
            Text = "Спринт #6 | Таск 7 | Вариант 3 | Данилов А.С";
            Load += FormMain_Load;
            panelButtons_DAS.ResumeLayout(false);
            panelTaskInfo_DAS.ResumeLayout(false);
            groupBoxTask_DAS.ResumeLayout(false);
            panelInPut_DAS.ResumeLayout(false);
            groupBoxInPut_DAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_DAS).EndInit();
            panelOutPut_DAS.ResumeLayout(false);
            groupBoxOutPut_DAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_DAS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_DAS;
        private Panel panelTaskInfo_DAS;
        private Panel panelInPut_DAS;
        private Splitter splitter1;
        private Panel panelOutPut_DAS;
        private Button buttonHelp_DAS;
        private Button buttonDone_DAS;
        private Button buttonOpenFile_DAS;
        private Button buttonSave_DAS;
        private GroupBox groupBoxTask_DAS;
        private GroupBox groupBoxInPut_DAS;
        private GroupBox groupBoxOutPut_DAS;
        private ToolTip toolTipHelp_DAS;
        private OpenFileDialog openFileDialog_DAS;
        private Label labelTask_DAS;
        private DataGridView dataGridViewInPut_DAS;
        private DataGridView dataGridViewOutPut_DAS;
        private SaveFileDialog saveFileDialog_DAS;
    }
}
