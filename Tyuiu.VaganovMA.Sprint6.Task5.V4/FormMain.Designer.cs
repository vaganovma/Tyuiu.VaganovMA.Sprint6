
namespace Tyuiu.VaganovMA.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            label4 = new Label();
            groupBox3 = new GroupBox();
            buttonSave = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            textBoxResult = new TextBox();
            groupBox2 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewResult = new DataGridView();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            SuspendLayout();
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
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonSave);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxStop);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Controls.Add(buttonHelp);
            groupBox3.Controls.Add(buttonDone);
            groupBox3.Location = new Point(617, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 75);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.MediumOrchid;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave.Location = new Point(405, 17);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(102, 49);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Открыть файл";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 25);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец хода";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(140, 42);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 3;
            textBoxStop.Text = "5";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(9, 42);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 2;
            textBoxStart.Text = "-5";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(513, 17);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(77, 49);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightCoral;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Location = new Point(283, 17);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 50);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнитель";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 75);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 471);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(296, 480);
            textBoxResult.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewResult);
            groupBox2.Controls.Add(chartFunction);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(12, 93);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1201, 490);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartFunction.BackColor = Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(323, 10);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(878, 480);
            chartFunction.TabIndex = 4;
            chartFunction.Text = "chart1";
            title1.Alignment = ContentAlignment.TopCenter;
            title1.Name = "Title1";
            title1.Text = "График функций Sin(x)";
            chartFunction.Titles.Add(title1);
            chartFunction.Click += chartFunction_Click;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(12, 26);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersVisible = false;
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(290, 458);
            dataGridViewResult.TabIndex = 13;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 598);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "FormMain";
            Text = "Sprint 5 v 4";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ResumeLayout(false);
        }

        private void chartFunction_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label4;
        private GroupBox groupBox3;
        private Button buttonSave;
        private Label label2;
        private Label label1;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBox1;
        private TextBox textBoxResult;
        private GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private DataGridView dataGridViewResult;
    }
}
