using Tyuiu.DanilovAS.Sprint6.Task6.V6.Lib;

namespace Tyuiu.DanilovAS.Sprint6.Task6.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        string openFilePath;
        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DAS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_DAS.ShowDialog();
            openFilePath = openFileDialogTask_DAS.FileName;
            textBoxInPut_DAS.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_DAS.Text = groupBoxInPut_DAS.Text + " " + openFileDialogTask_DAS.FileName;
            buttonDone_DAS.Enabled = true;
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            textBoxOutPut_DAS.Text = ds.CollectTextFromFile(openFilePath);
        }


    }
}
