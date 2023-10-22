using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CRUD10
{
    public partial class Form1 : Form
    {
        string strconn = "Data Source=Matuz;Initial Catalog=CRUD10;Integrated Security=True";
        private bool camposCambiados = false; 
        public Form1()
        {
            InitializeComponent();
        }

        private void txtagregar_Click(object sender, EventArgs e)
        {
            insert(textmatricula.Text, textnombre.Text, textcarrera.Text);
            ConfigurarDataGridView();
        }

        private void insert(string Matricula, string Nombre, string Carrera)
        {
            SqlConnection con = new SqlConnection(strconn);
            string strSQL = "INSERT INTO Employer VALUES ('" + Matricula + "', '" + Nombre + "', '" + Carrera + "');";
            SqlCommand sqlComd = new SqlCommand(strSQL, con);
            con.Open();
            sqlComd.ExecuteNonQuery();
            con.Close();
        }

        private void txtactualizar_Click(object sender, EventArgs e)
        {
            update(textmatricula.Text, textnombre.Text, textcarrera.Text);
            ConfigurarDataGridView();
        }

        private void update(string Matricula, string Nombre, string Carrera)
        {
            using (SqlConnection con = new SqlConnection(strconn))
            {
                con.Open();
                string strSQL = "UPDATE Employer SET Nombre = @Nombre, Carrera = @Carrera WHERE Matricula = @Matricula";
                using (SqlCommand sqlComd = new SqlCommand(strSQL, con))
                {
                    sqlComd.Parameters.AddWithValue("@Nombre", Nombre);
                    sqlComd.Parameters.AddWithValue("@Carrera", Carrera);
                    sqlComd.Parameters.AddWithValue("@Matricula", Matricula);
                    sqlComd.ExecuteNonQuery();
                }
            }
        }

        private void txteliminar_Click(object sender, EventArgs e)
        {
            delete(textmatricula.Text);
            ConfigurarDataGridView();
        }

        private void delete(string Matricula)
        {
            using (SqlConnection con = new SqlConnection(strconn))
            {
                con.Open();
                string strSQL = "DELETE FROM Employer WHERE Matricula = @Matricula";
                using (SqlCommand sqlComd = new SqlCommand(strSQL, con))
                {
                    sqlComd.Parameters.AddWithValue("@Matricula", Matricula);
                    sqlComd.ExecuteNonQuery();
                }
            }
        }

        private void txtbuscar_Click(object sender, EventArgs e)
        {
            var result = search(textmatricula.Text);
            if (result != null)
            {
                textnombre.Text = result.Item1;
                textcarrera.Text = result.Item2;
            }
        }

        private Tuple<string, string> search(string Matricula)
        {
            using (SqlConnection con = new SqlConnection(strconn))
            {
                con.Open();
                string strSQL = "SELECT Nombre, Carrera FROM Employer WHERE Matricula = @Matricula";
                using (SqlCommand sqlComd = new SqlCommand(strSQL, con))
                {
                    sqlComd.Parameters.AddWithValue("@Matricula", Matricula);
                    using (SqlDataReader reader = sqlComd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nombre = reader["Nombre"].ToString();
                            string carrera = reader["Carrera"].ToString();
                            return Tuple.Create(nombre, carrera);
                        }
                    }
                }
            }
            return null;
        }

        private void textmatricula_TextChanged(object sender, EventArgs e)
        {
            
            camposCambiados = true;
        }

        private void textnombre_TextChanged(object sender, EventArgs e)
        {
           
            camposCambiados = true;
        }

        private void textcarrera_TextChanged(object sender, EventArgs e)
        {
          
            camposCambiados = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            if (camposCambiados)
            {
                update(textmatricula.Text, textnombre.Text, textcarrera.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            using (SqlConnection con = new SqlConnection(strconn))
            {
                con.Open();
                string strSQL = "SELECT Matricula, Nombre, Carrera FROM Employer";
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(strSQL, con))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
          

 
        }
    }
}
