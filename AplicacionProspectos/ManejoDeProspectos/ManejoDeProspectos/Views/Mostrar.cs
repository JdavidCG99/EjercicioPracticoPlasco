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
	public partial class Mostrar : Form
	{
		string id;

		public Mostrar(string id)
		{
			InitializeComponent();
			this.id = id;
		}

		Controllers.ProspectoController prospecto = new Controllers.ProspectoController();
		Controllers.EstatusController estatus = new Controllers.EstatusController();

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Prospectos inicio = new Prospectos();
			inicio.Show();
			this.Hide();
		}

		private void Mostrar_Load(object sender, EventArgs e)
		{
			string [] datos = prospecto.show(this.id);

			tbNombre.Text = datos[0];
			tbApellido1.Text = datos[1];
			tbApellido2.Text = datos[2];
			tbCalle.Text = datos[3];
			tbNumero.Text = datos[4];
			tbColonia.Text = datos[5];
			tbCodigoPostal.Text = datos[6];
			tbTelefono.Text = datos[7];
			tbRfc.Text = datos[8];
			tbEstatus.Text = estatus.getNombre(datos[9]);
			if (datos[9].Equals("3")) {
				lblObservaciones.Visible = true;
				tbObservaciones.Visible = true;
			}
			tbObservaciones.Text = datos[10];

			dgvDocuments.DataSource = prospecto.getDocumentos(id);
		}
	}
}
