using Datos.Interfaces;
using Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class SedesRepositorio : ISedesRepositorio
    {

        private readonly string connectionString = Conexion.ConexionMaestra.CadenaConexionMaestra;
        public List<Sede> Listar()
        {

                List<Sede> listaSedes = new List<Sede>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT IdSede,Nombre FROM Sede;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                            Sede sede = new Sede
                            {

                                CodigoSede = (string)reader["IdSede"],
                                Nombre = (string)reader["Nombre"],

                                };

                                listaSedes.Add(sede);
                            }
                        }
                    }
                }

            return listaSedes;
        }
    }
}

