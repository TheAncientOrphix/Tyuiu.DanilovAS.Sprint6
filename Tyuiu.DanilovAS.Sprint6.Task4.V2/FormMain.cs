using Tyuiu.DanilovAS.Sprint6.Task4.V2.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task4.V2
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
            MessageBox.Show("Таск 4 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергеевич", "Справка");
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

                this.chartFunction_DAS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_DAS.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    textBoxResult_DAS.AppendText(valueArray[i] + Environment.NewLine);
                    this.chartFunction_DAS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Произошла критическая ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartValue_DAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void textBoxStopValue_DAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

        }

        private void buttonSaveFile_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.GetTempPath();
                string path = Path.Combine(tempPath, " OutPutDataFileTask4V2.txt.");

                File.WriteAllText(path, textBoxResult_DAS.Text);

                DialogResult dialogResult = MessageBox.Show($"Файл {path} сохранён успешно!\n Открыть его в блокноте?", "Сообщение",MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                } 
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
