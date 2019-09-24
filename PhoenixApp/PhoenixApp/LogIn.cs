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
    public partial class LogIn : MaterialForm
    {
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
            this.Hide();
            Registro x = new Registro();
            x.ShowDialog();
            this.Close();
        }
    }
}
