using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Entites
{
    public class ProductEntity
    {
        [Key]
        public int ProductId { get; set; }
        public int CodeProduct { get; set; }
        public string Name { get; set; }
        public decimal Сost { get; set; }

        public int IdCategory { get; set; }
        public string NameCategory { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual ICollection<IngredientsEntity> Ingredients { get; set; } 
    }
}
