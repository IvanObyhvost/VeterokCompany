using System.Collections.Generic;
using VeterokCompany.DAL.Entites;
using VeterokCompany.DAL.Model;

namespace VeterokCompany.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<VeterokCompany.DAL.EF.VeterokCompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(VeterokCompany.DAL.EF.VeterokCompanyContext context)
        {


            //var category = new CategoryEntity()
            //{
            //    NameCategory = "������� �����"
            //};
            //context.Categories.AddOrUpdate(category);
            //category = new CategoryEntity()
            //{
            //    NameCategory = "�������"
            //};
            //context.Categories.AddOrUpdate(category);

            //var product = new ProductEntity()
            //{
            //    Name = "��������",
            //    TimeAddProduct = DateTime.Now,
            //    �ost = 60,
            //    Count = 1,
            //    TotalSum = 60,
            //    Category = category,
            //    IdCategory = category.Id
            //};
            //context.Products.AddOrUpdate(product);
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
