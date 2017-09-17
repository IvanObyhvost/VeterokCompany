
using VeterokCompany.DAL.Entites.EntityBase;
using VeterokCompany.DAL.Enum;

namespace VeterokCompany.DAL.Entites
{
    public class IngredientsEntity: BaseEntity
    {
        public string Name { get; set; }
        public decimal Count { get; set; }
        public QuantitiesType Quantities { get; set; }
        public int IdProduct { get; set; }
        public virtual ProductEntity Product { get; set; }
        public int CodeIngredient { get; set; }
    }
}
