using System;
using System.Collections.Generic;
using VeterokCompany.DAL.Entites.EntityBase;
using VeterokCompany.DAL.Enum;

namespace VeterokCompany.DAL.Entites
{
    public class WorkProductEntity: BaseEntity
    {
        public int CodeProduct { get; set; }
        public DateTime TimeAdding { get; set; }
        public string NameProduct { get; set; }
        public decimal Cost { get; set; }
        public int Count { get; set; }
        public decimal TotalSum { get; set; }
        public string NameCategory { get; set; }

    }
}
