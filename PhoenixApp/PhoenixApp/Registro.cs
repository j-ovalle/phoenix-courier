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
    public partial class Registro : MaterialForm
    {
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

        }

        private void MaterialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void MaterialSingleLineTextField6_Click(object sender, EventArgs e)
        {

        }
    }
}
