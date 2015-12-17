namespace Presentador.Contratos
{
    public interface IPresenterBase
    {
        string Accionador { set; }
        string TituloMensaje { set; }
        string Mensaje { set; }
        void MostarMensaje(bool accion);
    }
}