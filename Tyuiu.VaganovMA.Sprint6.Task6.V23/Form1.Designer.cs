namespace Tyuiu.VaganovMA.Sprint6.Task6.V23
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
            groupBox3 = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            buttonOpenFile = new Button();
            groupBox1 = new GroupBox();
            groupBoxOutPutData = new GroupBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult);
            groupBox3.Location = new Point(628, 174);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(581, 506);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 26);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(581, 480);
            textBoxResult.TabIndex = 15;
            textBoxResult.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.MediumOrchid;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Location = new Point(154, 5);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(133, 86);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Открыть файл";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click_1;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(1041, 5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(156, 86);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.BackColor = Color.LightCoral;
            buttonOpenFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonOpenFile.Location = new Point(8, 5);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(125, 86);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "Выполнитель";
            toolTip.SetToolTip(buttonOpenFile, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(8, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1189, 75);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Location = new Point(416, 12);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(469, 57);
            groupBoxOutPutData.TabIndex = 2;
            groupBoxOutPutData.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(517, 60);
            label4.TabIndex = 0;
            label4.Text = resources.GetString("label4.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxLoadFromFile);
            groupBox2.Location = new Point(8, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(620, 398);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLoadFromFile.Location = new Point(12, 26);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(602, 480);
            textBoxLoadFromFile.TabIndex = 1;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подзаголовок";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 572);
            Controls.Add(groupBoxOutPutData);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBox3);
            Controls.Add(buttonOpenFile);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Sprint 6 Task 6 v 23";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Button buttonDone;
        private Button buttonHelp;
        private Button buttonOpenFile;
        private GroupBox groupBox1;
        private Label label4;
        private GroupBox groupBox2;
        private TextBox textBoxLoadFromFile;
        private TextBox textBoxResult;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private GroupBox groupBoxOutPutData;
    }
}
