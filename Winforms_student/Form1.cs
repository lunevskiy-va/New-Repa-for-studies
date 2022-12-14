namespace Winforms_student
{
    public partial class Form1 : Form
    {

        List<Student> students=new List<Student> {new Student("Виталий","Луневский","СТ-3",new DateOnly(1991,1,1)),
        new Student("Константин","Бойко","СТ-3",new DateOnly(1986,1,1)),
        new Student("Виталий","Медведев","СТ-3",new DateOnly(1980,1,1)),
        new Student("Денис","Фишман","СТ-3",new DateOnly(1979,1,1))};
        public Form1()
        {
            InitializeComponent();
            listBox1.DataSource= students;
            listBox1.DisplayMember= "lastname";
            listBox1.MouseClick += ListBox1_MouseClick;

        }

        private void ListBox1_MouseClick(object? sender, MouseEventArgs e)
        {
            Student one = (Student)listBox1.SelectedItem;
            MessageBox.Show(one.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}