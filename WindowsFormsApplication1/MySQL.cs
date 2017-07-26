using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApplication1
{
    public partial class MySQL : Form
    {
        public MySQL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
            {
               events = "" + textBox2.Text,
               location = "" + textBox3.Text,

               // name = "C#"+ textBox1.Text,
              //  email = "Test"+ textBox2.Text,
             //   pwd = "REST"+ textBox3.Text,
             //   status = "mySQL"+ textBox2.Text,


            });
           // var request = WebRequest.CreateHttp("http://quickconsult.xyz/mysqlrest/signup.php");

            var request = WebRequest.CreateHttp("https://notificationdemo-25713.firebaseio.com/Events.json");
            request.Method = "POST";
            request.ContentType = "application/json";
            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

            MessageBox.Show("Data Successfully inserted to the Firebase API", "Data Status");
        }

        private void button2_Click(object sender, EventArgs e)
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
