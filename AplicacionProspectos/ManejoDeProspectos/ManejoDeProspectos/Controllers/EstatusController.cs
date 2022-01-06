using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Controllers
{
	class EstatusController
	{
		public string getNombre(string id) {

			Models.Estatus e = new Models.Estatus();
			return e.show(id);
		}
	}
}
