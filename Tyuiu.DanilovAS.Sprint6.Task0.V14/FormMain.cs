using Tyuiu.DanilovAS.Sprint6.Task0.V14.Lib;
namespace Tyuiu.DanilovAS.Sprint6.Task0.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_DAS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPutX_DAS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInPutX_DAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_DAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПБ-25-1 Данилов Александр Сергевич", "Справка");
        }
    }
}
