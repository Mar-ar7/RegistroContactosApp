namespace RegistroContactosApp
{
    partial class Form1
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
            EtiquetaNombre = new Label();
            EtiquetaTelefono = new Label();
            EtiquetaEmail = new Label();
            TextBoxNombre = new TextBox();
            TextBoxTelefono = new TextBox();
            TextBoxEmail = new TextBox();
            ButtonAgregar = new Button();
            ButtonLimpiar = new Button();
            ListBoxContactos = new ListBox();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EtiquetaNombre.Location = new Point(12, 16);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(87, 23);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre:";
            // 
            // EtiquetaTelefono
            // 
            EtiquetaTelefono.AutoSize = true;
            EtiquetaTelefono.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EtiquetaTelefono.Location = new Point(12, 74);
            EtiquetaTelefono.Name = "EtiquetaTelefono";
            EtiquetaTelefono.Size = new Size(109, 23);
            EtiquetaTelefono.TabIndex = 1;
            EtiquetaTelefono.Text = "Teléfono:";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EtiquetaEmail.Location = new Point(12, 136);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(219, 23);
            EtiquetaEmail.TabIndex = 2;
            EtiquetaEmail.Text = "Correo Electrónico:";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.Location = new Point(236, 12);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(357, 27);
            TextBoxNombre.TabIndex = 3;
            // 
            // TextBoxTelefono
            // 
            TextBoxTelefono.Location = new Point(237, 70);
            TextBoxTelefono.Name = "TextBoxTelefono";
            TextBoxTelefono.Size = new Size(356, 27);
            TextBoxTelefono.TabIndex = 4;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(237, 132);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(356, 27);
            TextBoxEmail.TabIndex = 5;
            // 
            // ButtonAgregar
            // 
            ButtonAgregar.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonAgregar.Location = new Point(615, 36);
            ButtonAgregar.Name = "ButtonAgregar";
            ButtonAgregar.Size = new Size(173, 31);
            ButtonAgregar.TabIndex = 6;
            ButtonAgregar.Text = "Agregar Contacto";
            ButtonAgregar.UseVisualStyleBackColor = true;
            ButtonAgregar.Click += ButtonAgregar_Click;
            // 
            // ButtonLimpiar
            // 
            ButtonLimpiar.Font = new Font("Consolas", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLimpiar.Location = new Point(616, 98);
            ButtonLimpiar.Name = "ButtonLimpiar";
            ButtonLimpiar.Size = new Size(172, 32);
            ButtonLimpiar.TabIndex = 7;
            ButtonLimpiar.Text = "Limpiar Campos";
            ButtonLimpiar.UseVisualStyleBackColor = true;
            ButtonLimpiar.Click += ButtonLimpiar_Click;
            // 
            // ListBoxContactos
            // 
            ListBoxContactos.FormattingEnabled = true;
            ListBoxContactos.Location = new Point(401, 205);
            ListBoxContactos.Name = "ListBoxContactos";
            ListBoxContactos.Size = new Size(387, 224);
            ListBoxContactos.TabIndex = 8;
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Consolas", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(12, 254);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 22);
            LabelEstado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(ListBoxContactos);
            Controls.Add(ButtonLimpiar);
            Controls.Add(ButtonAgregar);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxTelefono);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaTelefono);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaTelefono;
        private Label EtiquetaEmail;
        private TextBox TextBoxNombre;
        private TextBox TextBoxTelefono;
        private TextBox TextBoxEmail;
        private Button ButtonAgregar;
        private Button ButtonLimpiar;
        private ListBox ListBoxContactos;
        private Label LabelEstado;
    }
}
