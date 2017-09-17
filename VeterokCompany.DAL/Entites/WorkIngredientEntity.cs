using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterokCompany.DAL.Entites.EntityBase;
using VeterokCompany.DAL.Enum;

namespace VeterokCompany.DAL.Entites
{
    public class WorkIngredientEntity: BaseEntity
    {
        public string Name { get; set; }
        public decimal Count { get; set; }
        public string Quantities { get; set; }
        public int CodeIngredient { get; set; }
    }
}
