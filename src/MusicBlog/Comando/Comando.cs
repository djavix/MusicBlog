using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comando
{
    public abstract class Comando<E,R>
    {
        #region Atributos
        protected E _parametroEntrada;
        protected R _parametroResultado;
        #endregion

        #region Constructor
        public Comando(E parametro)
        {
            this._parametroEntrada = parametro;
        }
        #endregion

        #region Propiedades
        public R Resultado
        {
            get { return _parametroResultado; }
        }

        #endregion

        #region Metodo Abstracto
        public abstract void Ejecutar();
        #endregion
    }
}
