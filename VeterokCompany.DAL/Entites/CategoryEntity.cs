using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Entites
{
    public class CategoryEntity
    {
        [Key]
        public int Id { get; set; }
        public string NameCategory { get; set; }
        public virtual ICollection<ProductEntity> Products { get; set; }

        public CategoryEntity()
        {
            Products = new List<ProductEntity>();
        }
    }
}
