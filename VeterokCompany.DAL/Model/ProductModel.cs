using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Model
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("Код")]
        public int CodeProduct { get; set; }
        [DisplayName("Найменование товара")]
        public string NameProduct { get; set; }
        public string NameCategory { get; set; } 
        public decimal Cost { get; set; }
    }
}
