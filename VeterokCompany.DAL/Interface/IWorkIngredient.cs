using System.Collections.Generic;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.IRepository
{
    public interface IWorkIngredient
    {
        IEnumerable<WorkIngredientModel> GetWorkIngredientsList();
        void AddOrUpdateWorkIngredient(WorkIngredientModel workIngredient);
        void DeleteWorkIngredientByName(string name);
        void WorkIngredientSubtractionIngredient(List<IngredientModel> ingredientList, int countProduct);
        WorkIngredientModel GetWorkIngredient(int code);
    }
}