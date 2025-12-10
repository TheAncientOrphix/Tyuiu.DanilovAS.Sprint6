using System.Windows.Forms;
using Tyuiu.DanilovAS.Sprint6.Task5.V14.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task5.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint5\InPutDataFileTask5V14.txt";

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            dataGridViewResult_DAS.ColumnCount = 2;
            //dataGridViewResult_DAS.Columns[0].Width = 30;
            //dataGridViewResult_DAS.Columns[1].Width = 70;

            dataGridViewResult_DAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewResult_DAS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.chartResult_DAS.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartResult_DAS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_DAS.Series[0].Points.Clear();

            double[] numMass = new double[ds.len];

            numMass = ds.LoadFromDataFile(path);

            for(int i =0; i<numMass.Length; i++)
            {
                dataGridViewResult_DAS.Rows.Add(Convert.ToString(i), Convert.ToString(numMass[i]));
                chartResult_DAS.Series[0].Points.AddXY(i, numMass[i]);
            }


        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергеевич", "Справка");
        }

        private void buttonOpenFile_DAS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
