using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeProspectos.Views
{
	public partial class CrearProspecto : Form
	{
		int contadorDocumentos = 0;
		Controllers.ProspectoController prospecto = new Controllers.ProspectoController();
		Controllers.Validaciones v = new Controllers.Validaciones();
		public CrearProspecto()
		{
			InitializeComponent();
		}
		private void CrearProspecto_Load(object sender, EventArgs e)
		{
		}
		string [] nombres;
		Array [] documentos = new Array[100];
		private void btnAggDocument_Click(object sender, EventArgs e)
		{
			openDialogArchivos.InitialDirectory = "C:\\";
			openDialogArchivos.Filter = "Todos los archivos (*.*)|*.*";
			openDialogArchivos.FilterIndex = 1;
			openDialogArchivos.RestoreDirectory = true;

			if (openDialogArchivos.ShowDialog() == DialogResult.OK)
			{
				byte[] file;
				Stream myStream = openDialogArchivos.OpenFile();
				using (MemoryStream ms = new MemoryStream())
				{
					myStream.CopyTo(ms);
					file = ms.ToArray();
				}
				string query = "insert into Documentos (nombre,informacion) values(" +
				"'" + openDialogArchivos.SafeFileName + "','" + file + "')";

				////conex.ejecutar(query);
				//documentos[contadorDocumentos] = file;

				//int row = dgvDocuments.Rows.Add();
				//dgvDocuments.Rows[row].Cells[0].Value = openDialogArchivos.SafeFileName;
				////dgvDocuments.Rows[row].Cells[1].Value = ruta;
				////nombres[0] = dgvDocuments.Rows[row].Cells[0].Value.ToString();
				//contadorDocumentos++;
			}
			
		}

		private void btnGuardar_Click(object sender, EventArgs e) {
			//{
			//	int l = dgvDocuments.RowCount;
			//	string[] nombres = new string[l];
			//	string[] nombresReales = new string[l];
			////char [] documentos = new char[l];
			//int numDocumentos = dgvDocuments.RowCount - 1;
			//nombres = new string [numDocumentos];
			//for (int y = 0; y < numDocumentos;  y++)
			//{ 
			//	nombres[y] = Convert.ToString(dgvDocuments.Rows[y].Cells[0].Value);
			//}

			//for (int y = 0; y < numDocumentos; y++)
			//{
			//	MessageBox.Show(nombres[y]);
			//	//MessageBox.Show(documentos[y].GetValue().ToString);
			//}

			bool respuesta = prospecto.store(tbNombre.Text, tbApellido1.Text, tbApellido2.Text, tbCalle.Text, tbNumero.Text,
				tbColonia.Text, tbCodigoPostal.Text, tbTelefono.Text, tbRfc.Text);

			if (respuesta)
			{
				MessageBox.Show("Prospecto guardado con exito", "Atencion");
			}
			else
			{
				MessageBox.Show("Error al guardar prospecto", "Atencion");
			}
		}

		private void lblNombre_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult yus = MessageBox.Show("Si no ha guardado el prospecto se perderan los datos \nSeguro que desea salir"
			 , "Atencion", MessageBoxButtons.YesNo);
			if (yus == DialogResult.Yes)
			{
				Prospectos verProspectos = new Prospectos();
				verProspectos.Show();
				this.Close();
			}
		}

		private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letras(e);
		}

		private void tbApellido1_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letras(e);
		}

		private void tbApellido2_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letras(e);
		}

		private void tbCalle_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letrasNumeros(e);
		}

		private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.numerosEnteros(e);
		}

		private void tbColonia_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letrasNumeros(e);
		}

		private void tbCodigoPostal_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.numerosEnteros(e);
		}

		private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.numerosEnteros(e);
		}

		private void tbRfc_KeyPress(object sender, KeyPressEventArgs e)
		{
			v.letrasNumeros(e);
		}
	}
}
