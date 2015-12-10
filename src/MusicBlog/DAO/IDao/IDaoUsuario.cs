using Comun.Entidades;

namespace DAO.IDao
{
    public interface IDaoUsuario : IDaoBase<Usuario>
    {
        Usuario Login(Usuario usuario);
        bool ValidarNickUsuario(Usuario usuario);
    }
}
