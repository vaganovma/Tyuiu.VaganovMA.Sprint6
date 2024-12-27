using System.IO;
using System.Windows.Forms;
using Tyuiu.VaganovMA.Sprint6.Task7.V17.Lib;

namespace Tyuiu.VaganovMA.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string path;

        DataService ds = new DataService();

        private int[,] LoadFromFileDFate(string filename)
        {
            string text = File.ReadAllText(path);
            //разделение на строки
            text = text.Replace('\n', '\r');
            string[] lines = text.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            //опред кол столбц и строк
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            //Выделите массив данных
            int[,] array = new int[rows, columns];
            //Заполнить массив данных
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileDFate(path);

            dataGridViewInput.ColumnCount = columns;
            dataGridViewInput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;
            dataGridViewOutput.RowCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput.Columns[i].Width = 40;
                dataGridViewOutput.Columns[i].Width = 40;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            // arrayValues
            buttonDone.Enabled = true;
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

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] result = ds.GetMatrix(path);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutput.Rows[i].Cells[j].Value = result[i, j];
                }
            }
            buttonSaveFile.Enabled = true;
        }
    }
}
