namespace Proyecto_Modulo_Inventario.Mod_Facturacion
{
    partial class frmBuscarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtClienteDescripcion = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoBusqueda = new System.Windows.Forms.ComboBox();
            this.rbDescripcion = new System.Windows.Forms.RadioButton();
            this.rbCedRuc = new System.Windows.Forms.RadioButton();
            this.dgvBuscarCliente = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClienteDescripcion
            // 
            this.txtClienteDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClienteDescripcion.Location = new System.Drawing.Point(60, 80);
            this.txtClienteDescripcion.MaxLength = 80;
            this.txtClienteDescripcion.Name = "txtClienteDescripcion";
            this.txtClienteDescripcion.Size = new System.Drawing.Size(374, 20);
            this.txtClienteDescripcion.TabIndex = 0;
            this.txtClienteDescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtClienteDescripcion_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(10, 83);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Cliente:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.BackgroundImage")));
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.Location = new System.Drawing.Point(440, 74);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(40, 30);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoBusqueda);
            this.groupBox1.Controls.Add(this.rbDescripcion);
            this.groupBox1.Controls.Add(this.rbCedRuc);
            this.groupBox1.Location = new System.Drawing.Point(13, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Busqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Busqueda:";
            // 
            // cboTipoBusqueda
            // 
            this.cboTipoBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoBusqueda.FormattingEnabled = true;
            this.cboTipoBusqueda.Items.AddRange(new object[] {
            "Al Inicio",
            "Que Contenga"});
            this.cboTipoBusqueda.Location = new System.Drawing.Point(120, 19);
            this.cboTipoBusqueda.Name = "cboTipoBusqueda";
            this.cboTipoBusqueda.Size = new System.Drawing.Size(214, 21);
            this.cboTipoBusqueda.TabIndex = 1;
            // 
            // rbDescripcion
            // 
            this.rbDescripcion.AutoSize = true;
            this.rbDescripcion.Checked = true;
            this.rbDescripcion.Location = new System.Drawing.Point(226, 46);
            this.rbDescripcion.Name = "rbDescripcion";
            this.rbDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbDescripcion.TabIndex = 3;
            this.rbDescripcion.TabStop = true;
            this.rbDescripcion.Text = "Descripcion";
            this.rbDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbCedRuc
            // 
            this.rbCedRuc.AutoSize = true;
            this.rbCedRuc.Location = new System.Drawing.Point(120, 46);
            this.rbCedRuc.Name = "rbCedRuc";
            this.rbCedRuc.Size = new System.Drawing.Size(83, 17);
            this.rbCedRuc.TabIndex = 2;
            this.rbCedRuc.Text = "Cedula/Ruc";
            this.rbCedRuc.UseVisualStyleBackColor = true;
            // 
            // dgvBuscarCliente
            // 
            this.dgvBuscarCliente.AllowUserToAddRows = false;
            this.dgvBuscarCliente.AllowUserToResizeColumns = false;
            this.dgvBuscarCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dgvBuscarCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBuscarCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgvBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBuscarCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.Column1,
            this.Column2,
            this.colCupo});
            this.dgvBuscarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvBuscarCliente.Location = new System.Drawing.Point(6, 106);
            this.dgvBuscarCliente.Name = "dgvBuscarCliente";
            this.dgvBuscarCliente.ReadOnly = true;
            this.dgvBuscarCliente.RowHeadersVisible = false;
            this.dgvBuscarCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBuscarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarCliente.Size = new System.Drawing.Size(487, 150);
            this.dgvBuscarCliente.TabIndex = 2;
            this.dgvBuscarCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarCliente_CellDoubleClick);
            this.dgvBuscarCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBuscarCliente_KeyDown);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "RUC";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.Width = 322;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dirección";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Telefono";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // colCupo
            // 
            this.colCupo.HeaderText = "cupo";
            this.colCupo.Name = "colCupo";
            this.colCupo.ReadOnly = true;
            this.colCupo.Visible = false;
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(502, 266);
            this.Controls.Add(this.dgvBuscarCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtClienteDescripcion);
            this.Controls.Add(this.label18);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarClientes";
            this.Text = "SISCOL - Buscar Clientes";
            this.Load += new System.EventHandler(this.frmBuscarClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtClienteDescripcion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDescripcion;
        private System.Windows.Forms.RadioButton rbCedRuc;
        private System.Windows.Forms.DataGridView dgvBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCupo;
    }
}