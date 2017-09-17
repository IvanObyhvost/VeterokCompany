using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class CategoryRepository: ICategoryRepository
    {
        private readonly VeterokCompanyContext _veterokCompanyContext;

        public CategoryRepository(VeterokCompanyContext veterokCompanyContext)
        {
            _veterokCompanyContext = veterokCompanyContext;
        }
        
        public IEnumerable<CategoryModel> GetCategoriesList()
        {
            var categoriesEntety = _veterokCompanyContext.Categories;
            var categoryList = new List<CategoryModel>();
            foreach (var category in categoriesEntety)
            {
                categoryList.Add(new CategoryModel()
                {
                    Id = category.Id,
                    Name = category.NameCategory
                });
            }

            return categoryList;
        }

        public void AddOrUpdateCategory(CategoryModel category)
        {
            var categoryEntity = new CategoryEntity()
            {
                NameCategory = category.Name,
                Id = category.Id
            };
            _veterokCompanyContext.Categories.AddOrUpdate(categoryEntity);
            Save();
        }

        private void Save()
        {
            _veterokCompanyContext.SaveChanges();
        }


        public void DeteleCategory(int id)
        {
            var category = _veterokCompanyContext.Categories.FirstOrDefault(x => x.Id == id);
            //var products = _veterokCompanyContext.Products.Where(x => x.IdCategory == id).ToList();
            //if (products.Any())
            //{
            //    foreach (var product in products)
            //    {
            //        _veterokCompanyContext.Products.Remove(product);
            //    }
            //}
            _veterokCompanyContext.Categories.Remove(category);
            Save();
        }
    }
}
