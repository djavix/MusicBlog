using System.Drawing;
namespace Presentador.Contratos
{
    public interface IRegistro
    {
        string Nombre { get; }
        string Apellido { get; }
        string FechaNacimiento { get; }
        string Correo { get; }
        string Sexo { get; }
        string Nick { get; }
        string Password { get; }
        string RepetirPassword { get; }
        void MostrarMensaje(bool accion, string titulo, string mensaje);
        Color LblErrorNombre { set; }
        Color LblErrorApellido { set; }
        Color LblErrorFechaNacimiento { set; }
        Color LblErrorCorreo { set; }
        Color LblErrorSexo { set; }
        Color LblErrorNick { set; }
        Color LblErrorPassword { set; }
        Color LblErrorRepetirPassword { set; }
    }
}