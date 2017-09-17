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
    public class WorkIngredientRepository: IWorkIngredient
    {
        private readonly VeterokCompanyContext _veterokCompanyContext;

        public WorkIngredientRepository(VeterokCompanyContext veterokCompanyContext)
        {
            _veterokCompanyContext = veterokCompanyContext;
        }
        public IEnumerable<WorkIngredientModel> GetWorkIngredientsList()
        {
            var workIngredients = _veterokCompanyContext.WorkIngredients;
            var workIngredientsModel = new List<WorkIngredientModel>();
            foreach (var workIngredient in workIngredients)
            {
                workIngredientsModel.Add(new WorkIngredientModel()
                {
                    Id = workIngredient.Id,
                    Name = workIngredient.Name,
                    Count = workIngredient.Count,
                    Quantities = workIngredient.Quantities,
                    CodeIngredient = workIngredient.CodeIngredient
                });
            }
            return workIngredientsModel;
        }

        public void AddOrUpdateWorkIngredient(WorkIngredientModel workIngredient)
        {
            var workIngredientEntity = new WorkIngredientEntity()
            {
                Id = workIngredient.Id,
                Name = workIngredient.Name,
                Count = workIngredient.Count,
                Quantities = workIngredient.Quantities,
                CodeIngredient = workIngredient.CodeIngredient
            };

            _veterokCompanyContext.WorkIngredients.AddOrUpdate(workIngredientEntity);
            Save();
        }

        private void Save()
        {
            try
            {
                _veterokCompanyContext.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Не удалось сохранить базу");
            }
            
        }


        public void DeleteWorkIngredientByName(string name)
        {
            var workIngredient = _veterokCompanyContext.WorkIngredients.First(x => x.Name == name);
            _veterokCompanyContext.WorkIngredients.Remove(workIngredient);
            Save();
        }

        public void WorkIngredientSubtractionIngredient(List<IngredientModel> ingredientList, int countProduct)
        {
            var workIngredients = _veterokCompanyContext.WorkIngredients;
            foreach (var ingredient in ingredientList)
            {
                if (workIngredients.Any(x => x.Name == ingredient.Name))
                {
                    var workIngredient = workIngredients.First(x => x.Name == ingredient.Name);
                    workIngredient.Count -= ingredient.Count * countProduct;
                    _veterokCompanyContext.WorkIngredients.AddOrUpdate(workIngredient);
                }
            }
            Save();
        }

        public WorkIngredientModel GetWorkIngredient(int code)
        {
            var workIngredientEntity =
                _veterokCompanyContext.WorkIngredients.FirstOrDefault(x => x.CodeIngredient == code);

            var workIngredient = new WorkIngredientModel()
            {
                Id = workIngredientEntity.Id,
                Name = workIngredientEntity.Name,
                Count = workIngredientEntity.Count,
                Quantities = workIngredientEntity.Quantities,
                CodeIngredient = workIngredientEntity.CodeIngredient
            };

            return workIngredient;
        }
    }
}
