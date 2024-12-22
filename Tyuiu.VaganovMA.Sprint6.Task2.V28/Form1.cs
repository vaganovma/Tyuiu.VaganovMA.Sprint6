using Tyuiu.VaganovMA.Sprint6.Task2.V28.Lib;
//using System.Windows.Forms;
    //using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.VaganovMA.Sprint6.Task2.V28;
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    DataService ds = new DataService();
    private void button1_Click(object sender, EventArgs e)
    {
        try
        {

            int startValue = Convert.ToInt32(textBoxStart.Text);
            int stopValue = Convert.ToInt32(textBoxStop.Text);

            //Console.WriteLine("старт шага:" + startValue);
            //Console.WriteLine("конец шага:" + stopValue);
           // string strLine;
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray; //result
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);
            this.chartFunction.Titles.Add("График функции Sin(X)");

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";
            //textBoxResult.Text = "";
            int index = 0;
            for (int i = startValue; i <= stopValue; i++) 
            {
                //this.dataGridViewFunction.Rows.Add(Convert.ToInt32(textBoxStart.Text), Convert.ToString(valueArray[i]));
                //this.chartFunction.Series[0].Points.AddXY(startValue, valueArray[i]);
                //startValue++;
                this.dataGridViewFunction.Rows.Add(i, valueArray[index]);
                this.chartFunction.Series[0].Points.AddXY(i, valueArray[index]);
                index++;
                //  strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  |", startValue, valueArray[i]);
                //  textBoxResult.AppendText(strLine + Environment.NewLine);
                //  startValue++;
            }


        }
        catch
        {
            MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void textBoxStop_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
    {
        //if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
        //{
        //    e.Handled = true;
        //}
    }

    private void button2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Таск 2 сделал Михаил", "ошибка", MessageBoxButtons.OK);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void chartFunction_Click(object sender, EventArgs e)
    {

    }

    private void buttonDone_MouseEnter(object sender, EventArgs e)
    {
        buttonDone.BackColor = Color.Green;
    }

    private void buttonDone_MouseDown(object sender, MouseEventArgs e)
    {
        buttonDone.BackColor = Color.Blue;
    }

    private void buttonDone_MouseLeave(object sender, EventArgs e)
    {
        buttonDone.BackColor = Color.Coral;
    }

    private void textBoxResult_TextChanged(object sender, EventArgs e)
    {

    }
}
