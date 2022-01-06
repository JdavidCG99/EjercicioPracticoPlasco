using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeProspectos.Controllers
{
	class DocumentoController
	{
		public bool store(string nombre, Array document) {
			byte[] y = ConvertToBytes(document);
			//Byte[] b = Array.ConvertAll(document h => Convert.ToByte(h, 8));
			//byte[] doz = Convert.T(document,8);
			//doz.GetValue(document);

			Models.Documento doc = new Models.Documento(nombre,y);
			//return doc.save();
			return false;
		}

		static public byte[] ConvertToBytes(Array myArray)
		{
			List<byte> allBytes = new List<byte>();

			foreach (object obj in myArray)
			{
				byte[] bytes = null;

				if (obj is string)
				{
					char[] chrString = ((string)obj).ToCharArray();
					bytes = new byte[chrString.Length];
					int loop = 0;
					for (loop = 0; loop < chrString.Length; loop++)
					{
						bytes[loop] = Convert.ToByte(chrString[loop]);
					}
				}
				else if (obj is int)
				{
					bytes = BitConverter.GetBytes((int)obj);
				}
				else if (obj is double)
				{
					bytes = BitConverter.GetBytes((double)obj);
				}

				//Etc etc...
				if (bytes != null)
				{
					allBytes.AddRange(bytes);
				}
				bytes = null;
			}

			return allBytes.ToArray();

		}
	}
}
