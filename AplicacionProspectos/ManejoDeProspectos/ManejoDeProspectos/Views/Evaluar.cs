using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeProspectos.Views
{
	public partial class Evaluar : Form
	{
		string id;

		public Evaluar(string id)
		{
			InitializeComponent();
			this.id = id;
		}

		Controllers.ProspectoController prospecto = new Controllers.ProspectoController();
		Controllers.EstatusController estatus = new Controllers.EstatusController();

		private void Evaluar_Load(object sender, EventArgs e)
		{
			string[] datos = prospecto.show(this.id);

			tbNombre.Text = datos[0];
			tbApellido1.Text = datos[1];
			tbApellido2.Text = datos[2];
			tbCalle.Text = datos[3];
			tbNumero.Text = datos[4];
			tbColonia.Text = datos[5];
			tbCodigoPostal.Text = datos[6];
			tbTelefono.Text = datos[7];
			tbRfc.Text = datos[8];
			cbEstatus.SelectedIndex = Convert.ToInt32(datos[9]) - 1;
			tbObservaciones.Text = datos[10];
			if (tbObservaciones.Text.Equals("null"))
			{
				tbObservaciones.Text = "";
			}
			if (prospecto.evaludo(this.id).Equals("1"))
			{
				cbEstatus.Enabled = false;
				tbObservaciones.ReadOnly = true;
			}

			dgvDocuments.DataSource = prospecto.getDocumentos(id);
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Prospectos inicio = new Prospectos();
			inicio.Show();
			this.Hide();
		}

		private void cbEstatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbEstatus.SelectedIndex == 2)
			{
				lblObservaciones.Text = "Observaciones:*";
			}
			else
			{
				lblObservaciones.Text = "Observaciones:";
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (cbEstatus.SelectedIndex == 2 && tbObservaciones.TextLength == 0)
			{
				MessageBox.Show("Las observaciones son obligatorias al asignar un estatus de rechazado", "Atencion");
			} else if (cbEstatus.SelectedIndex == 0) {
				MessageBox.Show("El estatus sigue en evaluacion, cambielo o use el botn de salir", "Atencion");
			}
			else {
				prospecto.updateEstatus(Convert.ToString(cbEstatus.SelectedIndex + 1), this.id,tbObservaciones.Text);
				MessageBox.Show("Evaluacion echa con exito","Finalizado");
				Prospectos inicio = new Prospectos();
				inicio.Show();
				this.Hide();
			}
		}
	}
}
