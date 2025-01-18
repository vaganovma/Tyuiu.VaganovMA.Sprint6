using System.IO;
using System.Windows.Forms;
using Tyuiu.VaganovMA.Sprint6.Task7.V7.Lib;

namespace Tyuiu.VaganovMA.Sprint6.Task7.V7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string path;

        DataService ds = new DataService();

        private void buttonHelp_Click(object sender, EventArgs e)
        {

            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;

            // Задайте количество строк и столбцов, например:
            rows = 5;  // Замените на ваше значение
            columns = 5;  // Замените на ваше значение

            // Генерируем массив
            int[,] arrayValues = GenerateMatrix(rows, columns, -10, 10); // Пример генерируемых значений от -10 до 10
            //int[,] arrayValues = new int[rows, columns];
            //arrayValues = LoadFromFileDFate(path);
            DisplayMatrixInDataGridView(dataGridViewInput, arrayValues);

            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)    ////////////................buttonDone_Click 
        {
            int[,] result = ds.GetMatrix(int array[,], int n1, int n2, int c, int k, int l);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = result[i, j];
                }
            }
            buttonSaveFile.Enabled = true;
            // Проверка на корректность ввода
            int n1 = -10; // Установите ваше значение
            int n2 = 10;  // Установите ваше значение
            int k = 1;    // Установите ваше значение
            int l = 3;    // Установите ваше значение
            int c = 2;    // Установите ваше значение

            // Проверяем на корректность ввода (вы можете добавить пользовательский ввод)
            if (n1 >= n2)
            {
                MessageBox.Show("n1 должно быть меньше n2");
                return;
            }
            if (k > l)
            {
                MessageBox.Show("K должно быть меньше или равно L");
                return;
            }

            int[,] arrayValues = /* получите ваш массив */;
            int negativeCount = CountNegativeElements(arrayValues, c, k, l);

            // отображаем количество
            MessageBox.Show($"Количество отрицательных элементов в столбце {c}: {negativeCount}");
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "OutPutTask7.csv"; 
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string path = saveFileDialog.FileName;

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput.Rows.Count;
            int columns = dataGridViewOutput.Columns.Count;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {
            toolTip.ToolTipTitle = "Открыть файл";
        }

        private void groupBoxTask_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv.ColumnCount = columns;
            dgv.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
    }
}
