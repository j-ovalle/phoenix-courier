using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoenixApp
{
    public partial class Empleado : MaterialForm
    {
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

        private void MaterialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField5_Click(object sender, EventArgs e)
        {
            this.txtBuscarIDCliente.Text = string.Empty;
        }

        private void MaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            this.txtDescrip.ResetText();
            this.cbxProveedor.ResetText();
            this.txtPeso.ResetText();
            this.txtIDCliente.ResetText();
            this.cbxSucursal.ResetText();
            this.dtpFecha.ResetText();

        }

        private void MaterialCheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MaterialRaisedButton5_Click(object sender, EventArgs e) //Cerrar sesion
        {
            this.Hide();
            LogIn x = new LogIn();
            x.ShowDialog();
            this.Close();
        }
    }
}
