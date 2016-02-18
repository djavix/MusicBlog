namespace Presentador.Contratos
{
    public interface ILogin
    {
        string Nick { get; }
        string Password { get; }
        void MostrarMensaje(bool accion, string titulo, string mensaje);
        object SessionUsuario { get; set; }
    }
}