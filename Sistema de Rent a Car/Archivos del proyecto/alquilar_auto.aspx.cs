using System;
using System.Data.SqlClient;

namespace Hola
{
	public partial class ClaseHola: System.Web.UI.Page
	{
		public int var = 1;
		void Page_Load(object sender, EventArgs e)
		{
			// consultar datos para añadir items al control dropdownlist

			SqlConnection conexion_sql = new SqlConnection("Data Source=DESKTOP-5L7BFLN\\SERVIDOR_02 ; Initial Catalog=base_de_datos_01 ; User ID=sa ; Password=0000");
            conexion_sql.Open();
            string script_sql = "SELECT * FROM autos;";
            SqlCommand ejecutador_sql = new SqlCommand(script_sql, conexion_sql);
            SqlDataReader resultado_sql = ejecutador_sql.ExecuteReader();

			// añadiendo items al control dropdownlist

            while (resultado_sql.Read()){
				list1.Items.Add(resultado_sql["marca_modelo_auto"].ToString());
            }

            conexion_sql.Close();
		}
		public void click_enviar(object sender, EventArgs e)
	    {
	        // aqui valido la entrada

	        if (textbox1.Text == ""){
	            var = 3;
	        }
	        if (textbox2.Text == ""){
	            var = 3;
	        }
	        if (textbox3.Text == ""){
	            var = 3;
	        }
	        if (list1.Text == "seleccione_un_auto"){
	        	var = 3;
	        }

			//Response.Write();

	        // SqlConnection conexion_sql = new SqlConnection("Data Source=DESKTOP-5L7BFLN\\SERVIDOR_02 ; Initial Catalog=base_de_datos_01 ; User ID=sa ; Password=0000");
            // conexion_sql.Open();
            // string script_sql = "SELECT * FROM autos;";
            // SqlCommand ejecutador_sql = new SqlCommand(script_sql, conexion_sql);
            // SqlDataReader resultado_sql = ejecutador_sql.ExecuteReader();
            // conexion_sql.Close();

			// aqui inserto los datos a la BD

	        if (var == 1){
	        	string c1 = textbox1.Text;
	        	string c2 = textbox2.Text;
	        	string c3= textbox3.Text;
	        	string c4 = list1.Text;

	        	SqlConnection conexion_sql = new SqlConnection("Data Source=DESKTOP-5L7BFLN\\SERVIDOR_02 ; Initial Catalog=base_de_datos_01 ; User ID=sa ; Password=0000");
	            conexion_sql.Open();
	            string script_sql = "INSERT INTO autos_alquilados (nombre_cliente, fecha_inicio_alquiler, fecha_final_alquiler, auto_seleccionado, estado_alquiler) VALUES ('"+c1+"', '"+c2+"', '"+c3+"', '"+c4+"', 'activo');";
	            SqlCommand ejecutador_sql = new SqlCommand(script_sql, conexion_sql);
	            ejecutador_sql.ExecuteNonQuery();
	            conexion_sql.Close();

	            var = 2;
	        }
	        

	    }
	}
}