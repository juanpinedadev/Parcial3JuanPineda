using Datos.Repositorios;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class TipoSedeServicio
    {
        SedesRepositorio sedeRepositorio = new SedesRepositorio();

        public List<Sede> Listar()
        {
            return sedeRepositorio.Listar();
        }
    }
}
