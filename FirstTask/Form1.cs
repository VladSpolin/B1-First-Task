using System;

using System.Linq;

using System.Windows.Forms;

namespace FirstTask
{
    public partial class Form1 : Form
    {
        private readonly Generator generator = new Generator();
        private readonly FileMethods methods = new FileMethods();
        private readonly ApplicationContext applicationContext = new ApplicationContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateFilesButton_Click(object sender, EventArgs e)
        {
            int files, lines;
            if (Int32.TryParse(textBox2.Text,out files) && Int32.TryParse(textBox3.Text, out lines))
                generator.GenerateFiles(files, lines);
        }

        private void CombineFilesButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==string.Empty)
            {
                methods.Combine();
            }
            else
            {
                int deletedLines = 0;
                methods.CombineWithValue(textBox1.Text, out deletedLines);
                MessageBox.Show($"{deletedLines} were deleted.");
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        { 
            methods.ImportFilesToDb(new Progress<int>(x => { this.progressBar1.Value = x; RefreshImportInfo();}), 
                new Progress<int>(x => this.progressBar1.Maximum = x));
        }

        private void ClearFolderButton_Click(object sender, EventArgs e)
        {
            methods.CLearFolder();
        }

        private void OpenFolderButton_Click(object sender, EventArgs e)
        {
            methods.OpenFolder();

        }

         public void RefreshImportInfo()
        {

            label4.Text = $"{progressBar1.Value} imported, {progressBar1.Maximum - progressBar1.Value} left.";
            if (progressBar1.Value == progressBar1.Maximum)
                progressBar1.Value = 0;

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            var x = applicationContext.Database.SqlQuery<long>("IntSum"); //first stored procedure 
            label4.Text = "sum = " + x.First().ToString();
        }

        private void MedianButton_Click(object sender, EventArgs e) // the second stored procedure 
        {
            var x = applicationContext.Database.SqlQuery<double>("MedianOfNonInt");
            label4.Text ="median = " + x.First().ToString();
        }
    }
}
