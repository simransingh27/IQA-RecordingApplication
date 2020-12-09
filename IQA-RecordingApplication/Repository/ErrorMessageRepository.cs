using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Repository
{
    public class ErrorMessageRepository : IErrorMessage
    {
        private readonly ApplicationDbContext _db;

        public ErrorMessageRepository(ApplicationDbContext db)
        {
            _db = db;

        }
        public bool Create(ErrorMessage entity)
        {
            _db.ErrorMessages.Add(entity);
            return Save();
        }

        public bool Delete(ErrorMessage entity)
        {
            _db.ErrorMessages.Remove(entity);
            return Save();
        }

        public ErrorMessage Find(int Id)
        {
            return _db.ErrorMessages.Find(Id);
        }

        public ICollection<ErrorMessage> FindAll()
        {
               return _db.ErrorMessages.ToList();

        }

        public bool Save()
        {
            return _db.SaveChanges()>0;
        }

        public bool Update(ErrorMessage entity)
        {
            _db.ErrorMessages.Update(entity);
            return Save();
        }
    }
}
