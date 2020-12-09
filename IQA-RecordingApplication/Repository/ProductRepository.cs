﻿using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Repository
{
    public class ProductRepository : IProduct
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db)
        {
            _db = db;
                
        }

        public bool Create(Product entity)
        {
            _db.Products.Add(entity);
            return Save();
        }

        public bool Delete(Product entity)
        {
            _db.Products.Remove(entity);
            return Save();
        }

        public Product Find(int Id)
        {
            return _db.Products.Find(Id);
        }

        public ICollection<Product> FindAll()
        {
           return _db.Products.ToList();
            
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;

        }

        public bool Update(Product entity)
        {
            _db.Products.Update(entity);
            return Save();
        }
    }
}
