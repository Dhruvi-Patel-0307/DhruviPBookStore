using DhruviPBooks.DataAccess.Repository.IRepository;
using DhruviPBooks.Models;
using DhruviPBookStore.DataAccess.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviPBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;
                _db.SaveChanges();
            }
        }
    }
}
