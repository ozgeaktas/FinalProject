using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //categoryle ilgili dış dünyaya ne servis etmek istiyorsan.
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
