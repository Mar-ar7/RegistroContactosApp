            using System;
            using System.Windows.Forms;

namespace RegistroContactosApp
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void ButtonAgregar_Click(object sender, EventArgs e)
            {
                // Verifica que todos los campos estén llenos
                if (string.IsNullOrWhiteSpace(TextBoxNombre.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxTelefono.Text) ||
                    string.IsNullOrWhiteSpace(TextBoxEmail.Text))
                {
                    LabelEstado.Text = "Por favor, completa todos los campos.";
                    return;
                }

                string contacto = $"{TextBoxNombre.Text} - {TextBoxTelefono.Text} - {TextBoxEmail.Text}";

                ListBoxContactos.Items.Add(contacto);

                LabelEstado.Text = "Contacto agregado con éxito.";

                // Limpia los cuadros de texto
                LimpiarCampos();
            }

            private void ButtonLimpiar_Click(object sender, EventArgs e)
            {
                LimpiarCampos();
                LabelEstado.Text = string.Empty;
            }

            private void LimpiarCampos()
            {
                TextBoxNombre.Clear();
                TextBoxTelefono.Clear();
                TextBoxEmail.Clear();
            }
        }
    }


    
