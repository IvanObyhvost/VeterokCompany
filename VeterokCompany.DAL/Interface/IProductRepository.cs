using System.Collections.Generic;
using VeterokCompany.DAL.Entites;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetProductModelsList();
        void AddOrUpdateProduct(ProductModel product);
        void DeleteProduct(int id);
        ProductModel GetProduct(int code);
    }
}