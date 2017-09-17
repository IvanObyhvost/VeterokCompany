using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Model
{
    public class AddOrUpdateProductModel
    {
        private int ProductId { get; set; }
        [DisplayName("Наименование")]
        public string NameProduct { get; set; }
        [DisplayName("Сумма")]
        public int Sum { get; set; }
    }
}
