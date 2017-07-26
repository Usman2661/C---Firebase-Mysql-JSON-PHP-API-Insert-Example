using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HomPage : Form
    {
        public HomPage()
        {
            InitializeComponent();
        }

        private void HomPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySQL Check = new MySQL();
            Check.Show();
            Hide();
        }

        private void mysql_Click(object sender, EventArgs e)
        {

            Form1 Check = new Form1();
            Check.Show();
            Hide();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            HomPage Check = new HomPage();
            Check.Show();
            Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySQL Check = new MySQL();
            Check.Show();
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1();
            Check.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 Check = new Form2();
            Check.Show();
            Hide();
        }
    }
}
