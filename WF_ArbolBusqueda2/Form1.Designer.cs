namespace WF_ArbolBusqueda2
{
    partial class frmProyectos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpInformacion = new GroupBox();
            lblProyectoFechaInicio = new Label();
            lblCliente = new Label();
            lblProyectoDescripcion = new Label();
            lblProyectoNombre = new Label();
            cmbClienteProyecto = new ComboBox();
            txtFechaProyecto = new TextBox();
            txtDescripcionProyecto = new TextBox();
            txtNombreProyecto = new TextBox();
            btnBusquedaProyecto = new Button();
            btnCrearProyecto = new Button();
            btnModificarProyecto = new Button();
            btnEliminarProyecto = new Button();
            lblNombre = new Label();
            txtBusquedaProyecto = new TextBox();
            grpClientes = new GroupBox();
            lblClienteDireccion = new Label();
            txtClienteDescripcion = new TextBox();
            lblClienteNit = new Label();
            lblNombreCliente = new Label();
            txtClienteNit = new TextBox();
            txtClienteNombre = new TextBox();
            btnCrearCliente = new Button();
            grpInformacion.SuspendLayout();
            grpClientes.SuspendLayout();
            SuspendLayout();
            // 
            // grpInformacion
            // 
            grpInformacion.Controls.Add(lblProyectoFechaInicio);
            grpInformacion.Controls.Add(lblCliente);
            grpInformacion.Controls.Add(lblProyectoDescripcion);
            grpInformacion.Controls.Add(lblProyectoNombre);
            grpInformacion.Controls.Add(cmbClienteProyecto);
            grpInformacion.Controls.Add(txtFechaProyecto);
            grpInformacion.Controls.Add(txtDescripcionProyecto);
            grpInformacion.Controls.Add(txtNombreProyecto);
            grpInformacion.ForeColor = SystemColors.ButtonFace;
            grpInformacion.Location = new Point(30, 95);
            grpInformacion.Name = "grpInformacion";
            grpInformacion.Size = new Size(528, 332);
            grpInformacion.TabIndex = 0;
            grpInformacion.TabStop = false;
            grpInformacion.Text = "Informacion del Proyecto";
            // 
            // lblProyectoFechaInicio
            // 
            lblProyectoFechaInicio.AutoSize = true;
            lblProyectoFechaInicio.Location = new Point(27, 249);
            lblProyectoFechaInicio.Name = "lblProyectoFechaInicio";
            lblProyectoFechaInicio.Size = new Size(108, 20);
            lblProyectoFechaInicio.TabIndex = 4;
            lblProyectoFechaInicio.Text = "Fecha de Inicio";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(27, 193);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(55, 20);
            lblCliente.TabIndex = 3;
            lblCliente.Text = "Cliente";
            // 
            // lblProyectoDescripcion
            // 
            lblProyectoDescripcion.AutoSize = true;
            lblProyectoDescripcion.Location = new Point(27, 123);
            lblProyectoDescripcion.Name = "lblProyectoDescripcion";
            lblProyectoDescripcion.Size = new Size(87, 20);
            lblProyectoDescripcion.TabIndex = 2;
            lblProyectoDescripcion.Text = "Descripcion";
            // 
            // lblProyectoNombre
            // 
            lblProyectoNombre.AutoSize = true;
            lblProyectoNombre.Location = new Point(27, 53);
            lblProyectoNombre.Name = "lblProyectoNombre";
            lblProyectoNombre.Size = new Size(64, 20);
            lblProyectoNombre.TabIndex = 1;
            lblProyectoNombre.Text = "Nombre";
            // 
            // cmbClienteProyecto
            // 
            cmbClienteProyecto.FormattingEnabled = true;
            cmbClienteProyecto.Location = new Point(149, 190);
            cmbClienteProyecto.Name = "cmbClienteProyecto";
            cmbClienteProyecto.Size = new Size(351, 28);
            cmbClienteProyecto.TabIndex = 3;
            // 
            // txtFechaProyecto
            // 
            txtFechaProyecto.Location = new Point(149, 246);
            txtFechaProyecto.Multiline = true;
            txtFechaProyecto.Name = "txtFechaProyecto";
            txtFechaProyecto.Size = new Size(351, 45);
            txtFechaProyecto.TabIndex = 4;
            // 
            // txtDescripcionProyecto
            // 
            txtDescripcionProyecto.Location = new Point(149, 120);
            txtDescripcionProyecto.Multiline = true;
            txtDescripcionProyecto.Name = "txtDescripcionProyecto";
            txtDescripcionProyecto.Size = new Size(351, 45);
            txtDescripcionProyecto.TabIndex = 2;
            // 
            // txtNombreProyecto
            // 
            txtNombreProyecto.Location = new Point(149, 50);
            txtNombreProyecto.Multiline = true;
            txtNombreProyecto.Name = "txtNombreProyecto";
            txtNombreProyecto.Size = new Size(351, 45);
            txtNombreProyecto.TabIndex = 1;
            // 
            // btnBusquedaProyecto
            // 
            btnBusquedaProyecto.Location = new Point(458, 35);
            btnBusquedaProyecto.Name = "btnBusquedaProyecto";
            btnBusquedaProyecto.Size = new Size(100, 45);
            btnBusquedaProyecto.TabIndex = 1;
            btnBusquedaProyecto.Text = "Busqueda";
            btnBusquedaProyecto.UseVisualStyleBackColor = true;
            btnBusquedaProyecto.Click += btnBusquedaProyecto_Click;
            // 
            // btnCrearProyecto
            // 
            btnCrearProyecto.Location = new Point(30, 450);
            btnCrearProyecto.Name = "btnCrearProyecto";
            btnCrearProyecto.Size = new Size(100, 45);
            btnCrearProyecto.TabIndex = 2;
            btnCrearProyecto.Text = "Crear";
            btnCrearProyecto.UseVisualStyleBackColor = true;
            btnCrearProyecto.Click += btnCrearProyecto_Click;
            // 
            // btnModificarProyecto
            // 
            btnModificarProyecto.Location = new Point(242, 450);
            btnModificarProyecto.Name = "btnModificarProyecto";
            btnModificarProyecto.Size = new Size(100, 45);
            btnModificarProyecto.TabIndex = 3;
            btnModificarProyecto.Text = "Modificar";
            btnModificarProyecto.UseVisualStyleBackColor = true;
            btnModificarProyecto.Click += btnModificarProyecto_Click;
            // 
            // btnEliminarProyecto
            // 
            btnEliminarProyecto.Location = new Point(458, 450);
            btnEliminarProyecto.Name = "btnEliminarProyecto";
            btnEliminarProyecto.Size = new Size(100, 45);
            btnEliminarProyecto.TabIndex = 4;
            btnEliminarProyecto.Text = "Eliminar";
            btnEliminarProyecto.UseVisualStyleBackColor = true;
            btnEliminarProyecto.Click += btnEliminarProyecto_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(57, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // txtBusquedaProyecto
            // 
            txtBusquedaProyecto.Location = new Point(142, 35);
            txtBusquedaProyecto.Multiline = true;
            txtBusquedaProyecto.Name = "txtBusquedaProyecto";
            txtBusquedaProyecto.Size = new Size(296, 45);
            txtBusquedaProyecto.TabIndex = 6;
            // 
            // grpClientes
            // 
            grpClientes.Controls.Add(lblClienteDireccion);
            grpClientes.Controls.Add(txtClienteDescripcion);
            grpClientes.Controls.Add(lblClienteNit);
            grpClientes.Controls.Add(lblNombreCliente);
            grpClientes.Controls.Add(txtClienteNit);
            grpClientes.Controls.Add(txtClienteNombre);
            grpClientes.ForeColor = SystemColors.ButtonHighlight;
            grpClientes.Location = new Point(636, 95);
            grpClientes.Name = "grpClientes";
            grpClientes.Size = new Size(450, 269);
            grpClientes.TabIndex = 7;
            grpClientes.TabStop = false;
            grpClientes.Text = "Informacion de Clientes";
            // 
            // lblClienteDireccion
            // 
            lblClienteDireccion.AutoSize = true;
            lblClienteDireccion.Location = new Point(12, 193);
            lblClienteDireccion.Name = "lblClienteDireccion";
            lblClienteDireccion.Size = new Size(72, 20);
            lblClienteDireccion.TabIndex = 7;
            lblClienteDireccion.Text = "Direccion";
            // 
            // txtClienteDescripcion
            // 
            txtClienteDescripcion.Location = new Point(134, 190);
            txtClienteDescripcion.Multiline = true;
            txtClienteDescripcion.Name = "txtClienteDescripcion";
            txtClienteDescripcion.Size = new Size(298, 45);
            txtClienteDescripcion.TabIndex = 8;
            // 
            // lblClienteNit
            // 
            lblClienteNit.AutoSize = true;
            lblClienteNit.Location = new Point(12, 123);
            lblClienteNit.Name = "lblClienteNit";
            lblClienteNit.Size = new Size(29, 20);
            lblClienteNit.TabIndex = 5;
            lblClienteNit.Text = "Nit";
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(12, 53);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(55, 20);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = "Cliente";
            // 
            // txtClienteNit
            // 
            txtClienteNit.Location = new Point(134, 120);
            txtClienteNit.Multiline = true;
            txtClienteNit.Name = "txtClienteNit";
            txtClienteNit.Size = new Size(298, 45);
            txtClienteNit.TabIndex = 6;
            // 
            // txtClienteNombre
            // 
            txtClienteNombre.Location = new Point(134, 50);
            txtClienteNombre.Multiline = true;
            txtClienteNombre.Name = "txtClienteNombre";
            txtClienteNombre.Size = new Size(298, 45);
            txtClienteNombre.TabIndex = 4;
            // 
            // btnCrearCliente
            // 
            btnCrearCliente.Location = new Point(815, 382);
            btnCrearCliente.Name = "btnCrearCliente";
            btnCrearCliente.Size = new Size(100, 45);
            btnCrearCliente.TabIndex = 8;
            btnCrearCliente.Text = "Cliente";
            btnCrearCliente.UseVisualStyleBackColor = true;
            btnCrearCliente.Click += btnCrearCliente_Click;
            // 
            // frmProyectos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1171, 581);
            Controls.Add(btnCrearCliente);
            Controls.Add(grpClientes);
            Controls.Add(txtBusquedaProyecto);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminarProyecto);
            Controls.Add(btnModificarProyecto);
            Controls.Add(btnCrearProyecto);
            Controls.Add(btnBusquedaProyecto);
            Controls.Add(grpInformacion);
            Name = "frmProyectos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Busqueda de Proyectos";
            grpInformacion.ResumeLayout(false);
            grpInformacion.PerformLayout();
            grpClientes.ResumeLayout(false);
            grpClientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpInformacion;
        private Button btnBusquedaProyecto;
        private Button btnCrearProyecto;
        private Button btnModificarProyecto;
        private Button btnEliminarProyecto;
        private Label lblNombre;
        private TextBox txtBusquedaProyecto;
        private ComboBox cmbClienteProyecto;
        private TextBox txtFechaProyecto;
        private TextBox txtDescripcionProyecto;
        private TextBox txtNombreProyecto;
        private Label lblProyectoFechaInicio;
        private Label lblCliente;
        private Label lblProyectoDescripcion;
        private Label lblProyectoNombre;
        private GroupBox grpClientes;
        private Label lblClienteNit;
        private Label lblNombreCliente;
        private TextBox txtClienteNit;
        private TextBox txtClienteNombre;
        private Label lblClienteDireccion;
        private TextBox txtClienteDescripcion;
        private Button btnCrearCliente;
    }
}
