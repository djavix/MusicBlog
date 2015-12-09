using System.Collections.Generic;

namespace DAO.IDao
{
    public interface IDaoBase<TEntidad>
    {
        void Agregar(TEntidad entidad);
        void Modificar(TEntidad entidad);
        void Eliminar(TEntidad entidad);
        TEntidad BuscarPorId(int id);
        IList<TEntidad> BuscarTodos();
    }
}