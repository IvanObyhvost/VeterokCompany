using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterokCompany.DAL.EF;
using VeterokCompany.DAL.Enum;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;
using VeterokCompany.DAL.Resource;

namespace VeterokCompany
{
    public partial class NewIngredients : Form
    {
        Dictionary<QuantitiesType, string> quantitiesTypeDictionary = new Dictionary<QuantitiesType, string>();

        private readonly ProductRepository _productRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly IngredientRepository _ingredientRepository;
        private readonly WorkIngredientRepository _workIngredientRepository;
        public NewIngredients(ProductRepository productRepository, CategoryRepository categoryRepository,
            IngredientRepository ingredientRepository,
            WorkIngredientRepository workIngredientRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _ingredientRepository = ingredientRepository;
            _workIngredientRepository = workIngredientRepository;

            InitializeFirst();
        }

        private void InitializeFirst()
        {
            var category = _categoryRepository.GetCategoriesList().ToList();
            categoryDataGridView.DataSource = category;

            quantitiesTypeDictionary.Add(QuantitiesType.Litr, ConstantName.Litr);
            quantitiesTypeDictionary.Add(QuantitiesType.Kg, ConstantName.Kg);
            quantitiesTypeDictionary.Add(QuantitiesType.Count, ConstantName.Count);

            InitializeGrid();
            quantitiesComboBox.DataSource = quantitiesTypeDictionary.Values.ToList();
        }

        private void InitializeGrid()
        {
            categoryDataGridView.Columns[0].Visible = false;

        }
        private void UpdateIngredientGrid()
        {
            var product = productDataGridView.CurrentRow.DataBoundItem as ProductModel;

            var ingredients = _ingredientRepository.GetIngredientsList().Where(x => x.IdProduct == product.Id);
            ingredientDataGridView.DataSource = ingredients.ToList();

            ingredientDataGridView.Columns[0].Visible = false;
            ingredientDataGridView.Columns[1].Visible = false;
            ingredientDataGridView.Columns[3].Visible = false;
            ingredientDataGridView.Columns[4].Visible = false;
            ingredientDataGridView.Columns[5].Visible = false;
            ingredientDataGridView.Columns[6].Visible = false;

        }
        private void UpdateProductGrid()
        {
            productDataGridView.Columns[0].Visible = false;
            productDataGridView.Columns[1].Visible = false;
            productDataGridView.Columns[3].Visible = false;
            productDataGridView.Columns[4].Visible = false;
        }

        private void categoryDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var category = categoryDataGridView.CurrentRow.DataBoundItem as CategoryModel;

            var product = _productRepository.GetProductModelsList().Where(x => x.NameCategory == category.Name);
            productDataGridView.DataSource = product.ToList();

            UpdateProductGrid();
        }

        private void productDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UpdateIngredientGrid();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            UpdateValue(true, ConstantName.AddIngredient, ConstantName.Add, false, ConstantName.MinValue.ToString(), true, true, true);
            countNumericUpDown.Value = ConstantName.MinValue;
            nameTextBox.Text = String.Empty;
            codeIngredientNumericUpDown.Value = ConstantName.MinValue;
            codeSearchIngredientNumericUpDown.Value = ConstantName.MinValue;

            nameTextBox.Enabled = true;
            quantitiesComboBox.Enabled = true;

        }

        private void UpdateValue(bool addOrUpdateGroupBoxVisible, string addOrUpdateGroupBoxText, string saveButtonText,
            bool deleteButtonVisible, string idIngredientLabelText, bool idProductNumericUpDownEnabled, bool searchButtonEnabled,
            bool codeIngredientNumericUpDownEnabled)
        {
            addOrUpdateGroupBox.Visible = addOrUpdateGroupBoxVisible;
            addOrUpdateGroupBox.Text = addOrUpdateGroupBoxText;
            saveButton.Text = saveButtonText;
            deleteButton.Visible = deleteButtonVisible;
            idIngredientLabel.Text = idIngredientLabelText;
            codeSearchIngredientNumericUpDown.Enabled = idProductNumericUpDownEnabled;
            searchButton.Enabled = searchButtonEnabled;
            codeIngredientNumericUpDown.Enabled = codeIngredientNumericUpDownEnabled;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (productDataGridView.CurrentRow == null)
            {
                validMessageLabel.Text = ConstantName.ValidProductMessage;
                validMessageLabel.Visible = true;
            }
            else if (nameTextBox.Text == String.Empty)
            {
                validMessageLabel.Text = ConstantName.ValidNameMessage;
                validMessageLabel.Visible = true;
            }
            else 
            {
                var product = productDataGridView.CurrentRow.DataBoundItem as ProductModel;
                var quantitiesType = quantitiesTypeDictionary.First(x => x.Value == quantitiesComboBox.Text).Key;

                var ingredient = new IngredientModel()
                {
                    Id = Convert.ToInt32(idIngredientLabel.Text),
                    Name = nameTextBox.Text,
                    Count = countNumericUpDown.Value,
                    Quantities = quantitiesType,
                    IdProduct = product.Id,
                    CodeIngredient = (int)codeIngredientNumericUpDown.Value
                };

                _ingredientRepository.AddOrUpdateIngredient(ingredient);
                UpdateIngredientGrid();
                validMessageLabel.Visible = false;

                if (_workIngredientRepository.GetWorkIngredientsList().All(x => x.Name != ingredient.Name))
                {
                    var workIngredient = new WorkIngredientModel()
                    {
                        Name = ingredient.Name,
                        Count = ConstantName.MinValue,
                        Quantities = quantitiesComboBox.Text,
                        CodeIngredient = ingredient.CodeIngredient
                    };
                    _workIngredientRepository.AddOrUpdateWorkIngredient(workIngredient);
                }

                MessageBox.Show(ConstantName.SucessfulSaveMessage, ConstantName.Attention);
            }
            
        }

        private void ingredientDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ingredient = ingredientDataGridView.CurrentRow.DataBoundItem as IngredientModel;

            nameTextBox.Text = ingredient.Name;
            countNumericUpDown.Value = ingredient.Count;
            codeIngredientNumericUpDown.Value = ingredient.CodeIngredient;
            nameTextBox.Enabled = false;
            quantitiesComboBox.Enabled = false;

            quantitiesComboBox.SelectedItem =
                quantitiesTypeDictionary.FirstOrDefault(x => x.Key == ingredient.Quantities).Value;
            UpdateValue(true, ConstantName.Edit, ConstantName.Save, true, ingredient.Id.ToString(), false, false, false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ingredientDataGridView.CurrentRow != null)
            {
                var ingredient = ingredientDataGridView.CurrentRow.DataBoundItem as IngredientModel;

                var workIngredient = _ingredientRepository.GetIngredientsList().Count(x => x.Name == ingredient.Name);
                if (workIngredient == 1)
                {
                    _workIngredientRepository.DeleteWorkIngredientByName(ingredient.Name);
                }

                _ingredientRepository.DeleteIngredient(ingredient.Id);
                UpdateIngredientGrid();
                addOrUpdateGroupBox.Visible = false;
                deleteButton.Visible = false;
            }
            else
            {
                MessageBox.Show(ConstantName.DeleteIngredientMessage, ConstantName.Attention);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchProductById();
        }

        private void SearchProductById()
        {
            var codeIngredient = (int)codeSearchIngredientNumericUpDown.Value;
            if (_ingredientRepository.GetIngredientsList().Any(x => x.CodeIngredient == codeIngredient))
            {
                var ingredient = _ingredientRepository.GetIngredient(codeIngredient);
                codeIngredientNumericUpDown.Value = ingredient.CodeIngredient;
                nameTextBox.Text = ingredient.Name;
                quantitiesComboBox.SelectedItem =
                        quantitiesTypeDictionary.FirstOrDefault(x => x.Key == ingredient.Quantities).Value;

                nameTextBox.Enabled = false;
                quantitiesComboBox.Enabled = false;
                codeIngredientNumericUpDown.Enabled = false;
            }
            else
            {
                MessageBox.Show(ConstantName.ValidSearchMessage, ConstantName.Attention);
            }
        }
    }
}
