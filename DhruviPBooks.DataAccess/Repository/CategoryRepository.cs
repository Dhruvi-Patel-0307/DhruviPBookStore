using DhruviPBooks.DataAccess.Repository.IRepository;
using DhruviPBooks.Models;
using DhruviPBookStore.DataAccess.Data;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DhruviPBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {

            _db = db;

        }


        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if(objFromDb != null)
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

        }
    }
}