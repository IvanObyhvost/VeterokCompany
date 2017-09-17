using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterokCompany.DAL.Enum;

namespace VeterokCompany.DAL.Model
{
    public class IngredientModel
    {
        public int Id { get; set; }
        [DisplayName("Код")]
        public int CodeIngredient { get; set; }
        [DisplayName("Найменование")]
        public string Name { get; set; }
        [DisplayName("Количество")]
        public decimal Count { get; set; }
        [DisplayName("Единицы измерения")]
        public QuantitiesType Quantities { get; set; }
        public int IdProduct { get; set; }
        public ProductModel ProductModel { get; set; }
    }
}
