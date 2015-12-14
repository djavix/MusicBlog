namespace Presentador.Contratos
{
    public interface IPresenterBase
    {
        string MensajeInformativo { set; }
        string MensajeError { set; }
        void MonstrarMensarjeInformativo();
        void MonstarMensajeError();
    }
}