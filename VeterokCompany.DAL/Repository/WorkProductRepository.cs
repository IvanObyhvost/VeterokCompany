using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using VeterokCompany.DAL.EF;
using VeterokCompany.DAL.Entites;
using VeterokCompany.DAL.IRepository;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.Repository
{
    public class WorkProductRepository: IWorkProductRepository
    {
        private readonly VeterokCompanyContext _veterokCompanyContext;

        public WorkProductRepository(VeterokCompanyContext veterokCompanyContext)
        {
            _veterokCompanyContext = veterokCompanyContext;
        }
        public IEnumerable<WorkProductModel> GetWorkProductsList()
        {
            var workProductsEntity = _veterokCompanyContext.WorkProducts;
            var productsList = new List<WorkProductModel>();

            foreach (var product in workProductsEntity)
            {
                productsList.Add(new WorkProductModel()
                {
                    Id = product.Id,
                    CodeProduct = product.CodeProduct,
                    NameProduct = product.NameProduct,
                    TimeAdding = product.TimeAdding,
                    Сost = product.Cost,
                    Count = product.Count,
                    TotalSum = product.TotalSum,
                    NameCategory = product.NameCategory
                });
            }
            return productsList;
        }

        public void AddOrUpdateWorkProduct(WorkProductModel workProduct)
        {

            var product = new WorkProductEntity()
            {
                CodeProduct = workProduct.CodeProduct,
                NameProduct = workProduct.NameProduct,
                TimeAdding = workProduct.TimeAdding,
                Cost = workProduct.Сost,
                Count = workProduct.Count,
                TotalSum = workProduct.TotalSum,
                NameCategory = workProduct.NameCategory
            };

            _veterokCompanyContext.WorkProducts.AddOrUpdate(product);
            Save();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        private void Save()
        {
            _veterokCompanyContext.SaveChanges();
        }
    }
}
