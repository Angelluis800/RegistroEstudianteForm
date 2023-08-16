using RegistroEstudianteForm.ENTITIES;
using System;

namespace RegistroEstudianteForm
{
    public partial class Form1 : Form
    {
        List<Registro> listaregistro;
        public Form1()
        {
            InitializeComponent();
            Carreras();
            filtrocomboBox.SelectedIndex = 0;
            listaregistro = new List<Registro>();
        }
        private void guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            errorProvider1.Clear();

            Registro re = new Registro();
            re = LlenaClase();

            try
            {
                if (!listaregistro.Any(registro => registro.Matricula == re.Matricula))
                {
                    listaregistro.Add(re);
                    MessageBox.Show("Guardado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("La matrícula ya existe en la lista.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Modificar()
        {
            string id = matriculamaskedTextBox.Text;
            var p = LlenaClase();


            foreach (var item in listaregistro)
            {
                if (item.Matricula == id)
                {
                    item.Matricula = p.Matricula;
                    item.Nombre = p.Nombre;
                    item.Direccion = p.Direccion;
                    item.Telefono = p.Telefono;
                    item.TotalCreditos = p.TotalCreditos;
                    item.Carrera = p.Carrera;
                }
            }
            MessageBox.Show("Actualizado con exito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool Validar()
        {
            bool p = true;

            if (string.IsNullOrWhiteSpace(nametextBox.Text))
            {
                errorProvider1.SetError(nametextBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(cedulatextBox.Text))
            {
                errorProvider1.SetError(cedulatextBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(matriculamaskedTextBox.Text))
            {
                errorProvider1.SetError(matriculamaskedTextBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(direcciontextBox.Text))
            {
                errorProvider1.SetError(direcciontextBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(telefonomaskedTextBox.Text))
            {
                errorProvider1.SetError(telefonomaskedTextBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(carreracomboBox.Text))
            {
                errorProvider1.SetError(carreracomboBox, "Este campo no puede estar vacio");
                p = false;
            }

            if (string.IsNullOrWhiteSpace(TotalCreditostextBox.Text))
            {
                errorProvider1.SetError(TotalCreditostextBox, "Este campo no puede estar vacio");
                p = false;
            }
            return p;
        }

        private Registro LlenaClase()
        {
            Registro p = new Registro();

            p.Matricula = matriculamaskedTextBox.Text;
            p.Nombre = nametextBox.Text;
            p.Direccion = direcciontextBox.Text;
            p.Telefono = telefonomaskedTextBox.Text;
            p.Cedula = cedulatextBox.Text;
            p.TotalCreditos = Convert.ToInt32(TotalCreditostextBox.Text);
            p.Carrera = carreracomboBox.Text;

            return p;
        }

        private void LlenaCampos(Registro r)
        {
            matriculamaskedTextBox.Text = r.Matricula;
            nametextBox.Text = r.Nombre;
            direcciontextBox.Text = r.Direccion;
            telefonomaskedTextBox.Text = r.Telefono;
            cedulatextBox.Text = r.Cedula;
            TotalCreditostextBox.Text = Convert.ToString(r.TotalCreditos);
            carreracomboBox.Text = r.Carrera;
        }
        private void LimpiarCampos()
        {
            errorProvider1.Clear();
            matriculamaskedTextBox.Text = String.Empty;
            nametextBox.Text = String.Empty;
            direcciontextBox.Text = String.Empty;
            telefonomaskedTextBox.Text = String.Empty;
            cedulatextBox.Text = String.Empty;
            TotalCreditostextBox.Text = String.Empty;
            carreracomboBox.Text = String.Empty;
            BalancetextBox.Text = String.Empty;
            preciocreditotextBox.Text = String.Empty;
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            string id = matriculamaskedTextBox.Text;
            bool encontrado = false;

            try
            {
                var list = listaregistro.Where(p => p.Matricula == id).ToList();
                foreach (var item in list)
                {
                    if (item.Matricula == id)
                    {
                        LlenaCampos(item);
                        actualizarbutton.Enabled = true; //Si encontramos registros activar el boton actualizar y hacerla visible
                        actualizarbutton.Visible = true;
                        encontrado = true;
                    }
                }
                if (encontrado == false)
                {

                    MessageBox.Show("No se encontraron registros para la matrícula ingresada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualizarbutton.Enabled = false; // Si no se encontraron registros, deshabilitar el boton actulizar y hacer que no sea visible
                    actualizarbutton.Visible = false;
                    LimpiarCampos();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error.Message);
                actualizarbutton.Enabled = false;
                actualizarbutton.Visible = false;
            }
        }

        private void salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelarbutton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            actualizarbutton.Enabled = false;
            actualizarbutton.Visible = false;
        }
        private void actualizarbutton_Click(object sender, EventArgs e)
        {
            if (Cambios())
            {
                Modificar();
                LimpiarCampos();
                actualizarbutton.Enabled = false;
                actualizarbutton.Visible = false;
            }
            else
            {
                MessageBox.Show("No se ha realizado ningun tipo de cambio.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Carreras()
        {
            carreracomboBox.Items.Add("Ingenieria en Sistemas");
            carreracomboBox.Items.Add("Ingenieria Civil");
            carreracomboBox.Items.Add("Medicina");
            carreracomboBox.Items.Add("Odontologia");
            carreracomboBox.Items.Add("Contabilidad");
            carreracomboBox.Items.Add("Derecho");
            carreracomboBox.Items.Add("Comunicacion Audio-Visual");
        }
        private void carreracomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carreracomboBox.SelectedIndex == 0)
            {
                preciocreditotextBox.Text = "$850";
            }
            if (carreracomboBox.SelectedIndex == 1)
            {
                preciocreditotextBox.Text = "$850";
            }
            if (carreracomboBox.SelectedIndex == 2)
            {
                preciocreditotextBox.Text = "$1050";
            }
            if (carreracomboBox.SelectedIndex == 3)
            {
                preciocreditotextBox.Text = "$1000";
            }
            if (carreracomboBox.SelectedIndex == 4)
            {
                preciocreditotextBox.Text = "$680";
            }
            if (carreracomboBox.SelectedIndex == 5)
            {
                preciocreditotextBox.Text = "$750";
            }
            if (carreracomboBox.SelectedIndex == 6)
            {
                preciocreditotextBox.Text = "$580";
            }
            TotalCreditostextBox_TextChanged(sender, e);
        }

        private bool Cambios()
        {
            string id = matriculamaskedTextBox.Text;
            var p = LlenaClase();
            bool cambiosRealizados = false;

            foreach (var item in listaregistro)
            {
                if (item.Matricula == id)
                {
                    if (item.Nombre != p.Nombre ||
                        item.Direccion != p.Direccion ||
                        item.Telefono != p.Telefono ||
                        item.TotalCreditos != p.TotalCreditos ||
                        item.Carrera != p.Carrera)
                    {
                        item.Matricula = p.Matricula;
                        item.Nombre = p.Nombre;
                        item.Direccion = p.Direccion;
                        item.Telefono = p.Telefono;
                        item.TotalCreditos = p.TotalCreditos;
                        item.Carrera = p.Carrera;

                        cambiosRealizados = true; // Marcar que se realizaron cambios
                    }
                }
            }

            return cambiosRealizados; // Devolver si se realizaron cambios
        }

        private void TotalCreditostextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TotalCreditostextBox.Text, out int creditos))
            {
                int Balance = 0;
                if (carreracomboBox.SelectedIndex == 0)
                {
                    Balance = creditos * 850;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 1)
                {
                    Balance = creditos * 850;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 2)
                {
                    Balance = creditos * 1050;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 3)
                {
                    Balance = creditos * 1000;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 4)
                {
                    Balance = creditos * 680;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 5)
                {
                    Balance = creditos * 750;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
                if (carreracomboBox.SelectedIndex == 6)
                {
                    Balance = creditos * 580;
                    BalancetextBox.Text = Convert.ToString(Balance);
                }
            }
        }

        private void consultabutton_Click(object sender, EventArgs e)
        {
            Consulta();
        }

        private void Consulta()
        {
            try
            {
                int opcion = filtrocomboBox.SelectedIndex;
                List<Registro> lista = new List<Registro>();


                switch (opcion)
                {
                    case 0:
                        MostrarConsulta(listaregistro);
                        break;
                    case 1:
                        lista = listaregistro.Where(p => p.Nombre.Contains(criteriotextBox.Text)).ToList();
                        MostrarConsulta(lista);
                        break;
                    case 2:
                        lista = listaregistro.Where(p => p.Telefono.Contains(criteriotextBox.Text)).ToList();
                        MostrarConsulta(lista);
                        break;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void MostrarConsulta(List<Registro> lista)
        {
            consultadataGridView.DataSource = null;
            consultadataGridView.DataSource = lista;
        }

        private void criteriotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Consulta();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}