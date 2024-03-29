using S1_Lab02___Manejo_de_Clases.Controllers;
using S1_Lab02___Manejo_de_Clases.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S1_Lab02___Manejo_de_Clases
{
    public partial class frmEmpleado : Form
    {
        private EmpleadoController empleadoController = new EmpleadoController();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        // FUNCIONES
        private void MostrarNuevoEmpleado(Empleado empleado)
        {
            dgEmpleado.Rows.Add(empleado.Nombre, empleado.Categoria, empleado.MinutosTardanza, empleado.LlamadasAtencion, empleado.Pago);
            lblTotal.Text = (int.Parse(lblTotal.Text)+1).ToString();
        }
        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Validar Campos
            if (txtbNombre.Text == "" || cmbCategoria.Text == "" || txtbLLamadasAtencion.Text == "" || txtbMinutosTardanza.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;

            }
            // Crear Empleado
            Empleado empleado = new Empleado()
            {
                Nombre = txtbNombre.Text,
                Categoria = cmbCategoria.Text,
                LlamadasAtencion = int.Parse(txtbLLamadasAtencion.Text),
                MinutosTardanza = int.Parse(txtbMinutosTardanza.Text)
            };
            // Procesar el empleado
            empleado = empleadoController.ProcesarEmpleado(empleado);
            
            // Agregar en el DataGrew
            MostrarNuevoEmpleado(empleado);
            

  
        }
    }
}
