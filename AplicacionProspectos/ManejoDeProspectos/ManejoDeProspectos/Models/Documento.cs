using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Models
{
	class Documento
	{
		string table = "Documento";
		string id = "idDocumento";
		Conexion conex = new Conexion();

		string nombre;
		byte [] document;

		public Documento(string nombre, byte [] document) {
			this.nombre = nombre;
			this.document = document;
		}

		public bool save() {
			//string doc = Convert.ToBase64String(this.document);
			string query = "insert into" + table + " (nombre,informacion) values(" +
				"'" + this.nombre+ "','"+this.document+"')";
			return conex.ejecutar(query);
		}
	}
}
