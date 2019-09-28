namespace PhoenixApp
{
    partial class Empleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleado));
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.txtDescrip = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPeso = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRegistrarPaquete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtIDCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscarIDCliente = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnActualizarEstado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxEstadoPaquete = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.txtContadorPaquetes = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(25, 148);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.ReadOnly = true;
            this.dgvPaquetes.Size = new System.Drawing.Size(748, 228);
            this.dgvPaquetes.TabIndex = 0;
            this.dgvPaquetes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaquetes_CellContentClick);
            // 
            // txtDescrip
            // 
            this.txtDescrip.Depth = 0;
            this.txtDescrip.Hint = "";
            this.txtDescrip.Location = new System.Drawing.Point(1019, 242);
            this.txtDescrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.PasswordChar = '\0';
            this.txtDescrip.SelectedText = "";
            this.txtDescrip.SelectionLength = 0;
            this.txtDescrip.SelectionStart = 0;
            this.txtDescrip.Size = new System.Drawing.Size(201, 23);
            this.txtDescrip.TabIndex = 2;
            this.txtDescrip.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(885, 246);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Descripción:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(900, 319);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(81, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Proveedor:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(904, 383);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(77, 19);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Peso (Lb):";
            // 
            // txtPeso
            // 
            this.txtPeso.Depth = 0;
            this.txtPeso.Hint = "";
            this.txtPeso.Location = new System.Drawing.Point(1019, 383);
            this.txtPeso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.Size = new System.Drawing.Size(201, 23);
            this.txtPeso.TabIndex = 10;
            this.txtPeso.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(816, 64);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(19, 519);
            this.materialDivider1.TabIndex = 12;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnRegistrarPaquete
            // 
            this.btnRegistrarPaquete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarPaquete.Depth = 0;
            this.btnRegistrarPaquete.Location = new System.Drawing.Point(1048, 498);
            this.btnRegistrarPaquete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrarPaquete.Name = "btnRegistrarPaquete";
            this.btnRegistrarPaquete.Primary = true;
            this.btnRegistrarPaquete.Size = new System.Drawing.Size(172, 38);
            this.btnRegistrarPaquete.TabIndex = 13;
            this.btnRegistrarPaquete.Text = "registrar paquete";
            this.btnRegistrarPaquete.UseVisualStyleBackColor = true;
            this.btnRegistrarPaquete.Click += new System.EventHandler(this.btnRegistrarPaquete_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(880, 498);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = true;
            this.btnLimpiar.Size = new System.Drawing.Size(147, 38);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.Clear);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.Location = new System.Drawing.Point(235, 83);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Primary = true;
            this.btnBuscar.Size = new System.Drawing.Size(86, 31);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.GetAllPackages);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(900, 170);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(78, 19);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "ID Cliente:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Depth = 0;
            this.txtIDCliente.Hint = "";
            this.txtIDCliente.Location = new System.Drawing.Point(1019, 166);
            this.txtIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.PasswordChar = '\0';
            this.txtIDCliente.SelectedText = "";
            this.txtIDCliente.SelectionLength = 0;
            this.txtIDCliente.SelectionStart = 0;
            this.txtIDCliente.Size = new System.Drawing.Size(201, 23);
            this.txtIDCliente.TabIndex = 20;
            this.txtIDCliente.UseSystemPasswordChar = false;
            // 
            // txtBuscarIDCliente
            // 
            this.txtBuscarIDCliente.Depth = 0;
            this.txtBuscarIDCliente.Hint = "";
            this.txtBuscarIDCliente.Location = new System.Drawing.Point(29, 91);
            this.txtBuscarIDCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscarIDCliente.Name = "txtBuscarIDCliente";
            this.txtBuscarIDCliente.PasswordChar = '\0';
            this.txtBuscarIDCliente.SelectedText = "";
            this.txtBuscarIDCliente.SelectionLength = 0;
            this.txtBuscarIDCliente.SelectionStart = 0;
            this.txtBuscarIDCliente.Size = new System.Drawing.Size(180, 23);
            this.txtBuscarIDCliente.TabIndex = 21;
            this.txtBuscarIDCliente.UseSystemPasswordChar = false;
            this.txtBuscarIDCliente.Click += new System.EventHandler(this.MaterialSingleLineTextField5_Click);
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEstado.Depth = 0;
            this.btnActualizarEstado.Location = new System.Drawing.Point(526, 498);
            this.btnActualizarEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Primary = true;
            this.btnActualizarEstado.Size = new System.Drawing.Size(162, 38);
            this.btnActualizarEstado.TabIndex = 25;
            this.btnActualizarEstado.Text = "Actualizar estado";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // cbxEstadoPaquete
            // 
            this.cbxEstadoPaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoPaquete.FormattingEnabled = true;
            this.cbxEstadoPaquete.Location = new System.Drawing.Point(298, 508);
            this.cbxEstadoPaquete.Name = "cbxEstadoPaquete";
            this.cbxEstadoPaquete.Size = new System.Drawing.Size(162, 21);
            this.cbxEstadoPaquete.TabIndex = 26;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(116, 510);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(143, 19);
            this.materialLabel8.TabIndex = 27;
            this.materialLabel8.Text = "Estado del Paquete:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(875, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Registro de Paquetes";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Depth = 0;
            this.btnCerrarSesion.Location = new System.Drawing.Point(611, 83);
            this.btnCerrarSesion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Primary = true;
            this.btnCerrarSesion.Size = new System.Drawing.Size(162, 31);
            this.btnCerrarSesion.TabIndex = 36;
            this.btnCerrarSesion.Text = "cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.MaterialRaisedButton5_Click);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(1019, 317);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(201, 21);
            this.cbxProveedor.TabIndex = 37;
            // 
            // txtContadorPaquetes
            // 
            this.txtContadorPaquetes.AutoSize = true;
            this.txtContadorPaquetes.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContadorPaquetes.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.txtContadorPaquetes.Location = new System.Drawing.Point(24, 397);
            this.txtContadorPaquetes.Name = "txtContadorPaquetes";
            this.txtContadorPaquetes.Size = new System.Drawing.Size(20, 30);
            this.txtContadorPaquetes.TabIndex = 38;
            this.txtContadorPaquetes.Text = "-";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-9, 451);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(844, 18);
            this.materialDivider2.TabIndex = 39;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 582);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.txtContadorPaquetes);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.cbxEstadoPaquete);
            this.Controls.Add(this.btnActualizarEstado);
            this.Controls.Add(this.txtBuscarIDCliente);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrarPaquete);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.dgvPaquetes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Empleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phoenix";
            this.Load += new System.EventHandler(this.Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPaquetes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescrip;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPeso;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegistrarPaquete;
        private MaterialSkin.Controls.MaterialRaisedButton btnLimpiar;
        private MaterialSkin.Controls.MaterialRaisedButton btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtIDCliente;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscarIDCliente;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizarEstado;
        private System.Windows.Forms.ComboBox cbxEstadoPaquete;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton btnCerrarSesion;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label txtContadorPaquetes;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
    }
}