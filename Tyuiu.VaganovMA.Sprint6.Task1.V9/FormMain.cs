using Tyuiu.VaganovMA.Sprint6.Task1.V9.Lib;
namespace Tyuiu.VaganovMA.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
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
                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray; //result
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult.Text = "";
                //textBoxResult.AppendText("************************************************************************");
                //textBoxResult.AppendText("* РЕЗУЛЬТАТ:                                                           *");
                //Console.WriteLine("************************************************************************");

                textBoxResult.AppendText("+--------+---------+" + Environment.NewLine);
                textBoxResult.AppendText("+    X   |   f(x)  +" + Environment.NewLine);
                textBoxResult.AppendText("+--------+---------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1, 5:f2}  |", startValue, valueArray[i]);
                    textBoxResult.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult.AppendText("+--------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 сделал Михаил", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBoxStop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
