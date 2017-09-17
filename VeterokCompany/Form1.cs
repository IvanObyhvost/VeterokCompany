using System;
using System.Linq;
using System.Windows.Forms;
using VeterokCompany.DAL.EF;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;
using VeterokCompany.DAL.Resource;

namespace VeterokCompany
{
    public partial class Form1 : Form
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly WorkProductRepository _workProductRepository;
        private readonly IngredientRepository _ingredientRepository;
        private readonly WorkIngredientRepository _workIngredientRepository;

        private readonly VeterokCompanyContext _veterokCompanyContext = new VeterokCompanyContext();
        public Form1()
        {
            InitializeComponent();
            _productRepository = new ProductRepository(_veterokCompanyContext);
            _categoryRepository = new CategoryRepository(_veterokCompanyContext);
            _workProductRepository = new WorkProductRepository(_veterokCompanyContext);
            _ingredientRepository = new IngredientRepository(_veterokCompanyContext);
            _workIngredientRepository = new WorkIngredientRepository(_veterokCompanyContext);

            InitializeFirst();
            idProductLabel.Text = ConstantName.MinValue.ToString();
        }

        private void InitializeFirst()
        {
            //UpdateComboBoxs();
            UpdateGrid();
        }
        private void UpdateGrid()
        {
            var workProducts = _workProductRepository.GetWorkProductsList().OrderByDescending(x => x.Id)
                .Where(x => x.TimeAdding.Date == DateTime.Today).ToList();
            dataGridView1.DataSource = workProducts;
            countProductComboBox.SelectedIndex = ConstantName.MinValue;
            incomeLabel.Text = workProducts.Sum(x => x.TotalSum).ToString();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;

            dataGridView1.Columns[1].FillWeight = 30;
            dataGridView1.Columns[3].FillWeight = 80;
            dataGridView1.Columns[4].FillWeight = 240;
            dataGridView1.Columns[5].FillWeight = 40;
            dataGridView1.Columns[6].FillWeight = 45;
            dataGridView1.Columns[7].FillWeight = 40;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newProduct = new NewProduct(_productRepository, _categoryRepository, _ingredientRepository, _workIngredientRepository);
            newProduct.Show();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var newCategory = new NewCategory(_productRepository, _categoryRepository);
            newCategory.Show();
        }

        private void saleProductButton_Click(object sender, EventArgs e)
        {
            var idProduct = Convert.ToInt32(idProductLabel.Text);
            if (idProduct != ConstantName.MinValue)
            {
                var nameProductAndCategory = nameProductTextBox.Text.Split('>');
                var product = new WorkProductModel()
                {
                    NameProduct = nameProductAndCategory[1],
                    TimeAdding = DateTime.Now,
                    Сost = Convert.ToDecimal(costTextBox.Text),
                    Count = Convert.ToInt32(countProductComboBox.Text),
                    TotalSum = Convert.ToDecimal(costTextBox.Text) * Convert.ToInt32(countProductComboBox.Text),
                    NameCategory = nameProductAndCategory[0],
                    CodeProduct = Convert.ToInt32(codeProductLabel.Text)
                };

                _workProductRepository.AddOrUpdateWorkProduct(product);
                UpdateGrid();


                var ingredients = _ingredientRepository.GetIngredientsList().Where(x => x.IdProduct == idProduct).ToList();
                _workIngredientRepository.WorkIngredientSubtractionIngredient(ingredients, product.Count);
            }
        }

        private void ingredientButton_Click(object sender, EventArgs e)
        {
            var newIngredients = new NewIngredients(_productRepository, _categoryRepository, _ingredientRepository, _workIngredientRepository);
            newIngredients.Show();
        }

        private void getSaleStatisticButton_Click(object sender, EventArgs e)
        {
            var statisticSale = new StatisticSale(_workProductRepository);
            statisticSale.Show();
        }

        private void addIngredientsButton_Click(object sender, EventArgs e)
        {
            var addIngredients = new AddIngredients(_workIngredientRepository);
            addIngredients.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchProductById();
        }

        private void SearchProductById()
        {
            var code = Convert.ToInt32(codeNumericUpDown.Value);
            var product = _productRepository.GetProduct(code);
            if (product != null)
            {
                nameProductTextBox.Text = String.Format(ConstantName.NameCategoryAndProduct, product.NameCategory, product.NameProduct);
                costTextBox.Text = product.Cost.ToString();
                idProductLabel.Text = product.Id.ToString();
                codeProductLabel.Text = product.CodeProduct.ToString();
            }
            else
            {
                MessageBox.Show(ConstantName.DontSearchProductMessage, ConstantName.Attention);
                idProductLabel.Text = ConstantName.MinValue.ToString();
            }
        }

        private void codeNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SearchProductById();
            }
        }

        private void codeViewButton_Click(object sender, EventArgs e)
        {
            var codeProductIngredient = new CodeProductIngredient(_productRepository, _workIngredientRepository);
            codeProductIngredient.Owner = this;
            codeProductIngredient.Show();
        }
    }
}
