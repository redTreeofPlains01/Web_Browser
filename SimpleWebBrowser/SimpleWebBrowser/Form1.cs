using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleWebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }



        /*  private void button1_Click(object sender, EventArgs e)
          {
              richTextBox1.AppendText("A Button was clciked\r\n");
              //\r\n return line feed and new line
          }

          /// <summary>
          /// this will run every time mouse enters perimeter of button
          /// </summary>
          /// <param name="sender"></param>
          /// <param name="e"></param>
          private void button1_MouseEnter(object sender, EventArgs e)
          {
              richTextBox1.AppendText("A Button was clciked");
          }*/

    }
}
