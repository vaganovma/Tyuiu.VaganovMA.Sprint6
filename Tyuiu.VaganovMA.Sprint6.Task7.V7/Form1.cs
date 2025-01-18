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
            openFileDialog.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialog.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
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

            // ������� ���������� ����� � ��������, ��������:
            rows = 5;  // �������� �� ���� ��������
            columns = 5;  // �������� �� ���� ��������

            // ���������� ������
            int[,] arrayValues = GenerateMatrix(rows, columns, -10, 10); // ������ ������������ �������� �� -10 �� 10
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
            // �������� �� ������������ �����
            int n1 = -10; // ���������� ���� ��������
            int n2 = 10;  // ���������� ���� ��������
            int k = 1;    // ���������� ���� ��������
            int l = 3;    // ���������� ���� ��������
            int c = 2;    // ���������� ���� ��������

            // ��������� �� ������������ ����� (�� ������ �������� ���������������� ����)
            if (n1 >= n2)
            {
                MessageBox.Show("n1 ������ ���� ������ n2");
                return;
            }
            if (k > l)
            {
                MessageBox.Show("K ������ ���� ������ ��� ����� L");
                return;
            }

            int[,] arrayValues = /* �������� ��� ������ */;
            int negativeCount = CountNegativeElements(arrayValues, c, k, l);

            // ���������� ����������
            MessageBox.Show($"���������� ������������� ��������� � ������� {c}: {negativeCount}");
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
            toolTip.ToolTipTitle = "������� ����";
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
