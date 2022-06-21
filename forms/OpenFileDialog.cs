using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace forms
{
    internal class OpenFileDialog : Form1
    {
        [STAThread]
        public static void Open()
        {

            Application.Run(new OpenFileDialog());
        }
        public Button button1;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        //private readonly TextBox textBox1;

        public OpenFileDialog()
        {
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();

            button1 = new Button
            {
                Size = new Size(100, 20),
                Location = new Point(15, 15),
                Text = "Select file"
            };
            button1.Click += new EventHandler(Button1_Click);
            textBox1 = new TextBox
            {
                Size = new Size(330, 360),
                Location = new Point(15, 40),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };
            ClientSize = new Size(330, 360);
            Controls.Add(button1);
            Controls.Add(textBox1);
        }

        public new void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
