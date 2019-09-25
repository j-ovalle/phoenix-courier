using MaterialSkin;
using MaterialSkin.Controls;
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

namespace PhoenixApp
{
    public partial class LogIn : MaterialForm 
    {
        //string connStr = "Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*";
        string connStr = "Data Source=JEANMICHAEL;Initial Catalog=PhoenixDB;Integrated Security=True";

        // Metodos SQL
        public LogIn()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        private void MaterialLabel1_Click(object sender, EventArgs e)
        {
 
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogin_Click(object sender, EventArgs e) //LogIn
        {
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT Contrasena, TipoPersona, Nombre, Apellidos, IdPersona
                        FROM tblPersona
                        WHERE Usuario = '" + txtUsuario.Text + "';";
                    connDB.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read() && txtContrasena.Text == reader.GetString(0))
                        {
                            if (reader.GetString(1) == "E")
                            {
                               
                                //
                                this.Hide();
                                Empleado x = new Empleado();                               
                                x.ShowDialog();
                                this.Close();

                            }
                            else
                            {
                                string nombre = reader.GetString(2) + " " + reader.GetString(3);
                                int idPersona = reader.GetInt32(4);
                                //Pendiente
                                this.Hide();
                                Cliente x = new Cliente(nombre, idPersona);
                                x.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña no valido");
                        }
                    }
                }
            }
        }
    }
}
