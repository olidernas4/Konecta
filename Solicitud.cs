using Konecta.CRUD;
using Konecta.ModeloGetSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konecta
{
    public partial class Solicitud : Form
    {
        
        public Solicitud()
        {
            InitializeComponent();
            LlenarEmpleado();
        }

        private void LlenarEmpleado()
        
        {
            var Solicitud = SolicitudesCRUD.MostrarEmpleado();
            txtEmpleado.DataSource = Solicitud;
            txtEmpleado.DisplayMember = "Empleado";
            txtEmpleado.ValueMember = "Id_Empleado";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Digite el código de solicitud", "Notificación");
                this.txtCodigo.Focus();
            }
            else if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Digite una descripción breve de la solicitud", "Notificación");
                this.txtDescripcion.Focus();
            }
            else if (string.IsNullOrEmpty(txtResumen.Text))
            {
                MessageBox.Show("Digite un resumen breve de la solicitud", "Notificación");
                this.txtResumen.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmpleado.Text))
            {
                MessageBox.Show("Digite al Empleado de la solicitud", "Notificación");
                this.txtResumen.Focus();
            }
            else
            {
                try
                {
                    SolicitudBD em = new SolicitudBD();
                    em.Codigo_Solicitud = txtCodigo.Text.Trim();
                    em.Descripcion_Solicitud = txtDescripcion.Text.Trim();
                    em.Resumen_Solicitud = txtResumen.Text.Trim();

                    em.Nombre_Empleado = txtEmpleado.ToString().Trim();

                    if (SolicitudesCRUD.GuardarSolicitud(em))
                    {
                        llenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("Solicitud guardada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("No es posible guardar la solicitud");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        bool consultado = false;

        private void llenarGrid()
        {
            DataTable datos = SolicitudesCRUD.Listar();
            if (datos == null)
            {
                MessageBox.Show("No se logró acceder a los datos");
            }
            else
            {
                dgLista.DataSource = datos.DefaultView;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtResumen.Text = "";
        }

        private void Solicitud_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe el código de la solicitud");
            }
            else
            {
                SolicitudBD em = SolicitudesCRUD.Consultar(txtCodigo.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("El código digitado no existe:  " + txtCodigo.Text);
                    LimpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtCodigo.Text = em.Codigo_Solicitud;
                    txtDescripcion.Text = em.Descripcion_Solicitud;
                    txtResumen.Text = em.Resumen_Solicitud;
                    txtEmpleado.Text = em.Id_Empleado.ToString();//Aqui me trae el nombre del empleado
                    consultado = true;

                }

            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            InicioApp Principal = new InicioApp();
            Principal.Show();
        }
    } 
}

