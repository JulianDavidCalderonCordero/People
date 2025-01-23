using People.Data;

namespace People.Application
{
    public class PersonaService
    {
        private readonly PersonaData _personaData;

        public PersonaService(string connectionString)
        {
            _personaData = new PersonaData(connectionString);
        }

        public void RegistrarPersona(string documento, string nombres, string apellidos, DateTime fechaNacimiento, List<string> telefonos, List<string> correos, List<string> direcciones)
        {
            if (string.IsNullOrWhiteSpace(documento) || string.IsNullOrWhiteSpace(nombres) || string.IsNullOrWhiteSpace(apellidos))
                throw new Exception("Documento, nombres y apellidos son obligatorios.");
            if (!documento.All(char.IsLetterOrDigit))
                throw new Exception("El documento de identidad debe ser alfanumérico.");
            if (!nombres.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) || !apellidos.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                throw new Exception("Los nombres y apellidos solo pueden contener caracteres del alfabeto latino.");
            if (telefonos.Count == 0 && correos.Count == 0 && direcciones.Count == 0)
                throw new Exception("Debe registrar al menos una información de contacto.");

            _personaData.RegistrarPersona(documento, nombres, apellidos, fechaNacimiento, telefonos, correos, direcciones);
        }
    }
}
