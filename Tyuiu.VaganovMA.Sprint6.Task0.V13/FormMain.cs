using Tyuiu.VaganovMA.Sprint6.Task0.V13.Lib;
namespace Tyuiu.VaganovMA.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVar.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                  e.Handled = true;
            }
        }
    }
}
//юююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююююю
//{ 
//    public partial class FormMain : Form
//    {
//        public FormMain()
//        {
//            InitializeComponent();
//        }
//        private void ButtonDone_Click(object sender, EventArgs e)
//        {
//            DataService ds = new DataService(); try
//            {
//                TextBoxResult_AAN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarX.Text)));
//            }
//            catch
//            {
//                MessageBox.Show("Ââåäåíû íåêîððåêòíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//        private void ButtonHelp_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Òàñê 0 âûïîëíèë ñòóäåíò ãðóïïû ÈÈÏá-24-2 Àáðàìóøêèí Àëåêñàíäð Íèêîëàåâè÷");
//        }
//        private void FormMain_Load(object sender, EventArgs e)
//        {
//        }
//        private void groupBox1_Enter(object sender, EventArgs e)
//        {
//        }
//        private void textBox1_TextChanged(object sender, EventArgs e)
//        {
//        }
//        private void textBox1_TextChanged_1(object sender, EventArgs e)
//        {
//        }
//        private void TextBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
//            {
//                e.Handled = true;
//            }
//        }
//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {
//        }
//    }
//}