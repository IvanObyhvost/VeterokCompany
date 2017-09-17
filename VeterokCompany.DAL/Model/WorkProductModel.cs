using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterokCompany.DAL.Enum;

namespace VeterokCompany.DAL.Model
{
    public class WorkProductModel
    {
        public int Id { get; set; }
        [DisplayName("Код")]
        public int CodeProduct { get; set; }
        [DisplayName("Время")]
        public DateTime TimeAdding { get; set; }
        [DisplayName("Категория")]
        public string NameCategory { get; set; }
        [DisplayName("Найменование товара")]
        public string NameProduct { get; set; }
        [DisplayName("Стоимость")]
        public decimal Сost { get; set; }
        [DisplayName("Количество")]
        public int Count { get; set; }
        [DisplayName("Итого")]
        public decimal TotalSum { get; set; }

    }
}
