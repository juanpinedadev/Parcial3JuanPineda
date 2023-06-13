using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaces
{
    public interface IRepositorioListar<T> where T : class
    {
        List<T> Listar();
    }
}
