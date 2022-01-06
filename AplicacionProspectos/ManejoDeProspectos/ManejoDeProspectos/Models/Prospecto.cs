using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Models
{
	class Prospecto
	{
		string table = "Prospecto";
		string id = "idProspecto";
		Conexion conex = new Conexion();

		string nombre;
		string primerApellido;
		string segundoApellido;
		string calle;
		string numero;
		string colonia;
		string codigoPostal;
		string telefono;
		string rfc;
		string estatus;
		string observaciones;
		public Prospecto() {

		}
		public Prospecto(string nombre, string primerApellido, string segundoApellido, string calle, string numero,
			string colonia, string codigoPostal, string telefono, string rfc, string estatus, string observaciones)
		{
			this.nombre = nombre;
			this.primerApellido = primerApellido;
			this.segundoApellido = segundoApellido;
			this.calle = calle;
			this.numero = numero;
			this.colonia = colonia;
			this.codigoPostal = codigoPostal;
			this.telefono = telefono;
			this.rfc = estatus;
			this.estatus = estatus;
			this.observaciones = observaciones;
		}

		public bool save()
		{
			string query = "insert into " + table + "(nombre,primerApellido,segundoApellido,calle,numero,colonia,codigoPostal,telefono,RFC,idEstatus,observaciones) " +
				"values ('" + this.nombre + "','" + this.primerApellido + "','" + this.segundoApellido + "','" + this.calle + "','" +
				this.numero + "','" + this.colonia + "','" + this.codigoPostal + "','" + this.telefono + "','" + this.rfc + "','" + this.estatus + "','" + this.observaciones + "')";
			return conex.ejecutar(query);
		}

		public DataTable get(string query) {

			return conex.llenarVistas(query);
		}

		public string[] getProspecto(string id) {
			string query = "select * from Prospecto where idProspecto = " + id;
			return conex.ObtenerInformacionProspecto(query);
		}

		public bool update(string query)
		{
			return conex.ejecutar(query);
		}

		public string getEvaluado(string id)
		{
			return conex.getUnDato("select evaluado from Prospecto where idProspecto =" + id);
		}
	}
}
