using Comun.Entidades;

namespace DAO.IDao
{
    public interface IDaoPerfil : IDaoBase<Perfil>
    {
        Perfil BuscarPerfilPorUsuario(Usuario usuario);
    }
}