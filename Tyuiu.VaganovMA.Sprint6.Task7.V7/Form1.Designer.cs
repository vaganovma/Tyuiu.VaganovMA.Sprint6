namespace Tyuiu.VaganovMA.Sprint6.Task7.V7
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonSaveFile = new Button();
            buttonDone = new Button();
            buttonOpenFile = new Button();
            buttonHelp = new Button();
            panelTop = new Panel();
            groupBoxTask = new Label();
            groupBox3 = new GroupBox();
            dataGridViewOutput = new DataGridView();
            groupBox2 = new GroupBox();
            dataGridViewInput = new DataGridView();
            groupBox1 = new GroupBox();
            openFileDialog = new OpenFileDialog();
            toolTip = new ToolTip(components);
            saveFileDialog = new SaveFileDialog();
            panelTop.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSaveFile
            // 
            buttonSaveFile.BackColor = Color.MediumSeaGreen;
            buttonSaveFile.Cursor = Cursors.Hand;
            buttonSaveFile.Enabled = false;
            buttonSaveFile.FlatStyle = FlatStyle.Flat;
            buttonSaveFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSaveFile.Image = (Image)resources.GetObject("buttonSaveFile.Image");
            buttonSaveFile.Location = new Point(311, 9);
            buttonSaveFile.Name = "buttonSaveFile";
            buttonSaveFile.Size = new Size(133, 86);
            buttonSaveFile.TabIndex = 15;
            buttonSaveFile.Text = "Скачать файл";
            buttonSaveFile.UseVisualStyleBackColor = false;
            buttonSaveFile.Click += buttonSaveFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.MediumOrchid;
            buttonDone.Cursor = Cursors.Hand;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(153, 9);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(133, 86);
            buttonDone.TabIndex = 14;
            buttonDone.Text = "Выполнить ";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.LightCoral;
            buttonOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 9);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(125, 86);
            buttonOpenFile.TabIndex = 1;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(757, 9);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(156, 86);
            buttonHelp.TabIndex = 19;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonHelp);
            panelTop.Controls.Add(buttonSaveFile);
            panelTop.Controls.Add(buttonDone);
            panelTop.Controls.Add(buttonOpenFile);
            panelTop.Location = new Point(1, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(916, 95);
            panelTop.TabIndex = 17;
            // 
            // groupBoxTask
            // 
            groupBoxTask.AutoSize = true;
            groupBoxTask.Location = new Point(12, 18);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(2173, 20);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.Text = resources.GetString("groupBoxTask.Text");
            groupBoxTask.Click += groupBoxTask_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOutput);
            groupBox3.Location = new Point(623, 173);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(581, 506);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.Location = new Point(6, 26);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.RowHeadersWidth = 51;
            dataGridViewOutput.Size = new Size(575, 324);
            dataGridViewOutput.TabIndex = 16;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewInput);
            groupBox2.Location = new Point(3, 173);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(620, 398);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.Location = new Point(0, 26);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.RowHeadersWidth = 51;
            dataGridViewInput.Size = new Size(614, 324);
            dataGridViewInput.TabIndex = 17;
            dataGridViewInput.CellContentClick += dataGridViewInput_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxTask);
            groupBox1.Location = new Point(1, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1189, 75);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipTitle = "подсказка";
            toolTip.Popup += toolTip_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 597);
            Controls.Add(panelTop);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaveFile;
        private Button buttonDone;
        private Button buttonOpenFile;
        private Button buttonHelp;
        private Panel panelTop;
        private Label groupBoxTask;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOutput;
        private GroupBox groupBox2;
        private DataGridView dataGridViewInput;
        private GroupBox groupBox1;
        private OpenFileDialog openFileDialog;
        private ToolTip toolTip;
        private SaveFileDialog saveFileDialog;
    }
}
