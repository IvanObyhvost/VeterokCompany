using System.Collections.Generic;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.IRepository
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryModel> GetCategoriesList();
        void AddOrUpdateCategory(CategoryModel category);
        void DeteleCategory(int id);
    }
}