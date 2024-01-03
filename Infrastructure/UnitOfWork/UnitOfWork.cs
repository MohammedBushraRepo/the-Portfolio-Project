using Coree.Interfaces;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
       // public IGenericRepository<T> Entity 
        private readonly DataContext _context;
        private  IGenericRepository<T> _entity;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }
        public IGenericRepository<T> Entity
        {
            get
            {
                return _entity ?? (_entity = new GenericRepository<T>(_context));
                // ?? = if null give create new instance from the entity
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
