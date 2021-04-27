﻿using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DataAccesLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context c = new Context();
        DbSet<Category> _object;

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Insert(Category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }

        public void Delete(Category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}