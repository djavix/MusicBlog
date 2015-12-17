namespace Presentador.Contratos
{
    public interface IPresenterUsuario: IPresenterBase
    {
        string Nick { get; set; }
        string Password { get; set; }
    }
}