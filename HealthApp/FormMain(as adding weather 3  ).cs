using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Http;
using Newtonsoft.Json;

namespace HealthApp
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["HealthApp.Properties.Settings.HealthDatabaseConnectionString"].ConnectionString;
        }

        private void FromMain_Load(object sender, EventArgs e)
        {
            PopulateEnvironmentalFactor();
        }

        private void PopulateEnvironmentalFactor()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from EnvironmentalFactor", connection))
            {
                DataTable environmentalFactorTable = new DataTable();
                adapter.Fill(environmentalFactorTable);

                listBoxDates.DisplayMember = "date";
                listBoxDates.ValueMember = "envirFactorID";
                listBoxDates.DataSource = environmentalFactorTable;
            }

        }

        private void PopulateSymptom()
        {
            string query = "select problemArea from Symptom a " +
                "inner join EnvironmentalFactor b on a.envirFactID = b.envirFactorID " +
                "where b.envirFactorID = @envirID"; //taking in a parameter @envirid

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@envirID", listBoxDates.SelectedValue);

                DataTable symptomTable = new DataTable();
                try
                {
                    adapter.Fill(symptomTable);
                }
                catch (SqlException e)
                {
                    StringBuilder errorMessages = new StringBuilder();

                    for (int i = 0; i < e.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + e.Errors[i].Message + "\n" +
                            "LineNumber: " + e.Errors[i].LineNumber + "\n" +
                            "Source: " + e.Errors[i].Source + "\n" +
                            "Procedure: " + e.Errors[i].Procedure + "\n");
                    }
                    Console.WriteLine(errorMessages.ToString());

                }

                listBoxDateSymptoms.DisplayMember = "problemArea";
                listBoxDateSymptoms.ValueMember = "symptomId";
                listBoxDateSymptoms.DataSource = symptomTable;
            }
        }
        private void listBoxHealth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //testing if listboxenvirfactors works
            //MessageBox.Show(listBoxHealth.SelectedValue.ToString());

            PopulateSymptom(); //load symptoms when listboxdate changes
        }

        private async void btnEnvirFactorsCreate_Click(object sender, EventArgs e)
        {
            //string query = "INSERT INTO EnvironmentalFactor VALUES (/*@envirFactorID ,@date, @temp, @subjectiveOverallHealthNum)";
            string query = "INSERT INTO EnvironmentalFactor VALUES (@date, @temp, @subjectiveOverallHealthNum)";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            {
                connection.Open();


                //command.Parameters.AddWithValue("@envirFactorID", 8);

                DateTime localDate = DateTime.Now;
                command.Parameters.AddWithValue("@date", localDate);

                // Calls the method 'getWeather' and passes it the string 'city'.

                string city = txtBoxCity.Text;
                // getWeather(city); 
                HttpClient client = new HttpClient();
                Weather_Demo.Weather_Object.RootObject rootObject;
                string x = await client.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&APPID=440e3d0ee33a977c5e2fff6bc12448ee"));
                rootObject = JsonConvert.DeserializeObject<Weather_Demo.Weather_Object.RootObject>(x);
                double currentTemp = rootObject.main.temp;

                command.Parameters.AddWithValue("@temp", 5);

                command.Parameters.AddWithValue("@subjectiveOverallHealthNum", int.Parse(txtBxOverallHealthNum.Text));

                
                command.ExecuteNonQuery();
            }
        }

        private void lblOverallHealthNum_Click(object sender, EventArgs e)
        {

        }
    }
}
