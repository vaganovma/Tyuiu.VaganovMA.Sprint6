namespace Tyuiu.VaganovMA.Sprint6.Task2.V28
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            groupBox3 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBox2 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Fx = new DataGridViewTextBoxColumn();
            label3 = new Label();
            textBoxResult = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(137, 67);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 3;
            textBoxStop.Text = "5";
            textBoxStop.TextChanged += textBoxStop_TextChanged;
            textBoxStop.KeyPress += textBoxStart_KeyPress;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 67);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 2;
            textBoxStart.Text = "-5";
            textBoxStart.KeyPress += textBoxStart_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxStop);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Controls.Add(buttonHelp);
            groupBox3.Controls.Add(buttonDone);
            groupBox3.Location = new Point(12, 300);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 133);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 44);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 5;
            label2.Text = "Конец хода";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "Старт шага";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MistyRose;
            buttonHelp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonHelp.Location = new Point(271, 26);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(77, 101);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += button2_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LightCoral;
            buttonDone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDone.Location = new Point(354, 26);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(116, 101);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнитель";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += button1_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartFunction);
            groupBox2.Controls.Add(dataGridViewFunction);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(494, 17);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 416);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(244, 23);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(484, 393);
            chartFunction.TabIndex = 4;
            chartFunction.Text = "chart1";
            title1.Alignment = ContentAlignment.MiddleLeft;
            title1.Name = "Title2";
            title1.Text = "Ось Y";
            title2.Alignment = ContentAlignment.TopCenter;
            title2.Name = "Title1";
            title2.Text = "График функций Sin(x)";
            chartFunction.Titles.Add(title1);
            chartFunction.Titles.Add(title2);
            chartFunction.Click += chartFunction_Click;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, Fx });
            dataGridViewFunction.Location = new Point(40, 53);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(183, 324);
            dataGridViewFunction.TabIndex = 3;
            dataGridViewFunction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Fx
            // 
            Fx.HeaderText = "F(X)";
            Fx.MinimumWidth = 6;
            Fx.Name = "Fx";
            Fx.Width = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 23);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(0, 362);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(276, 342);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 277);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 43);
            label4.Name = "label4";
            label4.Size = new Size(529, 80);
            label4.TabIndex = 0;
            label4.Text = "Написать программу, которая выводит таблицу значений функции:\r\n F(x) = sin(x)-2x + sin(x) 3x-1 3x + 2 \r\n\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Спринт 6 | Таск 2 v28 | Ваганов М.А";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Button buttonHelp;
        private Button buttonDone;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox textBoxResult;
        private GroupBox groupBox1;
        private Label label4;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
