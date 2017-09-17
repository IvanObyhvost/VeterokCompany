using System.Collections.Generic;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.IRepository
{
    public interface IWorkProductRepository
    {
        IEnumerable<WorkProductModel> GetWorkProductsList();
        void AddOrUpdateWorkProduct(WorkProductModel workProduct);
        void DeleteProduct(int id);
    }
}