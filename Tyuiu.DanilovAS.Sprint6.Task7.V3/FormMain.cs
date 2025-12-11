using Tyuiu.DanilovAS.Sprint6.Task7.V3.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task7.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_DAS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_DAS.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string file = File.ReadAllText(filePath);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpenFile_DAS_Click(object sender, EventArgs e)
        {
            openFileDialog_DAS.ShowDialog();
            openFilePath = openFileDialog_DAS.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_DAS.RowCount = rows;
            dataGridViewInPut_DAS.ColumnCount = columns;
            dataGridViewOutPut_DAS.RowCount = rows;
            dataGridViewOutPut_DAS.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_DAS.Columns[i].Width = 50;
                dataGridViewOutPut_DAS.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_DAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_DAS.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_DAS.ColumnCount = 50;
            dataGridViewOutPut_DAS.ColumnCount = 50;

            dataGridViewInPut_DAS.RowCount = 50;
            dataGridViewOutPut_DAS.RowCount = 50;
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_DAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_DAS.Enabled = true;
        }

        private void buttonSave_DAS_Click(object sender, EventArgs e)
        {
            saveFileDialog_DAS.FileName = "OutPutFileTask7V3.csv";
            saveFileDialog_DAS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_DAS.ShowDialog();

            string path = saveFileDialog_DAS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_DAS.RowCount;
            int columns = dataGridViewOutPut_DAS.ColumnCount;

            string str = "";

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_DAS.Rows[i].Cells[j].Value + ";" ;
                    }
                    else
                    {
                        str += dataGridViewOutPut_DAS.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path,str+Environment.NewLine);
                    str = "";
                }
            }
        }
    }
}
