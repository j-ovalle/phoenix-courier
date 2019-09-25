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
    public partial class Cliente : MaterialForm {

        //SqlConnection connStr = new SqlConnection("Data Source=phoenixcourier.database.windows.net;Initial Catalog=PhoenixDB;Persist Security Info=True;User ID=ovalle;Password=phoenix123*");
        SqlConnection connStr = new SqlConnection("Data Source=JEANMICHAEL;Initial Catalog=PhoenixDB;Integrated Security=True");
        SqlDataAdapter SqlAdapter = new SqlDataAdapter();

        public Cliente(string nombre, int id)
        {
            InitializeComponent();

            //Datos tomados del Form LogIn
            string nombreUsuario = nombre;
            int idPersona = id;

            lblNombreCliente.Text = nombre;
            lblIDCliente.Text = Convert.ToString(id);

            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            var skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.DeepPurple600, Primary.DeepPurple500, Primary.Red200, Accent.DeepPurple400, TextShade.WHITE);
        }

        // Metodos propios
        private void GetPackages() 
         {
            connStr.Open();
            DataTable dt = new DataTable();
            SqlAdapter = new SqlDataAdapter("Select * from tblPaquete where IdCliente = " + lblIDCliente.Text, connStr);
            SqlAdapter.Fill(dt);
            dgvPaquetes.DataSource = dt;
            connStr.Close();
        }
        //

        private void MaterialRaisedButton1_Click(object sender, EventArgs e) //Configurar cuenta
        {
            this.Hide();
            CambioConfig x = new CambioConfig(lblNombreCliente.Text, Convert.ToInt16(lblIDCliente.Text));
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
