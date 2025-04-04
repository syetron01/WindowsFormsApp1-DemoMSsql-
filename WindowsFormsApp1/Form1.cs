using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Connection string - modify this to match your database
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\61541-24226615\Documents\DemoDataBase.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                student.IdNumber = Convert.ToInt32(IdNumTextBox.Text);
                student.Name = NameTextBox.Text;

                // Save to database
                SaveStudentToDatabase(student);

                MessageBox.Show(student.ToString() + "\n\nStudent saved to database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        S
        private void SaveStudentToDatabase(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL command to insert the student data
                string query = "INSERT INTO dbo.[Table] (Id, Name) VALUES (@Id, @Name)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Id", student.IdNumber);
                    command.Parameters.AddWithValue("@Name", student.Name);

                    // Open connection and execute the command
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // Add this method to retrieve students from the database
        private List<Student> GetStudentsFromDatabase()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM dbo.[Table]";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                IdNumber = Convert.ToInt32(reader["Id"]),
                                Name = reader["Name"].ToString()
                            };
                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        private void ViewDataButton_Click_1(object sender, EventArgs e)
        {
            // Create a simple display form
            Form dataForm = new Form();
            dataForm.Text = "Student Data";
            dataForm.Size = new Size(400, 300);

            DataGridView grid = new DataGridView();
            grid.Dock = DockStyle.Fill;
            dataForm.Controls.Add(grid);

            // Fill the grid with data
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Name FROM dbo.[Table]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                grid.DataSource = table;
            }

            dataForm.ShowDialog();
        }
    }
}