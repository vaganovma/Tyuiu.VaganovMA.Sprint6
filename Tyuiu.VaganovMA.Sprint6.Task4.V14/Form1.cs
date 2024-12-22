using Tyuiu.VaganovMA.Sprint6.Task4.V14.Lib;

namespace Tyuiu.VaganovMA.Sprint6.Task4.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void chartFunction_Click(object sender, EventArgs e)
        {

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {

                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray; //result
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction.Titles.Add("График функции Sin(X)");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult.Text = "";

                chartFunction.Series[0].Points.Clear();
                int index = 0;
                for (int i = startValue; i <= stopValue; i++)
                {

                    //this.dataGridViewFunction.Rows.Add(i, valueArray[index]);
                    //this.chartFunction.Series[0].Points.AddXY(i, valueArray[index]);
                    //index++;

                    {
                        textBoxResult.AppendText(valueArray[index] + Environment.NewLine);
                        this.chartFunction.Series[0].Points.AddXY(i, valueArray[index]);
                        index++;
                    }
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V14.txt");
                File.WriteAllText(path, textBoxResult.Text);

                DialogResult dialogresult = MessageBox.Show($"Файл {path} сохранен успешноí\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogresult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 сделал Михаил", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
