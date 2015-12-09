using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Entidades
{
    public class Perfil : Entidad
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private char _sexo;
        private string _correo;
        private Usuario _usuario;

        public Perfil()
            : base()
        {
            
        }

        public virtual string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public virtual string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public virtual DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public virtual char Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public virtual string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
    }
}
