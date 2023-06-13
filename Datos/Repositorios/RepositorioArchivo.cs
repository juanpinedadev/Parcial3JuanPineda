using Datos.Interfaces.Generica;
using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Datos.Repositorios
{
    public class RepositorioArchivo : IArchivoDatos<Venta>
    {
        public List<Venta> Leer(string ruta,string codigoSedeSeleccionado)
        {
            try
            {
                List<Venta> ListVenta = new List<Venta>();
                StreamReader sr = new StreamReader(ruta);
                while (!sr.EndOfStream)
                {
                    ListVenta.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListVenta;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Venta Mapear(string linea)
        {
            Venta venta = new Venta
            {
                CodigoProducto = linea.Trim().Split(';')[0],
                CodigoSede = linea.Trim().Split(';')[1],
                Valor = decimal.Parse(linea.Trim().Split(';')[2])


                //NumFormulario = int.Parse(linea.Trim().Split(';')[0]),
                //Id = int.Parse(linea.Trim().Split(';')[1]),
                //Name = linea.Trim().Split(';')[2],
                //FechaDeclaracion = DateTime.Parse(linea.Trim().Split(';')[3]),
                //Valor = double.Parse(linea.Trim().Split(';')[4]),
                //Emplaza = bool.Parse(linea.Split(';')[5])

            };

            return venta;
        }
    }
}
