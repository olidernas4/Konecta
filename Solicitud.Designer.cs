
namespace Konecta
{
    partial class Solicitud
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solicitud));
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.documentoLabel = new System.Windows.Forms.Label();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.txtResumen = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIdSolicitud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtEmpleado = new System.Windows.Forms.ComboBox();
            this.BtnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.ErrorImage")));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(467, 7);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(25, 25);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalir.TabIndex = 96;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 98;
            this.label1.Text = "Solicitud Ventas";
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
            this.BtnAgregar.Location = new System.Drawing.Point(32, 9);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(31, 41);
            this.BtnAgregar.TabIndex = 107;
            this.toolTip1.SetToolTip(this.BtnAgregar, "Agregar Solicitud");
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
            this.BtnBuscar.Location = new System.Drawing.Point(95, 7);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(31, 42);
            this.BtnBuscar.TabIndex = 106;
            this.toolTip1.SetToolTip(this.BtnBuscar, "Buscar Solicitud");
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            this.dgLista.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLista.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgLista.Location = new System.Drawing.Point(21, 197);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.Size = new System.Drawing.Size(455, 116);
            this.dgLista.TabIndex = 105;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(104, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(243, 20);
            this.txtCodigo.TabIndex = 99;
            // 
            // documentoLabel
            // 
            this.documentoLabel.AutoSize = true;
            this.documentoLabel.ForeColor = System.Drawing.Color.White;
            this.documentoLabel.Location = new System.Drawing.Point(18, 83);
            this.documentoLabel.Name = "documentoLabel";
            this.documentoLabel.Size = new System.Drawing.Size(43, 13);
            this.documentoLabel.TabIndex = 102;
            this.documentoLabel.Text = "Código:";
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.ForeColor = System.Drawing.Color.White;
            this.nombreLabel.Location = new System.Drawing.Point(18, 109);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(66, 13);
            this.nombreLabel.TabIndex = 103;
            this.nombreLabel.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(104, 106);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(243, 20);
            this.txtDescripcion.TabIndex = 100;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.ForeColor = System.Drawing.Color.White;
            this.usuarioLabel.Location = new System.Drawing.Point(18, 135);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(55, 13);
            this.usuarioLabel.TabIndex = 104;
            this.usuarioLabel.Text = "Resumen:";
            // 
            // txtResumen
            // 
            this.txtResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtResumen.ForeColor = System.Drawing.Color.White;
            this.txtResumen.Location = new System.Drawing.Point(104, 132);
            this.txtResumen.Name = "txtResumen";
            this.txtResumen.Size = new System.Drawing.Size(243, 20);
            this.txtResumen.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdSolicitud);
            this.panel1.Location = new System.Drawing.Point(104, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 11);
            this.panel1.TabIndex = 108;
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.Location = new System.Drawing.Point(38, 18);
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.Size = new System.Drawing.Size(100, 20);
            this.txtIdSolicitud.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Empleado:";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.FormattingEnabled = true;
            this.txtEmpleado.Location = new System.Drawing.Point(104, 160);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(243, 21);
            this.txtEmpleado.TabIndex = 110;
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
            this.BtnRegresar.Location = new System.Drawing.Point(412, 7);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(31, 31);
            this.BtnRegresar.TabIndex = 111;
            this.BtnRegresar.UseVisualStyleBackColor = false;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Solicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(498, 325);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.documentoLabel);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.txtResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Solicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitud";
            this.Load += new System.EventHandler(this.Solicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView dgLista;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label documentoLabel;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox txtResumen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdSolicitud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox txtEmpleado;
        private System.Windows.Forms.Button BtnRegresar;
    }
}