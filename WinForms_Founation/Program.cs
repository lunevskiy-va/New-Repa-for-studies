namespace WinForms_Founation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            DialogResult proba=MessageBox.Show("Вы готовы дети???","Соглашение",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (proba == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("Пидоры");
            }
        }
    }
}