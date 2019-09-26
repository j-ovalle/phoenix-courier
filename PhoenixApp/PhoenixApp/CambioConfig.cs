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
    public partial class CambioConfig : MaterialForm
    {
        string connStr = "Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*";
        string nombrePersona;
        int idPersona;
        string contrasena;

        public CambioConfig(string nombrePersona, int idPersona)
        {
            InitializeComponent();

            this.nombrePersona = nombrePersona;
            this.idPersona = idPersona;

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.ControlBox = false;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e) //Cancelar
        {
            this.Hide();
            Cliente x = new Cliente(nombrePersona, idPersona);
            x.ShowDialog();
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e) //Guardar
        {
            if(int.TryParse(txtTelefono.Text, out int n) || txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("Teléfono inválido.");
                return;
            }
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    connDB.Open();

                    if (txtPassActual.Text != string.Empty && txtPassNueva1.Text != string.Empty && txtPassNueva2.Text != string.Empty)
                    {
                        if (contrasena == txtPassActual.Text)
                        {
                            if (txtPassNueva1.Text != txtPassNueva2.Text)
                            {
                                MessageBox.Show("La nueva contraseña no coincide.");
                                return;
                            }
                            else
                            {
                                command.CommandText = @"UPDATE tblPersona SET Contrasena = '" + txtPassNueva1.Text + "', Telefono = '" + txtTelefono.Text + "', Email = '" + txtCorreo.Text + "' WHERE IdPersona = " + idPersona.ToString() + ";";
                                command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña actual es inválida.");
                            return;
                        }
                    }
                    else
                    {
                        command.CommandText = @"UPDATE tblPersona SET Telefono = '" + txtTelefono.Text + "', Email = '" + txtCorreo.Text + "' WHERE IdPersona = " + idPersona.ToString() + ";";
                        command.ExecuteNonQuery();
                    }
                    connDB.Close();

                    MessageBox.Show("Cambios guardados.");

                    this.Hide();
                    Cliente x = new Cliente(nombrePersona, idPersona);
                    x.ShowDialog();
                    this.Close();
                }
            }
        }

        private void CambioConfig_Load(object sender, EventArgs e)
        {
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    command.CommandText = @"SELECT Contrasena, Telefono, Email FROM TblPersona WHERE IdPersona = " + idPersona.ToString() + ";";
                    connDB.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        reader.Read();
                        contrasena = reader.GetString(0);
                        txtTelefono.Text = reader.GetString(1);
                        txtCorreo.Text = reader.GetString(2);
                    }
                }
            }
        }
    }
}
