using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Hola
{
	public partial class ClaseHola: System.Web.UI.Page
	{
		public SqlDataReader resultado_sql;
		void Page_Load(object sender, EventArgs e)
		{
			// consultar en BD los datos

			SqlConnection conexion_sql = new SqlConnection("Data Source=DESKTOP-5L7BFLN\\SERVIDOR_02 ; Initial Catalog=base_de_datos_01 ; User ID=sa ; Password=0000");
            conexion_sql.Open();
            string script_sql = "SELECT * FROM autos_alquilados WHERE estado_alquiler = 'activo';";
            SqlCommand ejecutador_sql = new SqlCommand(script_sql, conexion_sql);
            resultado_sql = ejecutador_sql.ExecuteReader();

            while (resultado_sql.Read())
            {
                TableRow row = new TableRow();

                TableCell cell1 = new TableCell();
                TableCell cell2 = new TableCell();
                TableCell cell3 = new TableCell();
                TableCell cell4 = new TableCell();

                cell1.Text = resultado_sql["nombre_cliente"].ToString();
                cell2.Text = resultado_sql["fecha_inicio_alquiler"].ToString();
                cell3.Text = resultado_sql["fecha_final_alquiler"].ToString();
                cell4.Text = resultado_sql["auto_seleccionado"].ToString();

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);               

                table1.Rows.Add(row);
            }

		}
	}
}