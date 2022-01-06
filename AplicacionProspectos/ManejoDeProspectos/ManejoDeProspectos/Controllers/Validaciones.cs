using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeProspectos.Controllers
{
	class Validaciones
	{
		public void numerosEnteros(KeyPressEventArgs e)
		{
			if (char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar))
			{
				
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("En ese campo solo se admiten numeros enteros", "Atencion");
				e.Handled = true;
			}

		}

		public void letrasNumeros(KeyPressEventArgs e)
		{
			if (char.IsLetterOrDigit(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsSeparator(e.KeyChar))
			{
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("En ese campo solo se admiten letras y numeros", "Atencion");
				e.Handled = true;
			}
		}

		public void letras(KeyPressEventArgs e)
		{
			if (char.IsLetter(e.KeyChar) | char.IsControl(e.KeyChar) | char.IsSeparator(e.KeyChar))
			{
				
				e.Handled = false;
			}
			else
			{
				MessageBox.Show("En ese campo solo se admiten letras", "Atencion");
				e.Handled = true;
			}
		}
	}
}
