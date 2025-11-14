using Tyuiu.DanilovAS.Sprint6.Task2.V25.Lib;


namespace Tyuiu.DanilovAS.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергеевич", "Справка");
        }

        private void buttonDone_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartValue_DAS.Text);
                int stopStep = Convert.ToInt32(textBoxStopValue_DAS.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartOutPutResult_DAS.Titles.Add("График функции f(x)");
                this.chartOutPutResult_DAS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutPutResult_DAS.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOutPutResult_DAS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartOutPutResult_DAS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_DAS_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Red;
        }

        private void buttonDone_DAS_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Green;
        }

        private void buttonDone_DAS_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_DAS.BackColor = Color.Blue;
        }

        private void textBoxStartValue_DAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxStopValue_DAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
    
}

