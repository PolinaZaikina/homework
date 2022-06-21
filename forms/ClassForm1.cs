using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Security;


namespace forms
{
    internal class ClassForm1 : Form1
    {
        public ClassForm1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = Text;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void SetText(string text)
        {
            textBox1.Text = text;
        }

        public void button1_Click(object sender, EventArgs e, object listBox1)
        {
            using (FolderBrowserDialog fdb = new FolderBrowserDialog() { Description = "Путь к папке" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {
                    listBox1.DataSource = Directory.GetFiles(fdb.SelectedPath);
                }
            }

            

            if (OpenFileDialog.ShowDialog()
                == DialogResult.OK)
            {
                try
                {
                    //NewMethod();
                    using (var sr = new StreamReader(path: System.Windows.Forms.OpenFileDialog.FileName))
                    {
                        SetText(sr.ReadToEnd());
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error. \n\nError message: {ex.Message}\n\n +" +
                        $"$Details: {ex.StackTrace}");
                }
            }

        }

        //private void NewMethod()
        //{
        //    Path.Text = OpenFileDialog.FileName;
        //}

        private void путь_Click(object sender, EventArgs e)
        {
            // это label
        }

        private void button2_click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string filename = listBox1.GetItemText(listBox1.SelectedItem);

            //string path = "D:\\Тексты";            

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                       
        }
    }
}
