using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;

namespace DAO.NHibernate
{
    public class NHibernateManager : IDisposable
    {
        #region Atributos
        private static ISessionFactory _sessionFactory;
        public ISession Session;
        #endregion

        #region Constructor

        public NHibernateManager()
        {
            CrearSession();
            OpenSession();
        }

        #endregion

        #region Metodos Privados
        private void CrearSession()
        {
            if (_sessionFactory == null)
            {
                Configuration configuration = new Configuration().Configure();
                configuration.AddAssembly(Assembly.GetCallingAssembly());
                _sessionFactory = configuration.BuildSessionFactory();
            }
            Session = OpenSession();

        }
        #endregion

        #region Metodos publicos

        public static ISession OpenSession()
        {
            return _sessionFactory.OpenSession();
        }

        public static void CloseSession()
        {
            _sessionFactory.Dispose();
        }

        #endregion

        #region Idisposable
        public void Dispose()
        {
            CloseSession();
        }
        #endregion
    }
}
