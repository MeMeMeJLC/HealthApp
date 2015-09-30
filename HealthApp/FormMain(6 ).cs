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
            // TODO: This line of code loads data into the 'healthDatabaseDataSet.Symptom' table. You can move, or remove it, as needed.
            this.symptomTableAdapter.Fill(this.healthDatabaseDataSet.Symptom);
            // TODO: This line of code loads data into the 'healthDatabaseDataSet.EnvironmentalFactor' table. You can move, or remove it, as needed.
            this.environmentalFactorTableAdapter.Fill(this.healthDatabaseDataSet.EnvironmentalFactor);
            PopulateEnvironmentalFactor();
           // PopulateAllSymptoms();
        }

        private void PopulateEnvironmentalFactor()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("select * from EnvironmentalFactor order by envirFactorID desc", connection))
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

                DataTable problemAreaTable = new DataTable();

                try
                {
                    adapter.Fill(problemAreaTable);
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

               /* listBoxDateSymptoms.DisplayMember = "problemArea";   //separate these out into separate functions each with own specific query
                listBoxDateSymptoms.ValueMember = "symptomId";
                listBoxDateSymptoms.DataSource = problemAreaTable;*/
            }
        }

        private void PopulateSymptomDesc()
        {
            string query = "select symptondesc from Symptom a " +
                "inner join EnvironmentalFactor b on a.envirFactID = b.envirFactorID " +
                "where b.envirFactorID = @envirID"; //taking in a parameter @envirid

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@envirID", listBoxDates.SelectedValue);

                DataTable symptomDescTable = new DataTable();

                try
                {
                    adapter.Fill(symptomDescTable); 
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

               /* listBoxSymptomDesc.DisplayMember = "symptondesc";
                listBoxSymptomDesc.ValueMember = "symptomId";
                listBoxSymptomDesc.DataSource = symptomDescTable;*/

            }
        }

        private void PopulateSymptomSev()
        {
            string query = "select  subjectiveSymptomSeverity from Symptom a " +
                "inner join EnvironmentalFactor b on a.envirFactID = b.envirFactorID " +
                "where b.envirFactorID = @envirID"; //taking in a parameter @envirid

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@envirID", listBoxDates.SelectedValue);

                DataTable symptomSevTable = new DataTable();
                try
                {
                    adapter.Fill(symptomSevTable);
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

               /* listBoxSympSeverity.DisplayMember = "subjectiveSymptomSeverity";
                listBoxSympSeverity.ValueMember = "symptomId";
                listBoxSympSeverity.DataSource = symptomSevTable;*/
            }
        }

        private void listBoxHealth_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* PopulateSymptom(); //load symptoms when listboxdate changes
            PopulateSymptomDesc();
            PopulateSymptomSev();*/


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

                string city = txtBoxCity.Text;
                HttpClient client = new HttpClient();
                Weather_Demo.Weather_Object.RootObject rootObject;
                string x = await client.GetStringAsync(new Uri("http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&APPID=ae0b14522107e76a919560f8b1c08833"));
                rootObject = JsonConvert.DeserializeObject<Weather_Demo.Weather_Object.RootObject>(x);
                double currentTemp = rootObject.main.temp;
                command.Parameters.AddWithValue("@temp", currentTemp);

                command.Parameters.AddWithValue("@subjectiveOverallHealthNum", int.Parse(txtBxOverallHealthNum.Text));

                command.ExecuteNonQuery();
            }
                PopulateEnvironmentalFactor();
        }

        private void lblOverallHealthNum_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e) //btnCreateSymptom
        {
            string query = "INSERT INTO Symptom VALUES (@problemArea, @symptomDesc, @envirFactorID, @symptomSeverity)";


            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            {
                connection.Open();


                //command.Parameters.AddWithValue("@envirFactorID", 8);

                //DateTime localDate = DateTime.Now;
                command.Parameters.AddWithValue("@problemArea", textBoxProblemArea.Text);
                command.Parameters.AddWithValue("@symptomDesc", textBoxSymptomDescription.Text);
                command.Parameters.AddWithValue("@envirFactorID", listBoxDates.SelectedValue);
                command.Parameters.AddWithValue("@symptomSeverity", int.Parse(textBoxSymptomSeverity.Text));

                command.ExecuteNonQuery();
            }
         /*   PopulateSymptom();
            PopulateSymptomDesc();
            PopulateSymptomSev();*/
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBoxAllSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxDateSymptoms_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* string query = "select symptomDesc from Symptom " +
            "where symptomID = @symptomID"; //taking in a parameter @sympid

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))  //handles queries with parameters
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@symptomID", listBoxDateSymptoms.SelectedValue);

               // lblDisplaySympDesc.Text = "symptomDesc";

            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDisplayHealthData_Click(object sender, EventArgs e)
        {
            string query = "SELECT date, temp, subjectiveOverallHealthScore, problemArea, SymptonDesc, subjectiveSymptomSeverity " +
                "from Symptom a INNER JOIN EnvironmentalFactor b ON a.envirFactID = b.envirFactorID " +
                "ORDER BY envirFactorID desc, symptomID desc";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable healthDataTable = new DataTable();
            adapter.Fill(healthDataTable);

            dataGridView2.DataSource = healthDataTable;
        }

        private void btnDisplayBySeverity_Click(object sender, EventArgs e)
        {
            string query = "SELECT subjectiveSymptomSeverity , problemArea, SymptonDesc, date, temp, subjectiveOverallHealthScore " +
                "from Symptom a INNER JOIN EnvironmentalFactor b ON a.envirFactID = b.envirFactorID " +
                "ORDER BY subjectiveSymptomSeverity desc, symptomID desc";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter2 = new SqlDataAdapter(query, connection);

            DataTable healthDataTable = new DataTable();
            adapter2.Fill(healthDataTable);

            dataGridView2.DataSource = healthDataTable;
        }

        private void btnDisplayByTemp_Click(object sender, EventArgs e)
        {
            string query = "SELECT temp, date, subjectiveOverallHealthScore, subjectiveSymptomSeverity , problemArea, SymptonDesc " +
                "from Symptom a INNER JOIN EnvironmentalFactor b ON a.envirFactID = b.envirFactorID " +
                "ORDER BY temp desc, symptomID desc";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter2 = new SqlDataAdapter(query, connection);

            DataTable healthDataTable = new DataTable();
            adapter2.Fill(healthDataTable);

            dataGridView2.DataSource = healthDataTable;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show("SymTrack v1.0 is to give a way for people to record there symptoms each day. \r \n " +
                "SymTrack also gathers weather data to see if there is any correlation between weather and health symptoms. \r \n" +
                " Developed by Jeremy Cook. Contact at Jeremy.Cook.LLB@live.com." );
        }
    }
}
