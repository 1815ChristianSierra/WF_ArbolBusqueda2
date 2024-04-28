using EstructurasDatosPG3CS.ListasSimples;
using EstructurasDatosPG3CS.ArbolesBinarios;
using System.Collections.Generic;
using System.Xml.Linq;

namespace WF_ArbolBusqueda2
{
    public partial class frmProyectos : Form
    {
        //NOMBRE: CHRISTIAN ALEXANDER SIERRA ELIAS
        //CARNET: 0990221815
        //CURSO: PROGRAMACION3
        //SECCION: A
        

        clsLSLista gMiLista;
        clsArbolBinarioBusqueda gMiArbolBinarioBusqueda;
        public static string glStrValorMod;

        public frmProyectos()
        {
            InitializeComponent();
            gMiLista = new clsLSLista();
            gMiArbolBinarioBusqueda = new clsArbolBinarioBusqueda();
        }

        public void LimpiarClientes()
        {
            txtClienteNombre.Text = "";
            txtClienteNit.Text = "";
            txtClienteDescripcion.Text = "";
        }

        public void LimpiarProyectos()
        {
            txtNombreProyecto.Text = "";
            txtDescripcionProyecto.Text = "";
            txtFechaProyecto.Text = "";
            cmbClienteProyecto.SelectedIndex = -1;
        }

        public void ActualizarCombo()
        {
            clsLSNodo lMiNodo = gMiLista.Primero;
            cmbClienteProyecto.Items.Clear();
            while (lMiNodo != null)
            {
                cmbClienteProyecto.Items.Add(lMiNodo.Elemento);
                lMiNodo = lMiNodo.Siguiente;
            }
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            gMiLista.InsertarInicio(new clsCliente(txtClienteNombre.Text, txtClienteNit.Text, txtClienteDescripcion.Text));
            ActualizarCombo();
            LimpiarClientes();
        }

        private void btnCrearProyecto_Click(object sender, EventArgs e)
        {
            // Get the selected client from the ComboBox
            clsCliente selectedClient = (clsCliente)cmbClienteProyecto.SelectedItem;

            // CREAMOS EL PROYECTO CON EL CLIENTE SELECCIONADO DEL COMBO
            clsProyectos proyecto = new clsProyectos(txtNombreProyecto.Text, txtDescripcionProyecto.Text, selectedClient, txtFechaProyecto.Text);

            // INSERTAMOS EL PROYECTO EN EL ARBOL
            gMiArbolBinarioBusqueda.insertar(proyecto);
            MessageBox.Show("PROYECTO CREADO.");
            LimpiarProyectos();
        }

        private void btnModificarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProyecto.Text.Length == 0 || txtFechaProyecto.Text.Length == 0)
                {
                    MessageBox.Show("ALGUNO DE LOS CAMPOS ESTA VACIO.");
                    txtNombreProyecto.Focus();
                }
                else
                {
                    // BUSCAMOS EL CLIENTE CON EL ITEM DEL COMBOBOX
                    clsCliente selectedClient = (clsCliente)cmbClienteProyecto.SelectedItem;
                    // ELIMINAMOS EL PROYECTO PARA MODIFICARLO
                    gMiArbolBinarioBusqueda.eliminar(new clsProyectos(glStrValorMod.ToString(), "", null, ""));
                    // CREAMOS UN NUEVO PROYECTO CON EL CLIENTE SELECCIONADO DEL COMBO
                    clsProyectos proyecto = new clsProyectos(txtNombreProyecto.Text, txtDescripcionProyecto.Text, selectedClient, txtFechaProyecto.Text);
                    // INSERTAMOS EL PROYECTO EN EL ARBOL BINARIO
                    gMiArbolBinarioBusqueda.insertar(proyecto);
                    MessageBox.Show("PROYECTO MODIFICADO.");
                    LimpiarProyectos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBusquedaProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBusquedaProyecto.Text.Length == 0)
                {
                    MessageBox.Show("ALGUNO DE LOS CAMPOS ESTA VACIO.");
                    txtNombreProyecto.Focus();
                }
                else
                {
                    clsProyectos lMiProyectoMod = new clsProyectos(txtBusquedaProyecto.Text, "", null, "");
                    lMiProyectoMod = (clsProyectos)gMiArbolBinarioBusqueda.buscarIterativo(lMiProyectoMod).valorNodo();
                    txtNombreProyecto.Text = lMiProyectoMod.lStrNombreProyecto;
                    txtDescripcionProyecto.Text = lMiProyectoMod.lStrDescripcionProyecto;

                    txtFechaProyecto.Text = lMiProyectoMod.lStrFechaProyecto;
                    MessageBox.Show("PROYECTO ENCONTRADO.");
                    glStrValorMod = txtNombreProyecto.Text.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR DEBE INGRESAR EL NOMBRE O DESCRIPCION CORRECTOS: " + ex.Message);
                LimpiarProyectos();
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreProyecto.Text.Length == 0 || txtFechaProyecto.Text.Length == 0)
                {
                    MessageBox.Show("ALGUNO DE LOS CAMPOS ESTA VACIO.");
                    txtNombreProyecto.Focus();
                }
                else
                {
                    gMiArbolBinarioBusqueda.eliminar(new clsProyectos(txtNombreProyecto.Text, txtDescripcionProyecto.Text, null, txtFechaProyecto.Text));
                    MessageBox.Show("PROYECTO ELIMINADO.");
                    LimpiarProyectos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
