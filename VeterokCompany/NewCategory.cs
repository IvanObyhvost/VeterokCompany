using System;
using System.Linq;
using System.Windows.Forms;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;
using VeterokCompany.DAL.Resource;

namespace VeterokCompany
{
    public partial class NewCategory : Form
    {
        private readonly CategoryRepository _categoryRepository;
        private readonly ProductRepository _productRepository;
        public NewCategory(ProductRepository productRepository, CategoryRepository categoryRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;

            UpdateGrid();
        }
        private void UpdateGrid()
        {
            var category = _categoryRepository.GetCategoriesList();
            categoryDataGridView.DataSource = category;
            InitializeGrid();
        }
        private void InitializeGrid()
        {
            categoryDataGridView.Columns[0].Visible = false;
            addOrUpdateGroupBox.Visible = false;
            deleteButton.Visible = false;
            validMessagelabel.Visible = false;
        }

        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            SettingValue(true, ConstantName.AddCategory, ConstantName.Add, ConstantName.MinValue.ToString(), 
                false, false);
            nameCategoryTextBox.Text = String.Empty;

        }

        private void SettingValue(bool groupBoxVisible, string groupBoxText, string saveButtonText, string idCategoryLabelText,
            bool deleteButtonVisible, bool validMessagelabelVisible)
        {
            addOrUpdateGroupBox.Visible = groupBoxVisible;
            addOrUpdateGroupBox.Text = groupBoxText;
            saveButton.Text = saveButtonText;
            idCategoryLabel.Text = idCategoryLabelText;
            deleteButton.Visible = deleteButtonVisible;
            validMessagelabel.Visible = validMessagelabelVisible;
        }
        private CategoryModel GetCategoryModelWithDataGrid(object sender)
        {
            var dataGridView = sender as DataGridView;
            var category = dataGridView.CurrentRow.DataBoundItem as CategoryModel;
            return category;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var category = new CategoryModel()
            {
                Id = Convert.ToInt32(idCategoryLabel.Text),
                Name = nameCategoryTextBox.Text
            };
            var validValue = _categoryRepository.GetCategoriesList().Any(x => x.Name.ToLower() == category.Name.ToLower());

            if (validValue)
            {
                validMessagelabel.Visible = true;
                validMessagelabel.Text = ConstantName.ValidNameCategoryMessage;
            }
            else if (category.Name == String.Empty)
            {
                validMessagelabel.Visible = true;
                validMessagelabel.Text = ConstantName.ValidNameMessage;
            }
            else
            {
                _categoryRepository.AddOrUpdateCategory(category);
                UpdateGrid();
            }
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var idCategory = Convert.ToInt32(idCategoryLabel.Text);

            var category = categoryDataGridView.CurrentRow.DataBoundItem as CategoryModel;
            var haveProductCategory = _productRepository.GetProductModelsList().Any(x => x.NameCategory == category.Name);

            if (haveProductCategory)
            {
                var flagResult = MessageBox.Show(ConstantName.DeleteCategoryMessage, 
                    ConstantName.Attention, MessageBoxButtons.YesNo).ToString();

                if (flagResult == ConstantName.Yes)
                {
                    DeleteCategory(idCategory);
                }
            }
            else
            {
                DeleteCategory(idCategory);
            }
        }

        private void DeleteCategory(int idCategory)
        {
            _categoryRepository.DeteleCategory(idCategory);
            UpdateGrid();
        }

        private void categoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var category = GetCategoryModelWithDataGrid(sender);
            nameCategoryTextBox.Text = category.Name;

            SettingValue(true, ConstantName.Edit, ConstantName.Save, category.Id.ToString(), true, false);
        }
        
    }
}
