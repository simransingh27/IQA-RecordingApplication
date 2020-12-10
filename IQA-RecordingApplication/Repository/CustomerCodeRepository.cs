using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Repository
{
    public class CustomerCodeRepository : ICustomerCode
    {
        private readonly ApplicationDbContext _db;
        public CustomerCodeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(CustomerCode entity)
        {
            _db.CustomerCodes.Add(entity);
            return Save();
        }

        public bool Delete(CustomerCode entity)
        {
            _db.CustomerCodes.Remove(entity);
            return Save();
        }

        public CustomerCode Find(int Id)
        {
            var cCode = _db.CustomerCodes.Find(Id);
            return cCode;
        }

        public ICollection<CustomerCode> FindAll()
        {
        var cCodes =  _db.CustomerCodes.ToList();

            return cCodes;
        }

        public bool IsExists(int Id)
        {
           
            throw new NotImplementedException();
        }

        public bool IsExitsCC(string Id)
        {
            var exists = _db.CustomerCodes.Any(q => q.CustomerCodeId == Id);
            return exists;
        }

        public bool Save()
        {
        return _db.SaveChanges() >0;
        }

        public bool Update(CustomerCode entity)
        {
            _db.CustomerCodes.Update(entity);
            return Save();
        }
    }
}
