namespace Tyuiu.DanilovAS.Sprint6.Task7.V3
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
            label1 = new Label();
            buttonOk_DAS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_DAS
            // 
            pictureBoxAvatar_DAS.Image = (Image)resources.GetObject("pictureBoxAvatar_DAS.Image");
            pictureBoxAvatar_DAS.Location = new Point(12, 22);
            pictureBoxAvatar_DAS.Name = "pictureBoxAvatar_DAS";
            pictureBoxAvatar_DAS.Size = new Size(202, 217);
            pictureBoxAvatar_DAS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_DAS.TabIndex = 0;
            pictureBoxAvatar_DAS.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 22);
            label1.Name = "label1";
            label1.Size = new Size(387, 200);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOk_DAS
            // 
            buttonOk_DAS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk_DAS.Location = new Point(543, 229);
            buttonOk_DAS.Name = "buttonOk_DAS";
            buttonOk_DAS.Size = new Size(81, 33);
            buttonOk_DAS.TabIndex = 2;
            buttonOk_DAS.Text = "OK";
            buttonOk_DAS.UseVisualStyleBackColor = true;
            buttonOk_DAS.Click += buttonOk_DAS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 274);
            Controls.Add(buttonOk_DAS);
            Controls.Add(label1);
            Controls.Add(pictureBoxAvatar_DAS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DAS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_DAS;
        private Label label1;
        private Button buttonOk_DAS;
    }
}