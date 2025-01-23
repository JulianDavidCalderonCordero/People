using People.Application;
using System.Configuration;

namespace People
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            var personaService = new PersonaService(connectionString);

            try
            {
                Console.WriteLine("Ingrese los datos de la persona:");
                Console.Write("Documento de Identidad: ");
                string documento = Console.ReadLine();
                Console.Write("Nombres: ");
                string nombres = Console.ReadLine();
                Console.Write("Apellidos: ");
                string apellidos = Console.ReadLine();
                Console.Write("Fecha de Nacimiento (yyyy-MM-dd): ");
                DateTime fechaNacimiento = DateTime.Parse(Console.ReadLine());

                var telefonos = new List<string> { "123456789", "987654321" };
                var correos = new List<string> { "correo1@example.com", "correo2@example.com" };
                var direcciones = new List<string> { "Calle 1", "Calle 2" };

                personaService.RegistrarPersona(documento, nombres, apellidos, fechaNacimiento, telefonos, correos, direcciones);

                Console.WriteLine("Persona registrada exitosamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
