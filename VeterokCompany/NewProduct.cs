using System;
using System.Linq;
using System.Windows.Forms;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;
using VeterokCompany.DAL.Resource;

namespace VeterokCompany
{
    public partial class NewProduct : Form
    {
        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly IngredientRepository _ingredientRepository;
        private readonly WorkIngredientRepository _workIngredientRepository;
        public NewProduct(ProductRepository productRepository, CategoryRepository categoryRepository,
            IngredientRepository ingredientRepository,
            WorkIngredientRepository workIngredientRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _ingredientRepository = ingredientRepository;
            _workIngredientRepository = workIngredientRepository;

            InitializeFist();
        }
        private void InitializeFist()
        {
            var categories = _categoryRepository.GetCategoriesList();
            categoryComboBox.DataSource = categories.Select(x => x.Name).ToList();

            if(categoryComboBox.SelectedIndex != -1)
                categoryComboBox.SelectedIndex = 0;
        }

        private void InitializeGrid()
        {
            productDataGrid.Columns[0].Visible = false;
            productDataGrid.Columns[3].Visible = false;
            productDataGrid.Columns[4].Visible = false;

            productDataGrid.Columns[1].FillWeight = 13;
            productDataGrid.Columns[2].FillWeight = 60;
            addOrUpdateProductGroupBox.Visible = false;
            deleteButton.Visible = false;
            validMessageLabel.Visible = false;
        }

        private void UpdateGrid()
        {
            var nameCategory = categoryComboBox.Text;

            var addProduct = _productRepository.GetProductModelsList().Where(x => x.NameCategory == nameCategory).ToList();
            productDataGrid.DataSource = addProduct;
            InitializeGrid();
        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void addNewProductButton_Click(object sender, EventArgs e)
        {
            addOrUpdateProductGroupBox.Text = ConstantName.AddProduct;
            saveButton.Text = ConstantName.Add;
            addOrUpdateProductGroupBox.Visible = true;
            nameProductTextBox.Text = String.Empty;
            coastNumeric.Value = ConstantName.MinValue;
            idLabel.Text = ConstantName.MinValue.ToString();
            deleteButton.Visible = false;
            validMessageLabel.Visible = false;
            codeProductNumericUpDown.Value = ConstantName.MinValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var product = new ProductModel()
            {
                Id = Convert.ToInt32(idLabel.Text),
                CodeProduct = (int)codeProductNumericUpDown.Value,
                NameProduct = nameProductTextBox.Text,
                Cost = coastNumeric.Value,
                NameCategory = categoryComboBox.Text
            };

            if (product.NameProduct == String.Empty)
            {
                validMessageLabel.Visible = true;
                validMessageLabel.Text = ConstantName.ValidNameMessage;
            }
            else
            {
                _productRepository.AddOrUpdateProduct(product);
                UpdateGrid();
                MessageBox.Show(ConstantName.SucessfulAddMessage, ConstantName.Attention);
            }
            
        }

        private ProductModel GetAddProductModelWithDataGrid(object sender)
        {
            var dataGridView = sender as DataGridView;
            var addProduct = dataGridView.CurrentRow.DataBoundItem as ProductModel;
            return addProduct;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var idProduct = Convert.ToInt32(idLabel.Text);
            var ingredients = _ingredientRepository.GetIngredientsList().ToList();
            var ingredientByProduct = ingredients.Where(x => x.IdProduct == idProduct);
            foreach (var ingredient in ingredientByProduct)
            {
                var count = ingredients.Count(x => x.Name == ingredient.Name);
                if (count == ConstantName.MinValueIngredient)
                {
                    _workIngredientRepository.DeleteWorkIngredientByName(ingredient.Name);
                }
            }
            _productRepository.DeleteProduct(idProduct);
            UpdateGrid();
        }

        private void productDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var addProduct = GetAddProductModelWithDataGrid(sender);

            addOrUpdateProductGroupBox.Visible = true;
            addOrUpdateProductGroupBox.Text = ConstantName.Edit;
            codeProductNumericUpDown.Value = addProduct.CodeProduct;
            nameProductTextBox.Text = addProduct.NameProduct;
            coastNumeric.Value = addProduct.Cost;
            saveButton.Text = ConstantName.Save;
            idLabel.Text = addProduct.Id.ToString();
            deleteButton.Visible = true;
            validMessageLabel.Visible = false;
        }



    }
}
