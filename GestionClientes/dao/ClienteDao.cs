using GestionClientes.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes.dao
{
    internal class ClienteDao
    {
        public MySqlConnection Conectar()
        {
            string server = "localhost";
            string user = "root";
            string password = "1234";
            string database = "academia";

            string connectionString = $"Server={server};Database={database};Uid={user};Pwd={password};";

            MySqlConnection conexion = new MySqlConnection(connectionString);
            conexion.Open();

            return conexion;
        }

        public List<Cliente> ObtenerListadoDeClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            string consulta = "SELECT * FROM alumnos";
            MySqlCommand consultaCommand = new MySqlCommand(consulta);
            consultaCommand.Connection = Conectar();
            MySqlDataReader lectura = consultaCommand.ExecuteReader();

            while (lectura.Read())
            {
                Cliente cliente = new()
                {
                    Id = lectura.IsDBNull("id") ? string.Empty : lectura.GetString("id"),
                    Nombre = lectura.IsDBNull("nombre") ? string.Empty : lectura.GetString("nombre"),
                    Apellido = lectura.IsDBNull("apellido") ? string.Empty : lectura.GetString("apellido"),
                    Email = lectura.IsDBNull("email") ? string.Empty : lectura.GetString("email"),
                    Telefono = lectura.IsDBNull("telefono") ? string.Empty : lectura.GetString("telefono")
                };

                lista.Add(cliente);
            }

            lectura.Close();
            consultaCommand.Connection.Close();

            return lista;
        }


        public void Guardar(Cliente cliente)
        {
            string consulta = "INSERT INTO alumnos (`nombre`, `apellido`, `email`, `telefono`) VALUES ('" + cliente.Nombre + "', '" + cliente.Apellido + "', '" + cliente.Email + "', '" + cliente.Telefono + "')";
            MySqlCommand consultaCommand = new MySqlCommand(consulta);
            consultaCommand.Connection = Conectar();
            consultaCommand.ExecuteNonQuery();
            consultaCommand.Connection.Close();
        }

        public void Actualizar(Cliente cliente)
        {
            string consulta = "UPDATE alumnos SET nombre = '" + cliente.Nombre + "', apellido = '" + cliente.Apellido + "', email = '" + cliente.Email + "', telefono = '" + cliente.Telefono + "' WHERE id = '" + cliente.Id + "'";
            MySqlCommand consultaCommand = new MySqlCommand(consulta);
            consultaCommand.Connection = Conectar();
            consultaCommand.ExecuteNonQuery();
            consultaCommand.Connection.Close();
        }


        public void Eliminar(Cliente cliente)
        {
            string consulta = "DELETE FROM alumnos WHERE id = '" + cliente.Id + "'";
            MySqlCommand consultaCommand = new MySqlCommand(consulta);
            consultaCommand.Connection = Conectar();
            consultaCommand.ExecuteNonQuery();

            consultaCommand.Connection.Close();
        }

    }
}
