using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemexApp
{
      public class ConexionDulceria
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        string tipodeDulce;

        public ConexionDulceria()
        {
            try
            {
                conexion = new SqlConnection("Data Source=LAPTOP-R35S94BS;Initial Catalog=CINEMEX;Integrated Security=True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos " + ex.ToString());
            }
        }

        public void LlenarNombreEmpleado(Label lb, string nombreEmpleado)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select nombreEmpleado from EMPLEADO where idEmpleado = '" +
                    nombreEmpleado + "'", conexion);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        lb.Text = "Le atiende:  " + dr["nombreEmpleado"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo asignar nombre al emplado " + ex.ToString());
            }
        }

        public void LlenarItemsTipoDulce(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select tipo from DULCE", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["tipo"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox Tipo de Dulce " + ex.ToString());
            }
        }

        public void LlenarItemsDulce(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select nombreDulce from DULCE where tipo = @tipodeDulce", conexion);
                cmd.Parameters.AddWithValue("tipodeDulce", tipodeDulce);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombreDulce"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox Dulce " + ex.ToString());
            }
        }

        public void Comprar(string nombreDulce , int cant)
        {
            try
            {
                cmd = new SqlCommand("select precio from DULCE where nombreDulce = '" + nombreDulce + "'", conexion);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    int precioFinal = cant * Convert.ToInt32(dr["precio"].ToString());
                    MessageBox.Show("Se compraron " + cant + " " + nombreDulce + " por $" + precioFinal + " pesos");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la compra " + ex.ToString());
            }
        }

        public void TipodeDulceSeleccionado(string tipodulce)
        {
            tipodeDulce = tipodulce;
        }
    }
}
