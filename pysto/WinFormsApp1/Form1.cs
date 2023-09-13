namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int n;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] m = new int[n];

            for (int i = 0; i < n; i++)
            {

                try
                {
                    m[i] = int.Parse(dataGridView1.Rows[0].Cells[i].Value.ToString());
                    if (m[i] > 10000 && m[i] < 0)
                    {
                        MessageBox.Show("¬ведите целое число в пределпх от 0 до 10000");
                    }
                }
                catch
                {
                    MessageBox.Show("¬ведите целое число в пределпх от 0 до 10000");
                }


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(textBox1.Text);
                if (n <= 0 && n > 30000)
                {
                    MessageBox.Show("¬ведите целое число в пределпх от 1 до 30000");
                }
                else
                {
                    dataGridView1.ColumnCount = n;

                }
            }
            catch
            {
                MessageBox.Show("¬ведите целое число в пределах от 1 до 30000");
            }
        }
    }

}