using System;
using Tyuiu.DanilovAS.Sprint6.Task1.V14.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task1.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonResult_DAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_DAS.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_DAS.Text);

                string strLine;
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_DAS.Text = "";
                textBoxResult_DAS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_DAS.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_DAS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len -1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 5:f2}  |", startValue,valueArray[i]);
                    textBoxResult_DAS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textBoxResult_DAS.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергевич", "Справка");
        }
    }
}
