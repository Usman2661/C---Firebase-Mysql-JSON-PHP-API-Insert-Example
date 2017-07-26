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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating an HTTP Request to the API' Address
           // var request = (HttpWebRequest)WebRequest.Create("http://localhost:3000/employees");

            var request = (HttpWebRequest)WebRequest.Create("http://quickconsult.xyz/mysqlrest/signup.php");

            //Getting text from the text fields and storing them as strings
            String events = textBox2.Text;
            String location = textBox3.Text;
            String ids = textBox1.Text;

            //Posting the json data to the api
         //   var postData = "Event=" + events;
         //   postData += "&Location=" + location;
        //    postData += "&Strategy= Plan A Worked";
        //    postData += "&id=" + ids;

            //Posting the json data to the api
            var postData = "name=" + events;
            postData += "&email=" + location;
            // postData += "&Strategy= Plan A Worked";
            postData += "&pwd=" + ids;
            postData += "&status=" + ids;

            var data = Encoding.ASCII.GetBytes(postData);


            //Specifying the POST Method and the content type
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;


            //Stream to write the data
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            //Getting the HTTP Response

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            MessageBox.Show("Data Successfully inserted to the API", "Data Status");

            //  System.Windows.Forms.MessageBox.Show("Data Successfully Posted To the API");
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
