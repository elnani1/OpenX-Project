using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OpenX_Interfaces
{
    public class DataBaseManager
    {
        private string connectionString = "Data Source=User5594-PC\\SQLEXPRESS;Initial Catalog=OpenX;Integrated Security=True";

        public void GuardarUsuario(Usuario nuevoUsuario)
        {
            string sql = "INSERT INTO Usuarios (NombreUsuario, Contrasena, Rol) VALUES (@nombre, @contrasena, @rol)";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nuevoUsuario.NombreUsuario);
                    comando.Parameters.AddWithValue("@contrasena", nuevoUsuario.Contraseña);
                    comando.Parameters.AddWithValue("@rol", nuevoUsuario.Rol);

                    try
                    {
                        conexion.Open();
                        comando.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al guardar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Usuario ValidarCredenciales(string nombreUsuario, string contrasena)
        {
            string sql = "SELECT NombreUsuario, Contrasena, Rol FROM Usuarios WHERE NombreUsuario = @nombre AND Contrasena = @contrasena";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", nombreUsuario);
                    comando.Parameters.AddWithValue("@contrasena", contrasena);

                    conexion.Open();
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string rolDB = reader["Rol"].ToString();
                            // Se encontró un usuario, crea el objeto y devuélvelo
                            return new Usuario
                            {
                                NombreUsuario = reader["NombreUsuario"].ToString(),
                                Contraseña = reader["Contrasena"].ToString(),
                                Rol = rolDB.Trim()
                            };
                        }
                        else
                        {
                            // No se encontró ningún usuario con esas credenciales
                            return null;
                        }
                    }
                }
            }
        }

        public Usuario ActualizarUsuario(Usuario usuarioActualizado)
        {
            string sql = "UPDATE Usuarios SET Contrasena = @contrasena, Rol = @rol WHERE NombreUsuario = @nombre";
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombre", usuarioActualizado.NombreUsuario);
                    comando.Parameters.AddWithValue("@contrasena", usuarioActualizado.Contraseña);
                    comando.Parameters.AddWithValue("@rol", usuarioActualizado.Rol);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            return usuarioActualizado; // Retorna el usuario actualizado
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario para actualizar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return null;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            string sql = "SELECT NombreUsuario, Contrasena, Rol FROM Usuarios";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    try
                    {
                        conexion.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario
                                {
                                    NombreUsuario = reader["NombreUsuario"].ToString(),
                                    Contraseña = reader["Contrasena"].ToString(),
                                    Rol = reader["Rol"].ToString().Trim()
                                };
                                listaUsuario.Add(usuario);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al obtener los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return listaUsuario;
        }

        public void EliminarUsuario(string nombreUsuario)
        {
            string sql = "DELETE FROM Usuarios WHERE NombreUsuario = @nombreUsuario";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    try
                    {
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if(filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
