namespace Tyuiu.VaganovMA.Sprint6.Task3.V20
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
            dataGridViewMatrix = new DataGridView();
            textBoxData = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            dataGridViewRes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(359, 26);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(305, 324);
            dataGridViewMatrix.TabIndex = 4;
            // 
            // textBoxData
            // 
            textBoxData.AutoSize = true;
            textBoxData.Location = new Point(6, 43);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(347, 280);
            textBoxData.TabIndex = 0;
            textBoxData.Text = resources.GetString("textBoxData.Text");
            textBoxData.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewMatrix);
            groupBox1.Controls.Add(textBoxData);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 426);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Результат";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewRes);
            groupBox2.Controls.Add(buttonHelp);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(buttonDone);
            groupBox2.Location = new Point(688, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 426);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(41, 385);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(53, 41);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ActiveBorder;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Location = new Point(124, 385);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(146, 41);
            buttonDone.TabIndex = 7;
            buttonDone.Text = "Выполнитель";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Location = new Point(41, 46);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.Size = new Size(305, 324);
            dataGridViewRes.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMatrix;
        private Label textBoxData;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewRes;
    }
}
