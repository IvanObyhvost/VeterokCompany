using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Model
{
    public class CategoryModel
    {
        public int Id { get; set; }

        [DisplayName("Найменование")]
        public string Name { get; set; }
    }
}
