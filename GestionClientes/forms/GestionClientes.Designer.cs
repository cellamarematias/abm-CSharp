namespace GestionClientes
{
    partial class GestionClientes
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
            listClientes = new ListBox();
            btnGuardar = new Button();
            txtNombre = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtTelefono = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            btnEditar = new Button();
            label5 = new Label();
            lblId = new Label();
            SuspendLayout();
            // 
            // listClientes
            // 
            listClientes.FormattingEnabled = true;
            listClientes.ItemHeight = 20;
            listClientes.Location = new Point(14, 16);
            listClientes.Margin = new Padding(3, 4, 3, 4);
            listClientes.Name = "listClientes";
            listClientes.Size = new Size(309, 284);
            listClientes.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(235, 319);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 31);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(407, 81);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(255, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 87);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(25, 319);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(71, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 136);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(407, 129);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(255, 27);
            txtApellido.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 197);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(407, 190);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(255, 27);
            txtTelefono.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 253);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(407, 250);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(255, 27);
            txtEmail.TabIndex = 4;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(124, 319);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(84, 31);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(434, 38);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 12;
            label5.Text = "ID Alumno: ";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(519, 38);
            lblId.Name = "lblId";
            lblId.Size = new Size(0, 20);
            lblId.TabIndex = 13;
            // 
            // GestionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 371);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtTelefono);
            Controls.Add(label2);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(btnGuardar);
            Controls.Add(listClientes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionClientes";
            Text = "Form1";
            Load += GestionClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listClientes;
        private Button btnGuardar;
        private TextBox txtNombre;
        private Label label1;
        private Button btnEliminar;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtTelefono;
        private Label label4;
        private TextBox txtEmail;
        private Button btnEditar;
        private Label label5;
        private Label lblId;
    }
}