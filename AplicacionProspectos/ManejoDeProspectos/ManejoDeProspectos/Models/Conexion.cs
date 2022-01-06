using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;

namespace ManejoDeProspectos.Models
{
	class Conexion
	{
		SqlConnection con =  new SqlConnection();
		SqlCommand comando = new SqlCommand();
		SqlDataReader reader;
		public Conexion()
		{
			con = new SqlConnection("Server=DESKTOP-K6GJS3D\\SQLEXPRESS;Database=ProspectosClientes;integrated security=true");
		}
		public SqlConnection conectar()
		{
			try
			{
				con.Open();
				return con;
			}
			catch (Exception e)
			{
				MessageBox.Show("Error al conectar con la bdd");
				return null;

			}
		}
		public bool cerrar()
		{
			try
			{
				con.Close();
				return true;
			}
			catch (Exception e)
			{
				return false;

			}
		}

		public bool ejecutar(String query)
		{
			try
			{
				comando = new SqlCommand(query,conectar());
				int res = comando.ExecuteNonQuery();
				cerrar();
				return true;
			}
			catch
			{
				MessageBox.Show("Error al guardar en la base de datos", "Atencion");
				return false;
			}

		}

		public DataTable llenarVistas(string query)
		{
			DataTable y = new DataTable();
			try
			{
				SqlDataAdapter adap = new SqlDataAdapter(query,conectar());
				adap.Fill(y);
				cerrar();
				return y;

			}
			catch (Exception e)
			{
				return y;
			}

		}

		public string[] ObtenerInformacionProspecto(string query)
		{
			try
			{
				string[] datos = new string[11];

				SqlCommand comando = new SqlCommand(query, conectar());

				SqlDataReader registro = comando.ExecuteReader();

				if (registro.Read())
				{
					datos[0] = registro["nombre"].ToString();
					datos[1] = registro["primerApellido"].ToString();
					datos[2] = registro["segundoApellido"].ToString();
					datos[3] = registro["calle"].ToString();
					datos[4] = registro["numero"].ToString();
					datos[5] = registro["colonia"].ToString();
					datos[6] = registro["codigoPostal"].ToString();
					datos[7] = registro["telefono"].ToString();
					datos[8] = registro["RFC"].ToString();
					datos[9] = registro["idEstatus"].ToString();
					datos[10] = registro["observaciones"].ToString();
				}
				else
				{
					MessageBox.Show("No se encontraron datos con esa ID");
					datos = null;
				}
				cerrar();
				return datos;
			}
			catch (Exception e)
			{
				MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
				return null;
			}

		}

		public string getUnDato(string query)
		{
			string dato = "";
			try
			{ 

				SqlCommand comando = new SqlCommand(query, conectar());
				dato = Convert.ToString(comando.ExecuteScalar());
				cerrar();

			}
			catch
			{
				MessageBox.Show("Error en la bdd \n Contacte a uno de los programadores", "Atencion");
			}
			return dato;
		}

		public int getId(string query)
		{
			int id;
			try
			{

				SqlCommand comando = new SqlCommand(query, conectar());
				id = Convert.ToInt32(comando.ExecuteScalar());
				cerrar();
			}
			catch
			{
				id = 1;
			}
			return id;
		}
	}
}
