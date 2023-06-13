using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces.Generica
{
    public interface IArchivoDatos<T>
    {
        //bool Guardar(T tipo);
        List<T> Leer(string ruta,string SedeSeleccionado);
        T Mapear(string linea);
        //bool Eliminar(List<T> lista);
    }
}
