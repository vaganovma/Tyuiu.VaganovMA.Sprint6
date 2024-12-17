namespace Tyuiu.VaganovMA.Sprint6.Task0.V13
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
            pictureBox2 = new PictureBox();
            textBoxTask = new TextBox();
            button1 = new Button();
            groupBoxTask = new GroupBox();
            textBoxResult = new TextBox();
            textBoxVar = new TextBox();
            buttonHelp = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBoxTask.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleName = "";
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(575, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(331, 247);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxTask.Location = new Point(27, 48);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(505, 208);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Вычислить выражение по формуле";
            textBoxTask.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(210, 118);
            button1.Name = "button1";
            button1.Size = new Size(137, 63);
            button1.TabIndex = 3;
            button1.Text = "Выполнить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Controls.Add(pictureBox2);
            groupBoxTask.Location = new Point(12, 26);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(922, 298);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(44, 46);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(303, 27);
            textBoxResult.TabIndex = 5;
            // 
            // textBoxVar
            // 
            textBoxVar.Location = new Point(191, 92);
            textBoxVar.Name = "textBoxVar";
            textBoxVar.Size = new Size(125, 27);
            textBoxVar.TabIndex = 6;
            textBoxVar.TextChanged += textBox2_TextChanged;
            textBoxVar.KeyPress += textBoxVar_KeyPress;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(44, 131);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 50);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "?(Кто я)?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonHelp);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBoxResult);
            groupBox1.Location = new Point(543, 330);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(391, 202);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Вывод данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVar);
            groupBox2.Location = new Point(12, 330);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(525, 202);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(946, 544);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 v0 | Ваганов М.А";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2; 
        private TextBox textBoxTask;
        private Button button1;
        private GroupBox groupBoxTask;
        private TextBox textBoxResult;
        private TextBox textBoxVar;
        private Button buttonHelp;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
