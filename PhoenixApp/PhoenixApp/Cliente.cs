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
    public partial class Cliente : MaterialForm
    {

        SqlConnection connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*");
        //SqlConnection connStr = new SqlConnection("Data Source=JEANMICHAEL;Initial Catalog=PhoenixDB;Integrated Security=True");
        SqlDataAdapter SqlAdapter = new SqlDataAdapter();
        string nombrePersona;
        int idPersona;

        public Cliente(string nombrePersona, int idPersona)
        {
            InitializeComponent();
            this.nombrePersona = nombrePersona;
            this.idPersona = idPersona;

            lblNombreCliente.Text = nombrePersona;
            lblIDCliente.Text = "Tu ID: " + idPersona.ToString();

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        private void GetPackages()
        {

            string query = "SELECT	tblEstadoPaquete.EstadoPaquete as 'Estado', FechaEstado as 'Fecha Estado', IdPaquete as 'No. Paquete', Descripcion as 'Descripcion', tblSucursal.NombreSucursal as 'Sucursal Destino', tblProveedor.NombreProveedor as 'Proveedor', Peso as 'Peso', Costo as 'Costo' " +
                            "FROM tblPaquete " +
                            "INNER JOIN tblEstadoPaquete ON tblPaquete.IdEstado = tblEstadoPaquete.IdEstado " +
                            "INNER JOIN tblSucursal ON tblPaquete.IdSucursal = tblSucursal.IdSucursal " +
                            "INNER JOIN tblProveedor ON tblPaquete.IdProveedor = tblProveedor.IdProveedor " +
                            "WHERE IdCliente = '" + idPersona.ToString() + "';";
            connStr.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter(query, connStr);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connStr.Close();

            dgvPaquetes.Columns[2].Width = 50;
            dgvPaquetes.Columns[3].Width = 210;
            dgvPaquetes.Columns[4].Width = 210;
        }

        private void MaterialRaisedButton1_Click(object sender, EventArgs e) //Configurar cuenta
        {
            this.Hide();
            CambioConfig x = new CambioConfig(nombrePersona, idPersona);
            x.ShowDialog();
            this.Close();
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e) //Cerrar sesion
        {
            this.Hide();
            LogIn x = new LogIn();
            x.ShowDialog();
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            GetPackages();
        }
    }
}
