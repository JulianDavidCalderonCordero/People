using Microsoft.Data.SqlClient;

namespace People.Data
{
    public class PersonaData
    {
        private readonly string _connectionString;

        public PersonaData(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void RegistrarPersona(string documento, string nombres, string apellidos, DateTime fechaNacimiento, List<string> telefonos, List<string> correos, List<string> direcciones)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string queryCheck = "SELECT COUNT(*) FROM Personas WHERE DocumentoIdentidad = @Documento";
                using (SqlCommand commandCheck = new SqlCommand(queryCheck, connection))
                {
                    commandCheck.Parameters.AddWithValue("@Documento", documento);
                    int count = (int)commandCheck.ExecuteScalar();
                    if (count > 0)
                        throw new Exception("Ya existe una persona con el mismo documento de identidad.");
                }

                string queryInsertPersona = @"
                    INSERT INTO Personas (DocumentoIdentidad, Nombres, Apellidos, FechaNacimiento) 
                    VALUES (@Documento, @Nombres, @Apellidos, @FechaNacimiento)";
                using (SqlCommand commandInsertPersona = new SqlCommand(queryInsertPersona, connection))
                {
                    commandInsertPersona.Parameters.AddWithValue("@Documento", documento);
                    commandInsertPersona.Parameters.AddWithValue("@Nombres", nombres);
                    commandInsertPersona.Parameters.AddWithValue("@Apellidos", apellidos);
                    commandInsertPersona.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);
                    commandInsertPersona.ExecuteNonQuery();
                }

                int maxTelefonos = Math.Min(2, telefonos.Count);
                for (int i = 0; i < maxTelefonos; i++)
                {
                    string queryInsertTelefono = @"
                        INSERT INTO Telefonos (DocumentoIdentidad, Telefono) 
                        VALUES (@Documento, @Telefono)";
                    using (SqlCommand commandInsertTelefono = new SqlCommand(queryInsertTelefono, connection))
                    {
                        commandInsertTelefono.Parameters.AddWithValue("@Documento", documento);
                        commandInsertTelefono.Parameters.AddWithValue("@Telefono", telefonos[i]);
                        commandInsertTelefono.ExecuteNonQuery();
                    }
                }

                int maxCorreos = Math.Min(2, correos.Count);
                for (int i = 0; i < maxCorreos; i++)
                {
                    string queryInsertCorreo = @"
                        INSERT INTO Correos (DocumentoIdentidad, Correo) 
                        VALUES (@Documento, @Correo)";
                    using (SqlCommand commandInsertCorreo = new SqlCommand(queryInsertCorreo, connection))
                    {
                        commandInsertCorreo.Parameters.AddWithValue("@Documento", documento);
                        commandInsertCorreo.Parameters.AddWithValue("@Correo", correos[i]);
                        commandInsertCorreo.ExecuteNonQuery();
                    }
                }

                int maxDirecciones = Math.Min(2, direcciones.Count);
                for (int i = 0; i < maxDirecciones; i++)
                {
                    string queryInsertDireccion = @"
                        INSERT INTO Direcciones (DocumentoIdentidad, Direccion) 
                        VALUES (@Documento, @Direccion)";
                    using (SqlCommand commandInsertDireccion = new SqlCommand(queryInsertDireccion, connection))
                    {
                        commandInsertDireccion.Parameters.AddWithValue("@Documento", documento);
                        commandInsertDireccion.Parameters.AddWithValue("@Direccion", direcciones[i]);
                        commandInsertDireccion.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
