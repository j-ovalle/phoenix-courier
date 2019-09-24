namespace PhoenixApp
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.btnConfigurar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-3, 194);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(999, 23);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(23, 237);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.Size = new System.Drawing.Size(948, 238);
            this.dgvPaquetes.TabIndex = 4;
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Depth = 0;
            this.btnConfigurar.Location = new System.Drawing.Point(769, 82);
            this.btnConfigurar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Primary = true;
            this.btnConfigurar.Size = new System.Drawing.Size(202, 38);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "configurar cuenta";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.MaterialRaisedButton1_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNombreCliente.Location = new System.Drawing.Point(48, 90);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(147, 30);
            this.lblNombreCliente.TabIndex = 6;
            this.lblNombreCliente.Text = "Nombre cliente";
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblIDCliente.Location = new System.Drawing.Point(46, 136);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(149, 30);
            this.lblIDCliente.TabIndex = 7;
            this.lblIDCliente.Text = "Tu ID: ID cliente";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(769, 135);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = true;
            this.btnCerrarSesion.Size = new System.Drawing.Size(202, 38);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.MaterialRaisedButton2_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 503);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblIDCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.dgvPaquetes);
            this.Controls.Add(this.materialDivider1);
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phoenix";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfigurar;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblIDCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnCerrarSesion;
    }
}