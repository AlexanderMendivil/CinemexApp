using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
                conexion = new SqlConnection("Data Source=LAPTOP-R35S94BS;Initial Catalog=CINEMEX;Integrated Security=True");
                //conexion = new SqlConnection("Data Source=DESKTOP-EAET5MJ;Initial Catalog=CINEMEX;Integrated Security=True");
                //conexion = new SqlConnection("Data Source=DESKTOP-UMHCMCU;Initial Catalog=CINEMEX;Integrated Security=True");
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

        public string Comprar(string nombrePel, int cant)
        {
            try
            {
                cmd = new SqlCommand("select precio from FUNCION where idPelicula in(select idPelicula from PELICULA where nombrePelicula = '"+nombrePel+"')", conexion);
                dr = cmd.ExecuteReader();
                int precioFinal = 0;
                if (dr.Read())
                {
                    precioFinal = cant * Convert.ToInt32(dr["precio"].ToString());
                    //MessageBox.Show("Se compraron " + cant + " " + nombrePel + " por $" + precioFinal + " pesos");
                }
                dr.Close();
                return precioFinal.ToString();
            }
            catch (Exception)
            {
                //MessageBox.Show("No se pudo realizar la compra " + ex.ToString());
                return "";
            }
        }

        public void LlenarCompra(string nombrePel)
        {
            try
            {
                cmd = new SqlCommand("SELECT idFuncion from FUNCION where idPelicula in(select idPelicula from PELICULA where nombrePelicula='"+nombrePel+"')", conexion);
                int idFuncion = Convert.ToInt32(cmd.ExecuteScalar());
                dr = cmd.ExecuteReader();
                dr.Close();
                cmd = new SqlCommand("INSERT INTO VENTAFUNCION VALUES(" + DatosEmpleado.idEmpleado + "," + idFuncion + ")", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
            }
            catch (Exception) { MessageBox.Show("NO SE AGREGO A VENTAFUNCION"); }
        }
        public void Modificar(string PeliculaSelect, string nombrePel, string Anio, string genero, string director, string duracion)
        {
            try
            {
                cmd = new SqlCommand("update PELICULA set nombrePelicula = '" + nombrePel + "', ano = '" + Anio + "', genero = '" + genero + "', director = '" + director + "', duracion = '" + duracion + "' where nombrePelicula = '" + PeliculaSelect + "'", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
                MessageBox.Show("Los cambios se aplicaron correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron aplicar los cambios " + ex.ToString());
            }
        }

        public void Eliminar(string PeliculaSelect)
        {
            try
            {
                cmd = new SqlCommand("delete from FUNCION where idPelicula in(select idPelicula from PELICULA where nombrePelicula = '" + PeliculaSelect + "')", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();

                cmd = new SqlCommand("delete from PELICULA where nombrePelicula = '" + PeliculaSelect + "'", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();

                MessageBox.Show("La Pelicula " + PeliculaSelect + " se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar la pelicula " + PeliculaSelect + ex.ToString());
            }
        }

        public void Agregar(int idPelicula, string nombrePel, 
            string genero, string Anio, string director, string duracion, 
            int idFuncion, string sala, string idioma, string hora, 
            int precio)
        {
            try
            {
                cmd = new SqlCommand("insert into PELICULA values(" + idPelicula + ", '" + nombrePel + "', '" + genero + "', '" + Anio+ "', '"+ director + "', '"+ duracion + "')", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();

                cmd = new SqlCommand("insert into FUNCION values(" + idFuncion + ", '" + sala + "', '" + idioma + "', '" + hora + "', " + precio + ", " + idPelicula + ")", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();

                MessageBox.Show("La pelicula " + nombrePel + " se añadió correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la película " + nombrePel + ex.ToString());
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

        public void CrearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("REPORTE.PDF");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "EMPLEADO", "SALA", "HORA", "PRECIO", "PELICULA" };
            float[] tamanios = { 2,4,2,2,4};
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            cmd = new SqlCommand("select nombreEmpleado, sala, hora, precio, nombrePelicula from EMPLEADO, VENTAFUNCION, FUNCION, PELICULA where EMPLEADO.idEmpleado = VENTAFUNCION.idEmpleado and VENTAFUNCION.idFuncion = FUNCION.idFuncion and FUNCION.idPelicula = PELICULA.idPelicula", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(dr["nombreEmpleado"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["sala"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["hora"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["precio"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["nombrePelicula"].ToString()).SetFont(fontContenido)));
            }
            documento.Add(tabla);
            documento.Close();
        }
    }
}
