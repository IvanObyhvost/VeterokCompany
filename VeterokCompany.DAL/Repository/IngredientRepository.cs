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
    public class IngredientRepository: IIngredientsRepository
    {
        private readonly VeterokCompanyContext _veterokCompanyContext;

         public IngredientRepository(VeterokCompanyContext veterokCompanyContext)
        {
            _veterokCompanyContext = veterokCompanyContext;
        }
         public IEnumerable<IngredientModel> GetIngredientsList()
        {
            var ingredients = _veterokCompanyContext.Ingredients;
            var ingredientModelList = new List<IngredientModel>();
            
            foreach (var ingredient in ingredients)
            {
                ingredientModelList.Add(new IngredientModel()
                {
                    Id = ingredient.Id,
                    Name = ingredient.Name,
                    Count = ingredient.Count,
                    Quantities = ingredient.Quantities,
                    IdProduct = ingredient.IdProduct,
                    CodeIngredient = ingredient.CodeIngredient
                });
            }

            return ingredientModelList;
        }

        public void AddOrUpdateIngredient(IngredientModel ingredient)
        {
            var ingredientEntety = new IngredientsEntity()
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Count = ingredient.Count,
                Quantities = ingredient.Quantities,
                IdProduct = ingredient.IdProduct,
                CodeIngredient = ingredient.CodeIngredient
            };

            _veterokCompanyContext.Ingredients.AddOrUpdate(ingredientEntety);
            Save();
        }

        public void DeleteIngredientByIdProduct(int idProduct)
        {
            var ingredient = _veterokCompanyContext.Ingredients.First(x => x.IdProduct == idProduct);
            _veterokCompanyContext.Ingredients.Remove(ingredient);
            Save();
        }

        public void DeleteIngredient(int id)
        {
            var ingredient = _veterokCompanyContext.Ingredients.Find(id);
            _veterokCompanyContext.Ingredients.Remove(ingredient);
            Save();
        }

        public IngredientModel GetIngredient(int code)
        {
            var ingredientEntety = _veterokCompanyContext.Ingredients.FirstOrDefault(x => x.CodeIngredient == code);
            var ingredient = new IngredientModel()
            {
                Id = ingredientEntety.Id,
                Name = ingredientEntety.Name,
                Count = ingredientEntety.Count,
                Quantities = ingredientEntety.Quantities,
                IdProduct = ingredientEntety.IdProduct,
                CodeIngredient = ingredientEntety.CodeIngredient
            };

            return ingredient;
        }

        private void Save()
        {
            _veterokCompanyContext.SaveChanges();
        }
    }
}
