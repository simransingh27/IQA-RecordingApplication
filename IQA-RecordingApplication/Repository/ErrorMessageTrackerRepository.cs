using IQA_RecordingApplication.Contracts;
using IQA_RecordingApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQA_RecordingApplication.Repository
{
    public class ErrorMessageTrackerRepository : IErrorMessageTracker
    {
        private readonly ApplicationDbContext _db;

        public ErrorMessageTrackerRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(ErrorMessageTrack entity)
        {
            _db.ErrorMessageTracks.Add(entity);
            return Save();
        }

        public bool Delete(ErrorMessageTrack entity)
        {
             _db.ErrorMessageTracks.Remove(entity);
            return Save();
        }

        public ErrorMessageTrack Find(int Id)
        {
            return _db.ErrorMessageTracks.Find(Id);
        }

        public ICollection<ErrorMessageTrack> FindAll()
        {
           return _db.ErrorMessageTracks.ToList();
        }

        public bool Save()
        {
           return _db.SaveChanges() > 0;
        }

        public bool Update(ErrorMessageTrack entity)
        {
            _db.ErrorMessageTracks.Update(entity);
            return Save();
        }
    }
}
