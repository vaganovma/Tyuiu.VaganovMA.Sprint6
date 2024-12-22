using System.Drawing.Drawing2D;
using Tyuiu.VaganovMA.Sprint6.Task3.V20.Lib;

namespace Tyuiu.VaganovMA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5]{ { -14,  17, - 19,   3,   2 },

                                        {  -4, -14, -19,  -9,  -1 },

                                        {   1,   0,  13,  14,   8, },

                                        {  13,   7,   8,  -3, -15 },

                                        {   2, -20,  12, -14,   4, }};
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int columns =matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            //задаем витрину столбцов
            for (int i = 0; i < columns; i++)
            { 
                dataGridViewMatrix.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 сделал Михаил", "Сообщение", MessageBoxButtons.OK);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);
            int rows = result.GetUpperBound(0) + 1;
            int columns = result.Length / rows;

            dataGridViewRes.ColumnCount = columns;
            dataGridViewRes.RowCount = rows;

            //задаем витрину столбцов
            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
           // dataGridViewRes.Text = Convert.ToString(m);

        }

        
    }
}
