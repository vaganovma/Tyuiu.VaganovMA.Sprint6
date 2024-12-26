namespace Tyuiu.VaganovMA.Sprint6.Task4.V14
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
            pictureBox1 = new PictureBox();
            labelInfo = new Label();
            buttonCl = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 426);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(484, 27);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(304, 100);
            labelInfo.TabIndex = 1;
            labelInfo.Text = "Разработчик Ваганов Михаил ИИПБ 24 2\r\n\r\nРазработка на с#\r\n\r\nМожете посмотреть на очень милое фото\r\n";
            labelInfo.Click += labelInfo_Click;
            // 
            // buttonCl
            // 
            buttonCl.Location = new Point(657, 375);
            buttonCl.Name = "buttonCl";
            buttonCl.Size = new Size(107, 40);
            buttonCl.TabIndex = 2;
            buttonCl.Text = "Ok";
            buttonCl.UseVisualStyleBackColor = true;
            buttonCl.Click += buttonCl_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCl);
            Controls.Add(labelInfo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Text = "FormAbout";
            Load += this.FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelInfo;
        private Button buttonCl;
    }
}