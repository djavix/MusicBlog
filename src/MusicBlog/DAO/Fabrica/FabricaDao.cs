﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Dao;
using DAO.IDao;

namespace DAO.Fabrica
{
    public class FabricaDao
    {
        public static IDaoUsuario ObtenerDaoUsuario()
        {
            return new DaoUsuario();
        }

        public static IDaoPerfil ObtenerDaoPerfil()
        {
            return new DaoPerfil();
        }

        public static IDaoRol ObtenerDaoRol()
        {
            return new DaoRol();
        }

        public static IDaoMenu ObtenerDaoMenu()
        {
            return new DaoMenu();
        }
    }
}
