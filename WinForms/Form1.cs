namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет! " + textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не жми");
        }
    }
}