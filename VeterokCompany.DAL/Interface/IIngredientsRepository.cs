using System.Collections.Generic;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.IRepository
{
    public interface IIngredientsRepository
    {
        IEnumerable<IngredientModel> GetIngredientsList();
        void AddOrUpdateIngredient(IngredientModel ingredient);
        void DeleteIngredientByIdProduct(int idProduct);
        void DeleteIngredient(int id);
        IngredientModel GetIngredient(int code);
    }
}