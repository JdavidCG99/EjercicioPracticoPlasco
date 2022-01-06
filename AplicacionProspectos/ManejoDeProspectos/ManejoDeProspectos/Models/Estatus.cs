using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Models
{
	class Estatus
	{
		Conexion con = new Conexion();
		public string show(string id)
		{
			return con.getUnDato("select nombre from Estatus where idEstatus =" + id);
		}
	}
}
