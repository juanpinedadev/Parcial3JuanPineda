using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ServicioVenta
    {
        RepositorioArchivo repositorioArchivo = new RepositorioArchivo();


        public List<Venta> ObtenerVentasPorSede(string rutaArchivo, string codigoSedeSeleccionada)
        {
            List<Venta> ventas = new List<Venta>();
            string[] lineasArchivo = File.ReadAllLines(rutaArchivo);

            foreach (string linea in lineasArchivo)
            {
                string[] datosVenta = linea.Split(';');

                if (datosVenta.Length == 3)
                {
                    string codigoSede = datosVenta[0];

                    if (codigoSede == codigoSedeSeleccionada)
                    {
                        string codigoProducto = datosVenta[1];
                        decimal valorVenta = decimal.Parse(datosVenta[2]);

                        Venta venta = new Venta
                        {
                            CodigoSede = codigoSede,
                            CodigoProducto = codigoProducto,
                            Valor = valorVenta
                        };

                        ventas.Add(venta);
                    }
                }
            }

            return ventas;
        }

        public List<Venta> Leer(string ruta,string sedeSeleccionada)
        {
           return repositorioArchivo.Leer(ruta,sedeSeleccionada);
        }
    }
}
