using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Repository
{
    public class SKUCodeRepository : ISKUCode
    {
        private readonly ApplicationDbContext _db;

        public SKUCodeRepository(ApplicationDbContext db)
        {
            _db = db;

        }

        public bool Create(SKUCode entity)
        {
            _db.SKUCodes.Add(entity);
            return Save();
        }

        public bool Delete(SKUCode entity)
        {
            _db.SKUCodes.Remove(entity);
            return Save();
        }

        public SKUCode Find(int Id)
        {
            return _db.SKUCodes.Find(Id);
        }

        public ICollection<SKUCode> FindAll()
        {
            return _db.SKUCodes.ToList();
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;


        }

        public bool Update(SKUCode entity)
        {
            _db.SKUCodes.Update(entity);
            return Save();
        }
    }
}