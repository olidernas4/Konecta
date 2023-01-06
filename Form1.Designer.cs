
namespace Konecta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(95, 90);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 20);
            this.txtNombre.TabIndex = 86;
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.ForeColor = System.Drawing.Color.White;
            this.documentoLabel.Location = new System.Drawing.Point(9, 93);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(47, 13);
            this.documentoLabel.TabIndex = 89;
            this.documentoLabel.Text = "Nombre:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.ForeColor = System.Drawing.Color.White;
            this.nombreLabel.Location = new System.Drawing.Point(9, 119);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(78, 13);
            this.nombreLabel.TabIndex = 90;
            this.nombreLabel.Text = "Fecha Ingreso:";
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.ForeColor = System.Drawing.Color.White;
            this.usuarioLabel.Location = new System.Drawing.Point(9, 145);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(42, 13);
            this.usuarioLabel.TabIndex = 91;
            this.usuarioLabel.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtSalario.ForeColor = System.Drawing.Color.White;
            this.txtSalario.Location = new System.Drawing.Point(95, 142);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(243, 20);
            this.txtSalario.TabIndex = 88;
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.Location = new System.Drawing.Point(12, 195);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Size = new System.Drawing.Size(455, 116);
            this.dgLista.TabIndex = 92;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(25, 10);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(31, 41);
            this.BtnAgregar.TabIndex = 94;
            this.toolTip1.SetToolTip(this.BtnAgregar, "Agregar Empleado");
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.Location = new System.Drawing.Point(88, 8);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(31, 42);
            this.BtnBuscar.TabIndex = 93;
            this.toolTip1.SetToolTip(this.BtnBuscar, "Buscar Empleado Por Nombre");
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.ErrorImage")));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(439, 8);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(25, 25);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 95;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(64, 20);
            this.dateTimePicker1.TabIndex = 96;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // txtFecha
            // 
            this.txtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.Location = new System.Drawing.Point(165, 116);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(173, 20);
            this.txtFecha.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Empleados";
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegresar.FlatAppearance.BorderSize = 0;
            this.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegresar.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BtnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegresar.Image")));
            this.BtnRegresar.Location = new System.Drawing.Point(386, 8);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(31, 31);
            this.BtnRegresar.TabIndex = 112;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(476, 323);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.documentoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.txtSalario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRegresar;
    }
}

