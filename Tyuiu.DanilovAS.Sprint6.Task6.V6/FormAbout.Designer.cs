namespace Tyuiu.DanilovAS.Sprint6.Task6.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_DAS = new PictureBox();
            labelInfo_DAS = new Label();
            buttonOK_DAS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_DAS
            // 
            pictureBoxAvatar_DAS.Image = Properties.Resources.Avatar;
            pictureBoxAvatar_DAS.Location = new Point(12, 32);
            pictureBoxAvatar_DAS.Name = "pictureBoxAvatar_DAS";
            pictureBoxAvatar_DAS.Size = new Size(165, 166);
            pictureBoxAvatar_DAS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_DAS.TabIndex = 0;
            pictureBoxAvatar_DAS.TabStop = false;
            // 
            // labelInfo_DAS
            // 
            labelInfo_DAS.AutoSize = true;
            labelInfo_DAS.Location = new Point(196, 17);
            labelInfo_DAS.Name = "labelInfo_DAS";
            labelInfo_DAS.Size = new Size(387, 180);
            labelInfo_DAS.TabIndex = 1;
            labelInfo_DAS.Text = resources.GetString("labelInfo_DAS.Text");
            // 
            // buttonOK_DAS
            // 
            buttonOK_DAS.Location = new Point(480, 204);
            buttonOK_DAS.Name = "buttonOK_DAS";
            buttonOK_DAS.Size = new Size(94, 29);
            buttonOK_DAS.TabIndex = 2;
            buttonOK_DAS.Text = "OK";
            buttonOK_DAS.UseVisualStyleBackColor = true;
            buttonOK_DAS.Click += buttonOK_DAS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 245);
            Controls.Add(buttonOK_DAS);
            Controls.Add(labelInfo_DAS);
            Controls.Add(pictureBoxAvatar_DAS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_DAS;
        private Label labelInfo_DAS;
        private Button buttonOK_DAS;
    }
}