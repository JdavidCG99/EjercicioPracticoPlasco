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
	public partial class Prospectos : Form
	{
		public Prospectos()
		{
			InitializeComponent();
		}

		Controllers.ProspectoController prospectos = new Controllers.ProspectoController();

		private void Prospectos_Load(object sender, EventArgs e)
		{
			dgvProspectos.DataSource = prospectos.index();
		}

		private void dgvProspectos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnCrear_Click(object sender, EventArgs e)
		{
			CrearProspecto nuevoProspecto = new CrearProspecto();
			nuevoProspecto.Show();
			this.Hide();
		}

		private void btnVer_Click(object sender, EventArgs e)
		{
			try
			{
				string id = dgvProspectos.CurrentRow.Cells[0].Value.ToString();
				Mostrar mostrarProspecto = new Mostrar(id);
				mostrarProspecto.Show();
				this.Hide();
			}
			catch
			{
				MessageBox.Show("No hay un prospecto seleccionado");
			}
			
		}

		private void btnEvaluar_Click(object sender, EventArgs e)
		{
			
			try {
				string id = dgvProspectos.CurrentRow.Cells[0].Value.ToString();

				Evaluar evaluarProspecto = new Evaluar(id);
				evaluarProspecto.Show();
				this.Hide();
			}
			catch
			{
				MessageBox.Show("No hay un prospecto seleccionado");
			}

		}

		private void Prospectos_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
