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

        public bool Create(SKUCode1 entity)
        {
            _db.SKUCodes.Add(entity);
            return Save();
        }


        public bool Delete(SKUCode1 entity)
        {
            _db.SKUCodes.Remove(entity);
            return Save();
        }



        public SKUCode1 Find(int Id)
        {
            return _db.SKUCodes.Find(Id);
        }

        public ICollection<SKUCode1> FindAll()
        {
            return _db.SKUCodes.ToList();
        }

        public bool FindById(string Id)
        {
            return true;

        }

        public bool IsExists(int Id)
        {
            var exists = _db.SKUCodes.Any(q => q.SKUCodeId == Id);
            return exists;
        }

        public bool IsExitsSKU(string Id)
        {
          

            var exists = false;
            return exists;
        }

        public bool Save()
        {
            return _db.SaveChanges()>0;


        }

        public bool Update(SKUCode1 entity)
        {
            _db.SKUCodes.Update(entity);
            return Save();
        }

    }
}