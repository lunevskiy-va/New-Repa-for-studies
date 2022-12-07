namespace WinForm2
{
    public partial class Form1 : Form
    {
     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Raschet(int b)
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 3);
            if (a == b)
            {
                MessageBox.Show("Вы угадали");
            }
            else
            {
                MessageBox.Show($"Нихуя не угадали {a}");

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Raschet(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raschet(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raschet(3);
        }
    }
}