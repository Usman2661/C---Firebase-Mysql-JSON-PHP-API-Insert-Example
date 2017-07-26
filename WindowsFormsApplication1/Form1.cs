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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creating an HTTP Request to the API' Address
          //  var request = (HttpWebRequest)WebRequest.Create("http://localhost:3000/employees");

            var request = (HttpWebRequest)WebRequest.Create("http://quickconsult.xyz/mysqlrest/signup.php");

            //Getting text from the text fields and storing them as strings
            String events = textBox1.Text;
            String location = textBox2.Text;
            String ids = textBox3.Text;

            //Posting the json data to the api
         //   var postData = "Event="+events;
         //   postData += "&Location="+location;
         // postData += "&Strategy= Plan A Worked";
         //   postData += "&id="+ ids;



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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(new
               {
              events = ""+textBox1.Text,
                location = ""+textBox2.Text,
              });
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

        private void button3_Click(object sender, EventArgs e)
        {
          //  string urltoRead = "https://notificationdemo-25713.firebaseio.com/Events.json";

           // var json = new WebClient().DownloadString(urltoRead);

         //   MessageBox.Show(json);

            WebClient c = new WebClient();
            var data = c.DownloadString("http://localhost:3000/employees/20122");
            //Console.WriteLine(data);
            JObject o = JObject.Parse(data);

           // label1.Text= ("" + o["Event"]);
          //  label2.Text= ("" + o["Location"]);

    

            // Console.WriteLine("Name: " + o["name"]);
           // Console.WriteLine("Password: " + o["pass"]);
           // Console.WriteLine("Email Address[2]: " + o["email"][1]);
           // Console.WriteLine("Website [home page]: " + o["websites"]["home page"]);
          //  Console.WriteLine("Website [blog]: " + o["websites"]["blog"]);


            Console.ReadLine();
        }

     
        private void button3_Click_2(object sender, EventArgs e)
        {
            try

            {

                //This is my connection string i have assigned the database file address path 

                string MyConnection2 = "Server=185.28.20.9;PORT=3306;Database=u973588786_cshar;Uid=u973588786_cshar;Pwd=pakistan2661";
                
                //This is my insert query in which i am taking input from the user through windows forms 
                 
                string Query = "insert into u973588786_cshar.Events(id,events,location) values('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "');";

                //This is  MySqlConnection here i have created the object and pass my connection string. 

                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                //This is command class which will handle the query and connection object. 

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataReader MyReader2;

                MyConn2.Open();

                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database. 

                MessageBox.Show("Data Succesfully Saved to MySQL"); 

                while (MyReader2.Read())

                {

                }

                MyConn2.Close();

            }

            catch (Exception ex)

            {



                MessageBox.Show(ex.Message);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            HomPage Check = new HomPage();
            Check.Show();
            Hide();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            HomPage Check = new HomPage();
            Check.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MySQL Check = new MySQL();
            Check.Show();
            Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
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
