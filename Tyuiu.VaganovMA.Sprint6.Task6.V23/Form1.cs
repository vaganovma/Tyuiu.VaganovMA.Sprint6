using System.IO;
using Tyuiu.VaganovMA.Sprint6.Task6.V23.Lib;

namespace Tyuiu.VaganovMA.Sprint6.Task6.V23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxLoadFromFile.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData.Text = groupBoxOutPutData.Text + " " + openFileDialogTask.FileName;
            buttonDone.Enabled = true;
            //textBoxLoadFromFile.Text = ds.CollectTextFromFile(str, openFilePath);
            //ds.CollectTextFromFile(string path);

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_Click_1(object sender, EventArgs e)
        {
            textBoxResult.Text = string.Empty;
            textBoxResult.BackColor = Color.White;
            //string resstr = "**";
            //textBoxResult.Text = ds.CollectTextFromFile(openFilePath);
            string resstr = ds.CollectTextFromFile(openFilePath);
            textBoxResult.Text = resstr;
            //textBoxLoadFromFile.Text = ds.CollectTextFromFile(str, openFilePath);
            //ds.CollectTextFromFile(string path);
            //string m = "Ошибка";
            //textBoxResult.Text += m;               
            //textBoxResult.BackColor = Color.LightCoral;
        }      
    }
}
