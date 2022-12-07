using System.Transactions;

namespace WinForm3
{
    public partial class Form1 : Form
    {
        string text1;
        string text2 ;
        string text3 ;
        int i = 0;
        public Form1()
        {
            InitializeComponent();

            textBox1.TextChanged += textBox1_TextChanged;
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            




        }

        //private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        button1_Click(sender, e);
        //    }
        //}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

                    }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                MessageBox.Show("Hello!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
                i++;
                if (i == 1)
                {
                    text1 = textBox1.Text;
                    
                        MessageBox.Show(text1);
                }
                if (i == 2)
                {
                    text2 = textBox1.Text;
                    MessageBox.Show(text2, "Nihuya");
                }
                if (i == 3)
                {
                    text3 = textBox1.Text;
                    int dlina = (text1.Length + text2.Length + text3.Length) / 3;
                    MessageBox.Show(text3, dlina.ToString());

                }
            
            
        }
    }
}