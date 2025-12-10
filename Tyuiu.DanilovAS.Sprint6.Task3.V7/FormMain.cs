using System.Windows.Forms;
using Tyuiu.DanilovAS.Sprint6.Task3.V7.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
        {
            {31, 25, -18, 12, 9 },
            {6, 34, -2, 2, -18 },
            {-5, 4, 27, 4, -1 },
            {4, 15, 34, -6, -10 },
            {0, 8, 5, 14, -17 }
        };

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергеевич", "Справка");
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {

            //textBoxResult_DAS.Text = Convert.ToString(ds.Calculate(mtrx));
            textBoxResult_DAS.Text = "Матрица изменена!";

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            int[,] resultMatrix = ds.Calculate(mtrx);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_DAS.Rows[i].Cells[j].Value = Convert.ToString(resultMatrix[i,j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_DAS.ColumnCount = columns;
            dataGridViewMatrix_DAS.RowCount = rows;

            for (int i = 0; i< columns; i++)
            {
                dataGridViewMatrix_DAS.Columns[i].Width = 30;
            }

            dataGridViewMatrix_DAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMatrix_DAS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            for (int i = 0; i < rows; i++)
            {
               for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_DAS.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
    }
}
