using DhruviPBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DhruviPBooks.DataAccess.Repository.IRepository
{

    public interface ICategoryRepository : IRepository<Category>
    {

        void Update(Category category);

    }


}


