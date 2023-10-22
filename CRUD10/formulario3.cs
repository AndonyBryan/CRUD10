using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD10
{
    public partial class formulario3 : Form
    {
        string strconn = "Data Source=Matuz;Initial Catalog=CRUD10;Integrated Security=True";

        public formulario3()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (Login(usuario, contraseña))
            {
             
                Form1 formularioPrincipal = new Form1();
                formularioPrincipal.Show();
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("Credenciales incorrectas. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Login(string usuario, string contraseña)
        {
            using (SqlConnection con = new SqlConnection(strconn))
            {
                con.Open();
                string strSQL = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                using (SqlCommand sqlComd = new SqlCommand(strSQL, con))
                {
                    sqlComd.Parameters.AddWithValue("@Usuario", usuario);
                    sqlComd.Parameters.AddWithValue("@Contraseña", contraseña);

                    int count = (int)sqlComd.ExecuteScalar();

                    return count > 0; 
                }
            }
        }
    }
}
