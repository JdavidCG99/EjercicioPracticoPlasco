using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Models
{
	class DocumentoProspecto
	{
		string table = "DocumentoProspecto";
		Conexion conex = new Conexion();
		string idProspecto;
		string idDocumento;

		public DocumentoProspecto(string idProspecto, string idDocumento)
		{
			this.idProspecto = idProspecto;
			this.idDocumento = idDocumento;
		}

		public bool save() {
			string query = "insert into " + table + " (idProspecto,idDocumento) values(" + this.idProspecto + "," + this.idDocumento + ")";
			return conex.ejecutar(query);
		}
	}
}
