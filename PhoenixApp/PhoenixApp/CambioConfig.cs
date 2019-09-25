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
    public partial class CambioConfig : MaterialForm
    {
        public CambioConfig(string nombreUsuario, int idPersona)
        {
            InitializeComponent();

            lblN.Text = nombreUsuario;
            lblI.Text = Convert.ToString(idPersona);

            //
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
            Cliente x = new Cliente(lblN.Text, Convert.ToInt16(lblI.Text));
            x.ShowDialog();
            this.Close();
        }
    }
}
