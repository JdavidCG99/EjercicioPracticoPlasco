using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeProspectos.Controllers
{
	class ProspectoController
	{
		public ProspectoController() {

		}

		public DataTable index() {
			string query = "select p.idProspecto as Id, p.nombre as Nombre, p.primerApellido as Primer_Apellido, p.segundoApellido as Segundo_Apellido, d.nombre as Estatus from" +
				" Prospecto as p inner join Estatus as d on p.idEstatus=d.idEstatus";

			Models.Prospecto prospecto = new Models.Prospecto();

			return prospecto.get(query);
		}

		public bool store(string nombre, string primerApellido, string segundoApellido, string calle, string numero,
			string colonia, string codigoPostal, string telefono, string rfc,Array documentos,string [] nombres) {

			try
			{

				nombre = nombre.Trim();
				primerApellido = primerApellido.Trim();
				segundoApellido = segundoApellido.Trim();
				if (segundoApellido.Equals(""))
				{
					segundoApellido = "null";
				}
				calle = calle.Trim();
				numero = numero.Trim();
				colonia = colonia.Trim();
				codigoPostal = codigoPostal.Trim();
				telefono = telefono.Trim();
				rfc = rfc.Trim();
				string estatus = "1";
				string observaciones = "null";

				if (nombre.Length == 0 || primerApellido.Length == 0 || calle.Length == 0 || numero.Length == 0 || colonia.Length == 0
					|| codigoPostal.Length == 0 || telefono.Length == 0 || rfc.Length == 0)
				{
					MessageBox.Show("Uno de los datos obligatorios no esta llenado", "Atencion");
					return false;
				}

				Models.Prospecto prospecto = new Models.Prospecto(nombre, primerApellido, segundoApellido, calle, numero,
					colonia, codigoPostal, telefono, rfc, estatus, observaciones);

				prospecto.save();

				DocumentoController doc = new DocumentoController();
				string idPros = Convert.ToString(prospecto.getId("select max(idProspecto) from Prospecto")); 

				for(int y = 0; y < nombres.Length; y++)
				{
				//	MessageBox.Show(documentos[y].ToString());
				//	//byte [] docActual = documentos[y].GetValue(); 
				    bool res = doc.store(nombres[y],"null");
					string idDoc = Convert.ToString(prospecto.getId("select max(idDocumento) from Documento"));

					Models.DocumentoProspecto dp = new Models.DocumentoProspecto(idPros,idDoc);
					if (!res || !dp.save())
					{
						MessageBox.Show("Error al guardar los documentos", "Atencion");
						return false;
					}
				}

				return true;
			}
			catch(Exception e)
			{
				MessageBox.Show("Error al guardar el prospecto \n " + e, "Atencion");
				return false;
			}
			
		}

		public string[] show(string id) {
			Models.Prospecto prospecto = new Models.Prospecto();

			return prospecto.getProspecto(id);
		}

		public bool updateEstatus(string estatus, string id, string observaciones) {

			string query = "update Prospecto set idEstatus = " + estatus + ", observaciones = '" + observaciones + "', evaluado = 1 where idProspecto = " + id; 

			Models.Prospecto prospecto = new Models.Prospecto();

			return prospecto.update(query);
		}

		public string evaludo(string id) {

			Models.Prospecto prospecto = new Models.Prospecto();

			return prospecto.getEvaluado(id);

		}

		public DataTable getDocumentos(string id)
		{
			string query = "select d.nombre as Nombre from Documento as d inner join DocumentoProspecto as dc on d.idDocumento = dc.idDocumento " +
				" inner join Prospecto as p on dc.idProspecto = p.idProspecto where p.idProspecto = " + id;

			Models.Prospecto prospecto = new Models.Prospecto();

			return prospecto.get(query);
		}
	}	
}
