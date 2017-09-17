using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterokCompany.DAL.Repository;

namespace VeterokCompany
{
    public partial class CodeProductIngredient : Form
    {
        private readonly ProductRepository _productRepository;
        private readonly WorkIngredientRepository _workIngredientRepository;
        public CodeProductIngredient(ProductRepository productRepository, WorkIngredientRepository workIngredientRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _workIngredientRepository = workIngredientRepository;

            InitializeProductGrid();
            InitializeIngredientGrid();
        }

        private void InitializeProductGrid()
        {
            var products = _productRepository.GetProductModelsList().OrderBy(x => x.CodeProduct);
            productDataGridView.DataSource = products.ToList();

            productDataGridView.Columns[0].Visible = false;
            productDataGridView.Columns[3].Visible = false;
            productDataGridView.Columns[4].Visible = false;

            productDataGridView.Columns[1].FillWeight = 50;
            productDataGridView.Columns[2].FillWeight = 240;
        }

        private void InitializeIngredientGrid()
        {
            var ingredient = _workIngredientRepository.GetWorkIngredientsList().OrderBy(x => x.CodeIngredient);
            ingredientDataGridView.DataSource = ingredient.ToList();

            ingredientDataGridView.Columns[0].Visible = false;
            ingredientDataGridView.Columns[3].Visible = false;
            ingredientDataGridView.Columns[4].Visible = false;

            ingredientDataGridView.Columns[1].FillWeight = 50;
            ingredientDataGridView.Columns[2].FillWeight = 240;
        }
    }
}
