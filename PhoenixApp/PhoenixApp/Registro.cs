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
    public partial class Registro : MaterialForm
    {
        string connStr = "Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*";

        public Registro()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn x = new LogIn();
            x.ShowDialog();
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT tblSucursal.NombreSucursal, tblSector.NombreSector
                        FROM tblSucursal
                        FULL OUTER JOIN tblSector ON tblSucursal.IdSucursal = tblSector.IdSector;";
                    connDB.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if(!reader.IsDBNull(0))
                                cbxSucursal.Items.Add(reader.GetString(0));
                            if(!reader.IsDBNull(1))
                                cbxSector.Items.Add(reader.GetString(1));
                        }
                    }
                    connDB.Close();
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int IdDireccion = 0;
            if (txtNombre.Text != string.Empty && txtApellidos.Text != string.Empty && txtCedula.Text != string.Empty &&
                txtCorreo.Text != string.Empty && txtTelefono.Text != string.Empty && txtDireccion.Text != string.Empty &&
                txtNumResidencia.Text != string.Empty && cbxSector.Text != string.Empty && cbxSucursal.Text != string.Empty &&
                txtUsuario.Text != string.Empty && txtPass1.Text != string.Empty && txtPass2.Text != string.Empty)
            {
                
               #region Checkers
                if (txtPass1.Text != txtPass2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden.");
                    return;
                }
                if (!txtCedula.Text.All(char.IsDigit) || txtCedula.Text.Length != 11)
                {
                    MessageBox.Show("Cédula inválida.");
                    return;
                }
                if (!txtTelefono.Text.All(char.IsDigit) || txtTelefono.Text.Length != 10)
                {
                    MessageBox.Show("Teléfono inválido.");
                    return;
                }
                if (!txtNumResidencia.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Número de residencia inválido.");
                    return;
                }
                #endregion

                using (var connDB = new SqlConnection(connStr))
                {
                    using (var command = connDB.CreateCommand())
                    {
                        //Insert Direccion
                        command.CommandText = @"
                            INSERT INTO tblDireccion (Calle, NumResidencia, IdSector)
                            OUTPUT inserted.IdDireccion
                            SELECT '"+ txtDireccion.Text + "',"+ txtNumResidencia.Text +", IdSector FROM tblSector WHERE NombreSector = '"+cbxSector.Text+"';";
                        connDB.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IdDireccion = reader.GetInt32(0);
                            }
                        }

                        //Insert Persona
                        command.CommandText = @"
                            INSERT INTO tblPersona (Nombre, Apellidos, Usuario, Contrasena, Cedula, Email, Telefono, Estado, IdDireccion, IdSucursal, TipoPersona, FechaRegistro)
                            OUTPUT inserted.IdPersona
                            SELECT '" + txtNombre.Text + "', '" + txtApellidos.Text + "', '" + txtUsuario.Text + "', '" + txtPass1.Text + "', '" + txtCedula.Text + "', '" + txtCorreo.Text + "', " + txtTelefono.Text + ",'A', " + IdDireccion.ToString() + ", IdSucursal, 'C', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "' FROM tblSucursal WHERE NombreSucursal = '" + cbxSucursal.Text + "';";

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Tu ID Phoenix es " + (reader.GetInt32(0)).ToString());
                            }
                        }
                        connDB.Close();
                    }
                    this.Hide();
                    LogIn x = new LogIn();
                    x.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, llena todos los campos.");
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
