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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else if (txtFecha.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar una fecha");
            }
            else if (txtSalario.Text.Trim()=="")
            {
                MessageBox.Show("Debe ingresar el salario");
            }
            else
            {
                try
                {
                    EmpleadoBD em = new EmpleadoBD();
                    em.Nombre_Empleado = txtNombre.Text.Trim();
                    em.Fecha_Ingreso = txtFecha.Text.Trim();
                    em.Salario_Empleado = txtSalario.Text.Trim();

                    if (EmpleadosCRUD.InsertarUsuario(em))
                    {
                        llenarGrid();
                        LimpiarCampos();
                        MessageBox.Show("Usuario guardado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("No es posible guardar");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void llenarGrid()
        {
            DataTable datos = EmpleadosCRUD.Listar();
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
            txtNombre.Text = "";
            dateTimePicker1.Text = "";
            txtSalario.Text = "";
        }

        bool consultado = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime Fecha = dateTimePicker1.Value;
            txtFecha.Text = Fecha.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar nombre del empleado");
            }
            else
            {
                EmpleadoBD em = EmpleadosCRUD.Consultar(txtNombre.Text.Trim());
                if (em == null)
                {
                    MessageBox.Show("Este nombre no esta en el registro" + txtNombre.Text);
                    LimpiarCampos();
                    consultado = false;
                }
                else
                {
                    txtNombre.Text = em.Nombre_Empleado;
                    txtFecha.Text = em.Fecha_Ingreso;
                    txtSalario.Text = em.Salario_Empleado;

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

    
