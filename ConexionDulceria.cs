using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
        string dulce;

        public ConexionDulceria()
        {
            try
            {
                //conexion = new SqlConnection("Data Source=LAPTOP-R35S94BS;Initial Catalog=CINEMEX;Integrated Security=True");
                //conexion = new SqlConnection("Data Source=DESKTOP-EAET5MJ;Initial Catalog=CINEMEX;Integrated Security=True");
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
                    dr.Close();
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
                cmd = new SqlCommand("select tipo from DULCE group by tipo", conexion);
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

        public void LlenarTxtMarca(TextBox txt)
        {
            try
            {
                cmd = new SqlCommand("select marca from DULCE where nombreDulce = '" + dulce + "'", conexion);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt.Text = dr["marca"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el TextBox Marca " + ex.ToString());
            }
        }

        public void LlenarTxtPrecio(TextBox txt)
        {
            try
            {
                cmd = new SqlCommand("select precio from DULCE where nombreDulce = '" + dulce + "'", conexion);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txt.Text = dr["precio"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el TextBox Precio " + ex.ToString());
            }
        }

        public string Comprar(string nombreDulce , int cant)
        {
            try
            {
                cmd = new SqlCommand("select precio from DULCE where nombreDulce = '" + nombreDulce + "'", conexion);
                dr = cmd.ExecuteReader();
                int precioFinal=0;
                if (dr.Read())
                {
                    precioFinal = cant * Convert.ToInt32(dr["precio"].ToString());
                    //MessageBox.Show("Se compraron " + cant + " " + nombreDulce + " por $" + precioFinal + " pesos");
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

        public void LlenarCompra(string nombreDulce){

            try
            {
                cmd = new SqlCommand("SELECT idDulce from DULCE where nombreDulce='"+nombreDulce+"'", conexion);
               int idDulce = Convert.ToInt32(cmd.ExecuteScalar());
                dr = cmd.ExecuteReader();
                dr.Close();
            cmd = new SqlCommand("INSERT INTO VENTADULCE VALUES("+DatosEmpleado.idEmpleado+","+idDulce+")",conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
            }
            catch (Exception){ MessageBox.Show("NO SE AGREGO A VENTADULCE"); }
        }

        public void Modificar(string DulceSelect, string tipoDulce, string nombreDulce, string marca, int precio)
        {
            try
            {
                cmd = new SqlCommand("update DULCE set tipo = '" + tipoDulce + "', nombreDulce = '" + nombreDulce + "', marca = '" + marca + "', precio = '" + precio + "' where nombreDulce = '" + DulceSelect + "'", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
                MessageBox.Show("Los cambios se aplicaron correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron aplicar los cambios " + ex.ToString());
            }
        }

        public void Eliminar(string DulceSelect)
        {
            try
            {
                cmd = new SqlCommand("delete from DULCE WHERE nombreDulce = '" + DulceSelect + "'", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
                MessageBox.Show("El producto " + DulceSelect + " se eliminó correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el producto " + DulceSelect + ex.ToString());
            }
        }

        public void Agregar(int idDulce, string tipoDulce, string nombreDulce, string marca, int precio)
        {
            try
            {
                cmd = new SqlCommand("insert into DULCE values('" + idDulce + "', '" + nombreDulce + "', '" + marca + "', '" + tipoDulce + "', '" + precio + "')", conexion);
                dr = cmd.ExecuteReader();
                dr.Close();
                MessageBox.Show("El producto " + nombreDulce + " se añadió correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir el producto " + nombreDulce + ex.ToString());
            }
        }

        public void TipodeDulceSeleccionado(string tipodulce)
        {
            tipodeDulce = tipodulce;
        }

        public void DulceSeleccionado(string dulces)
        {
            dulce = dulces;
        }

        public void CrearPDF()
        {
            PdfWriter pdfWriter = new PdfWriter("REPORTE_DULCERIA.PDF");
            PdfDocument pdf = new PdfDocument(pdfWriter);
            Document documento = new Document(pdf, PageSize.LETTER);

            documento.SetMargins(60, 20, 55, 20);
            PdfFont fontColumnas = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            PdfFont fontContenido = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

            string[] columnas = { "EMPLEADO", "DULCE", "PRECIO", "TIPO" };
            float[] tamanios = { 2, 2, 2, 3,  };
            Table tabla = new Table(UnitValue.CreatePercentArray(tamanios));
            tabla.SetWidth(UnitValue.CreatePercentValue(100));

            foreach (string columna in columnas)
            {
                tabla.AddHeaderCell(new Cell().Add(new Paragraph(columna).SetFont(fontColumnas)));
            }

            cmd = new SqlCommand("select nombreEmpleado, nombreDulce, precio, tipo from EMPLEADO, VENTADULCE, DULCE where EMPLEADO.idEmpleado = VENTADULCE.idEmpleado and VENTADULCE.idDulce = DULCE.idDulce", conexion);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tabla.AddCell(new Cell().Add(new Paragraph(dr["nombreEmpleado"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["nombreDulce"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["precio"].ToString()).SetFont(fontContenido)));
                tabla.AddCell(new Cell().Add(new Paragraph(dr["tipo"].ToString()).SetFont(fontContenido)));
            }
            documento.Add(tabla);
            documento.Close();
        }
    }
}
