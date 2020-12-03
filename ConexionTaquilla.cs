using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemexApp
{
    class ConexionTaquilla
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        string nombrePeliculas;
        string idiomaElegido;

        public ConexionTaquilla()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-UMHCMCU;Initial Catalog=CINEMEX;Integrated Security=True");
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

        public void LlenarItemsPelicula(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select nombrePelicula from PELICULA group by nombrePelicula", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["nombrePelicula"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox Pelicula " + ex.ToString());
            }
        }

        public void LlenarItemsIdioma(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select idioma from FUNCION, PELICULA where FUNCION.idPelicula = PELICULA.idPelicula and nombrePelicula = '" + nombrePeliculas + "'", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["idioma"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox Idioma " + ex.ToString());
            }
        }

        public void LlenarItemsFuncion(ComboBox cb)
        {
            try
            {
                cmd = new SqlCommand("select hora from FUNCION, PELICULA where FUNCION.idPelicula = PELICULA.idPelicula and nombrePelicula = '" + nombrePeliculas + "' and idioma = '" + idiomaElegido + "'", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["hora"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el ComboBox Idioma " + ex.ToString());
            }
        }

        public void Comprar(string nombreDulce, int cant)
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

        public void PeliculaSeleccionada(string nombrePelicula)
        {
            nombrePeliculas = nombrePelicula;
        }

        public void IdiomaSeleccionado(string idiomaselect)
        {
            idiomaElegido = idiomaselect;
        }
    }
}
