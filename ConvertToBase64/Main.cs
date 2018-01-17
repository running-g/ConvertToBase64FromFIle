using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertToBase64
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.Text = Convert.ToBase64String(File.ReadAllBytes(this.openFileDialog1.FileName));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("出现异常");
            }
        }
    }
}
