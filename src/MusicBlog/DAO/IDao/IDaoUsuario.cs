using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comun.Entidades;

namespace DAO.IDao
{
    public interface IDaoUsuario : IDaoBase<Usuario>
    {
        Usuario Login(Usuario usuario);
        bool ValidarNickUsuario(Usuario usuario);
    }
}
