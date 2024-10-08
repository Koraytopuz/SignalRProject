﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void add (T entity);
        void delete (T entity);
        void update (T entity);
        T GetByID(int id);
        List<T> GetListAll();
    }
}
