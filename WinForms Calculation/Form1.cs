namespace WinForms_Calculation
{
    public partial class Form1 : Form
    {

        string Stroka="0";
        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text= Stroka;
            Stroka = null;
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void knopka1_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 1;
                richTextBox1.Text = Stroka;
            }
           

        }

        private void knopka2_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 1;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka3_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 3;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka4_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 4;
                richTextBox1.Text = Stroka;
            }
        }

        private void Knopka5_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 5;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka6_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 6;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka7_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 7;
                richTextBox1.Text = Stroka;
            }

        }

        private void knopka8_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("0"))
            {
                Stroka += 8;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka9_Click(object sender, EventArgs e)
        {
            if (Stroka != null && !Stroka.EndsWith("0"))
            {
                Stroka += 9;
                richTextBox1.Text = Stroka;
            }
        }

        private void knopka0_Click(object sender, EventArgs e)
        {
            if (Stroka != null&&!Stroka.EndsWith("0"))
            {
                Stroka += 0;
                richTextBox1.Text = Stroka;
            }
         
        }

        private void plus_Click(object sender, EventArgs e)
        {
           if(!Stroka.EndsWith("+")&& !Stroka.EndsWith("-") && !Stroka.EndsWith("*") && !Stroka.EndsWith("/"))
            {
                Stroka += "+";
                richTextBox1.Text = Stroka;
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("+") && !Stroka.EndsWith("-") && !Stroka.EndsWith("*") && !Stroka.EndsWith("/"))
            {
                Stroka += "-";
                richTextBox1.Text = Stroka;
            }
        }

        private void delenie_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("+") && !Stroka.EndsWith("-") && !Stroka.EndsWith("*") && !Stroka.EndsWith("/"))
            {
                Stroka += "/";
                richTextBox1.Text = Stroka;
            }
        }

        private void umnojenie_Click(object sender, EventArgs e)
        {
            if (!Stroka.EndsWith("+") && !Stroka.EndsWith("-") && !Stroka.EndsWith("*") && !Stroka.EndsWith("/"))
            {
                Stroka += "*";
                richTextBox1.Text = Stroka;
            }
        }

        private void ravno_Click(object sender, EventArgs e)
        {

        }

        private void sbros_Click(object sender, EventArgs e)
        {
            Stroka = "0";
            richTextBox1.Text=Stroka;
            Stroka = null;
        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}