using EAFIT_BaseDeDatos.Core.EAFIT_FACADE;
using EAFIT_BaseDeDatos.Core.EAFIT_MANAGER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAFIT_BaseDeDatos.UI
{
    public partial class Productos : Form
    {
        Form InstanciaPpal;
        bool Result = false;
        public Productos(Form ppal)
        {
            InitializeComponent();
            InstanciaPpal = ppal;
            CBEstadoAvion.SelectedIndex = 0;
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipal menu = new MenuPrincipal(null);
            menu.Show();
        }
        private void BtnNewAvion_Click(object sender, EventArgs e) 
        {
            LimpiarFormulario();
        }
        private void LimpiarFormulario()
        {
            textMatricula.Text = TxtAforo.Text = TxtSize.Text = TxtEnsamble.Text = TxtRefAvion.Text = string.Empty;
            CBEstadoAvion.SelectedIndex = 0;

            BtnUpdateAvion.Enabled = BtnDeleteAvion.Enabled = false; 
            BtnIngresarAvion.Enabled = true; 
        }

        private void BtnConsultarAvion_Click(object sender, EventArgs e) 
        {
            BtnIngresarAvion.Enabled = false;
            BtnUpdateAvion.Enabled = BtnDeleteAvion.Enabled = true;

            FacadeAviones InstSearch = new FacadeAviones();
            Dictionary<string, string> Result = new Dictionary<string, string>();

            Result = InstSearch.ValidarAvion(textMatricula.Text);
            if (Result != null)
            {
                // Mapeo de datos de avión
                TxtAforo.Text = Result.GetValueOrDefault("Aforo_maximo");
                TxtSize.Text = Result.GetValueOrDefault("Size");
                TxtEnsamble.Text = Result.GetValueOrDefault("fecha_ensamblaje_avion");
                TxtRefAvion.Text = Result.GetValueOrDefault("Referencia");
                CBEstadoAvion.Text = Result.GetValueOrDefault("Estado_avion"); 
            }
        }

        private void BtnIngresarAvion_Click(object sender, EventArgs e) 
        {
            ExecuteAvion(1);
            if (Result)
            {
                MessageBox.Show("Ingreso de avión exitoso!!", "Ingreso de Avión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al ingresar el avión, validar los datos enviados", "Ingreso de Avión", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void BtnUpdateAvion_Click(object sender, EventArgs e) 
        {
            ExecuteAvion(2);
            if (Result)
            {
                MessageBox.Show("Actualización de avión exitosa!!", "Actualización de Avión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al actualizar el avión, validar los datos enviados", "Actualización de Avión", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void BtnDeleteAvion_Click(object sender, EventArgs e) 
        {
            FacadeAviones InstInactivar = new FacadeAviones();

            bool Result = InstInactivar.InactivarAvion(textMatricula.Text); 
            if (Result)
            {
                MessageBox.Show("Inactivación de avión exitosa!!", "Inactivación de Avión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Falla al Inactivar el avión, validar los datos enviados", "Inactivación de Avión", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        internal bool ExecuteAvion(int Accion)
        {
            Result = false;

            if (string.IsNullOrEmpty(TxtAforo.Text) || string.IsNullOrEmpty(TxtSize.Text)
                || string.IsNullOrEmpty(TxtEnsamble.Text) || string.IsNullOrEmpty(textMatricula.Text)
                || string.IsNullOrEmpty(TxtRefAvion.Text)
                || CBEstadoAvion.Text == "--Seleccionar--")
            {
                MessageBox.Show("Validar los datos ingresados, todos son obligatorios." + Environment.NewLine +
                                "Por favor, verifique que ningún campo esté vacío y que haya seleccionado un Estado.",
                                "Error al ingresar los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            DateTime fechaEnsamble;
            if (!DateTime.TryParse(TxtEnsamble.Text, out fechaEnsamble))
            {
                MessageBox.Show("El campo de Fecha de Ensamblaje es inválido. Por favor, use un formato de fecha correcto.",
                                "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            Dictionary<string, string> ValuesInsert = new Dictionary<string, string>();
            ValuesInsert.Add("matricula", textMatricula.Text);
            ValuesInsert.Add("Aforo_maximo", TxtAforo.Text);
            ValuesInsert.Add("Size", TxtSize.Text);
            ValuesInsert.Add("fecha_ensamblaje_avion", TxtEnsamble.Text);
            ValuesInsert.Add("Referencia", TxtRefAvion.Text);
            ValuesInsert.Add("Estado_avion", CBEstadoAvion.Text.ToString().Trim());
            FacadeAviones InstInsertar = new FacadeAviones();
            if (Accion == 1)
                Result = InstInsertar.InsertarAvion(ValuesInsert);
            else if (Accion == 2)
                Result = InstInsertar.ActualizarAvion(ValuesInsert);

            return Result;
        }


    }
}

    
        