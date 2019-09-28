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
using System.Globalization;

namespace PhoenixApp
{
    public partial class Empleado : MaterialForm
    {
        string connStr = "Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*";
        SqlConnection connDB = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*");
        SqlDataAdapter SqlAdapter = new SqlDataAdapter();
        string idClienteQuery = "";
        bool[] estado = new bool[6];
        int idPaquete = 0;

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
        private void Clear(object sender, EventArgs e)
        {
            this.txtDescrip.ResetText();
            this.cbxProveedor.SelectedItem = null;
            this.txtPeso.ResetText();
            this.txtIDCliente.ResetText();
        }

        private void GetAllPackages(object sender, EventArgs e)
        {
            if (txtBuscarIDCliente.Text != "")
            {
                idClienteQuery = "WHERE tblPaquete.IdCliente = '" + txtBuscarIDCliente.Text + "';";
            }
            else
            {
                idClienteQuery = "";
            }
            connDB.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter(@"Select IdPaquete, IdCliente, Descripcion, Peso, Costo, EstadoPaquete as Estado, FechaEstado as 'Fecha de Estado' , NombreProveedor as Proveedor ,NombreSucursal as Sucursal, FechaRegistro as 'Fecha de Registro' from tblPaquete 
                                            INNER JOIN tblEstadoPaquete ON tblPaquete.IdEstado = tblEstadoPaquete.IdEstado            
                                            INNER JOIN tblSucursal ON tblPaquete.IdSucursal = tblSucursal.IdSucursal
                                            INNER JOIN tblProveedor ON tblPaquete.IdProveedor = tblProveedor.IdProveedor " + idClienteQuery, connDB);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connDB.Close();
            foreach (DataGridViewColumn column in dgvPaquetes.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            txtContadorPaquetes.Text = (dgvPaquetes.Rows.Count - 1).ToString() + " paquetes encontrados";
        }

        private void InsertPackagesData()
        {
            int idxProveedor = cbxProveedor.SelectedIndex + 1;
            float peso = float.Parse(txtPeso.Text, CultureInfo.InvariantCulture.NumberFormat);
            float pesoF = (float)(Math.Truncate((double)peso*100.0) / 100.0);

            float costo = pesoF * (float)150.00;

            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    //Insert Paquete
                    command.CommandText = @"INSERT INTO tblPaquete (Descripcion, Peso, Costo, FechaRegistro, FechaEstado, IdCliente, tblPaquete.IdSucursal, IdProveedor, IdEstado) 
                                            SELECT '" + txtDescrip.Text + "', " + pesoF.ToString() + ", " + costo +", '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "', '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") +"', " + txtIDCliente.Text + ", (SELECT IdSucursal FROM tblPersona WHERE IdPersona = " + txtIDCliente.Text + "), " + idxProveedor.ToString() + ", 5;";
                    connDB.Open();

                    command.ExecuteNonQuery();
                }
            }
            connDB.Close();
        }

        private void UpdateStatus()
        {
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    int index = cbxEstadoPaquete.SelectedIndex + 1;
                    command.CommandText = @"
                        Update tblPaquete set IdEstado = " + index + ", FechaEstado = '" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss") + "' where IdPaquete = " + idPaquete;
                    connDB.Open();

                    command.ExecuteNonQuery();
                }
            }
            connDB.Close();
        }

        private void GetDataForCbx()
        {
            using (var connDB = new SqlConnection(connStr))
            {
                using (var command = connDB.CreateCommand())
                {
                    command.CommandText = @"
                        SELECT tblProveedor.NombreProveedor, tblEstadoPaquete.EstadoPaquete
                        FROM tblSucursal
                        FULL OUTER JOIN tblProveedor ON tblSucursal.IdSucursal = tblProveedor.IdProveedor
                        FULL OUTER JOIN tblEstadoPaquete ON tblSucursal.IdSucursal = tblEstadoPaquete.IdEstado;";
                    connDB.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                                cbxProveedor.Items.Add(reader.GetString(0));
                            if (!reader.IsDBNull(1))
                                cbxEstadoPaquete.Items.Add(reader.GetString(1));
                        }
                    }
                }
                connDB.Close();
            }
        }

        private void MaterialSingleLineTextField5_Click(object sender, EventArgs e)
        {
            this.txtBuscarIDCliente.Text = string.Empty;
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
            GetAllPackages(sender, e);
            GetDataForCbx();
        }

        private void dgvPaquetes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Codigo para conseguir el IdCliente al seleccionar un registro del DataGridView 

            DataGridViewRow row = this.dgvPaquetes.Rows[e.RowIndex];
            idPaquete = Convert.ToInt16(row.Cells["IdPaquete"].Value);
            //idCliente = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells[0].Value);
        }

        // Botones
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //GetAll
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            if (cbxEstadoPaquete.Text == string.Empty || idPaquete == 0)
            {
                MessageBox.Show("Seleccione un estado y un registro.");
            }
            else
            {
                UpdateStatus();
                GetAllPackages(sender, e);
            }
        }

        public bool IsFloatOrInt(string value)
        {
            int intValue;
            float floatValue;
            return Int32.TryParse(value, out intValue) || float.TryParse(value, out floatValue);
        }

        private void btnRegistrarPaquete_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == string.Empty || txtDescrip.Text == string.Empty || cbxProveedor.SelectedItem == null || txtPeso.Text == string.Empty)
            {
                MessageBox.Show("Por favor, llene todos los campos.");
            }
            else
            {
                if (!IsFloatOrInt(txtPeso.Text))
                {
                    MessageBox.Show("Peso inválido.");
                    return;
                }
                InsertPackagesData();
                MessageBox.Show("¡Paquete ingresado con éxito!");
                GetAllPackages(sender, e);
            }
        }
    }
}
