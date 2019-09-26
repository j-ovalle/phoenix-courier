using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixApp
{
    public partial class Empleado : MaterialForm
    {
        SqlConnection connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*");
        SqlDataAdapter SqlAdapter = new SqlDataAdapter();

        int idCliente = 0;

        public Empleado()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        // Metodos propios
        private void Clear()
        {
            this.txtDescrip.ResetText();
            this.cbxProveedor.ResetText();
            this.txtPeso.ResetText();
            this.txtIDCliente.ResetText();
            this.cbxSucursal.ResetText();
            this.dtpFecha.ResetText();
        }

        private void GetAllPackages()
        {
            connStr.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter(@"Select IdPaquete, IdCliente, Descripcion, Peso, Costo, EstadoPaquete as Estado, FechaEstado as 'Fecha de Estado' , NombreProveedor as Proveedor ,NombreSucursal as Sucursal, FechaRegistro as 'Fecha de Registro' from tblPaquete 
            INNER JOIN tblEstadoPaquete ON tblPaquete.IdEstado = tblEstadoPaquete.IdEstado            
            INNER JOIN tblSucursal ON tblPaquete.IdSucursal = tblSucursal.IdSucursal
            INNER JOIN tblProveedor ON tblPaquete.IdProveedor = tblProveedor.IdProveedor", connStr);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connStr.Close();
        }

        private void GetPackagesByUser()
        {
            connStr.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter("Select * from tblPaquete where IdCliente = " + txtBuscarIDCliente.Text, connStr);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connStr.Close();
        }

        private void InsertPackagesData()
        {
            using (var connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*"))
            {
                using (var command = connStr.CreateCommand())
                {
                    //Insert Paquete
                    command.CommandText = @"
                        Insert into tblPaquete 
                        values ('" + txtDescrip.Text + "', " + txtPeso.Text + ", 130, '" + dtpFecha.Value.ToString() + "', '" + dtpFecha.Value.ToString() + "', " + txtIDCliente.Text + ", " + cbxSucursal.SelectedIndex + ", " + cbxProveedor.SelectedIndex + ", 4)";
                    connStr.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        private void UpdateStatus()
        {
            using (var connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*"))
            {
                using (var command = connStr.CreateCommand())
                {
                    command.CommandText = @"
                        Update tblPaquete set IdEstado = " + cbxEstadoPaquete.SelectedIndex + " where IdCliente = " + idCliente;
                    connStr.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        private void GetDataForCbx()
        {
            using (var connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*"))
            {
                using (var command = connStr.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT * FROM tblEstadoPaquete";
                    connStr.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        cbxEstadoPaquete.Items.Add("--- Seleccione un estado ---");
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cbxEstadoPaquete.Items.Add(reader.GetString(1));
                        }
                    }
                }
                connStr.Close();

                using (var command = connStr.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT * FROM tblProveedor";
                    connStr.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        cbxProveedor.Items.Add("--- Seleccione un estado ---");
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cbxProveedor.Items.Add(reader.GetString(1));
                        }
                    }
                }
                connStr.Close();

                using (var command = connStr.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT * FROM tblSucursal";
                    connStr.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        cbxSucursal.Items.Add("--- Seleccione un estado ---");
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cbxSucursal.Items.Add(reader.GetString(1));
                        }
                    }
                }
                connStr.Close();
            }

            /*connStr.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter("Update tblPaquete set EstadoPaquete = '" + cbxEstadoPaquete.Text + "' where IdPaquete = ", connStr);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connStr.Close();*/
        }
        //

        private void MaterialSingleLineTextField5_Click(object sender, EventArgs e)
        {
            this.txtBuscarIDCliente.Text = string.Empty;
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void MaterialRaisedButton5_Click(object sender, EventArgs e) //Cerrar sesion
        {
            this.Hide();
            LogIn x = new LogIn();
            x.ShowDialog();
            this.Close();
        }

        private void Empleado_Load(object sender, EventArgs e)
        {
            // Metodos que se activan al iniciar al Form
            GetAllPackages();
            GetDataForCbx();
        }

        private void dgvPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Codigo para conseguir el IdCliente al seleccionar un registro del DataGridView 

            DataGridViewRow row = this.dgvPaquetes.Rows[e.RowIndex];
            idCliente = Convert.ToInt16(row.Cells["IdCliente"].Value);
        }

        // Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetPackagesByUser();
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (cbxEstadoPaquete.Text == string.Empty || idCliente == 0)
            {
                MessageBox.Show("Seleccione un estado o seleccione un registro");
            }
            else
            {
                UpdateStatus();
                GetAllPackages();
            }
        }

        private void btnRegistrarPaquete_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == string.Empty || txtDescrip.Text == string.Empty || cbxProveedor.Text == string.Empty || txtPeso.Text == string.Empty || cbxSucursal.Text == string.Empty)
            {
                MessageBox.Show("Llene todos los campos");
            }
            else
            {
                InsertPackagesData();
                MessageBox.Show("Registro agregado con exito!");
                GetAllPackages();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
