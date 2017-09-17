using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterokCompany.DAL.EF;
using VeterokCompany.DAL.Entites;
using VeterokCompany.DAL.IRepository;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly VeterokCompanyContext _veterokCompanyContext;

        public ProductRepository(VeterokCompanyContext veterokCompanyContext)
        {
            _veterokCompanyContext = veterokCompanyContext;
        }

        public void AddOrUpdateProduct(ProductModel product)
        {
            var categoryEntity =
                _veterokCompanyContext.Categories.FirstOrDefault(x => x.NameCategory == product.NameCategory);

            var productEntity = new ProductEntity()
            {
                ProductId = product.Id,
                CodeProduct = product.CodeProduct,
                Name = product.NameProduct,
                Сost = product.Cost,
                IdCategory = categoryEntity.Id,
                NameCategory = product.NameCategory,
                Category = categoryEntity
            };

            _veterokCompanyContext.Products.AddOrUpdate(productEntity);
            Save();
        }

        public void DeleteProduct(int id)
        {
            var productEntity = _veterokCompanyContext.Products.FirstOrDefault(x => x.ProductId == id);
            _veterokCompanyContext.Products.Remove(productEntity);
            Save();
        }

        public ProductModel GetProduct(int code)
        {
            var productEntity = _veterokCompanyContext.Products.FirstOrDefault(x => x.CodeProduct == code);
            if (productEntity != null)
            {
                var product = new ProductModel()
                {
                    Id = productEntity.ProductId,
                    NameProduct = productEntity.Name,
                    Cost = productEntity.Сost,
                    CodeProduct = productEntity.CodeProduct,
                    NameCategory = productEntity.NameCategory
                };
                return product;
            }
            return null;

        }

        private void Save()
        {
            _veterokCompanyContext.SaveChanges();
        }

        public IEnumerable<ProductModel> GetProductModelsList()
        {
            var addProducts = new List<ProductModel>();
            var productsEntity = _veterokCompanyContext.Products.ToList();
            var categotyEntity = _veterokCompanyContext.Categories;
            
            foreach (var product in productsEntity)
            {
                var category = new CategoryModel()
                {
                    Name = categotyEntity.FirstOrDefault(x => x.Id == product.IdCategory).NameCategory
                };
                addProducts.Add(new ProductModel()
                {
                    Id = product.ProductId,
                    CodeProduct = product.CodeProduct,
                    NameProduct = product.Name,
                    NameCategory = category.Name,
                    Cost = product.Сost
                });
            }
            
            return addProducts;
        }
    }
}
