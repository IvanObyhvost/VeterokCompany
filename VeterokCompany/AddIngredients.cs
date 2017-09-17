using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterokCompany.DAL.Enum;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;
using VeterokCompany.DAL.Resource;

namespace VeterokCompany
{
    public partial class AddIngredients : Form
    {
        Dictionary<QuantitiesType, string> quantitiesTypeDictionary = new Dictionary<QuantitiesType, string>();

        private readonly WorkIngredientRepository _workIngredientRepository;
        public AddIngredients(WorkIngredientRepository workIngredientRepository)
        {
            InitializeComponent();
            _workIngredientRepository = workIngredientRepository;
            InitializeGrid();

            quantitiesTypeDictionary.Add(QuantitiesType.Litr, ConstantName.Litr);
            quantitiesTypeDictionary.Add(QuantitiesType.Kg, ConstantName.Kg);
            quantitiesTypeDictionary.Add(QuantitiesType.Count, ConstantName.Count);
            quantitiesComboBox.DataSource = quantitiesTypeDictionary.Values.ToList();
            idIngredientLabel.Text = ConstantName.MinValue.ToString();
        }

        private void InitializeGrid()
        {
            var ingredients = _workIngredientRepository.GetWorkIngredientsList();
            ingredientDataGridView.DataSource = ingredients.OrderBy(x => x.Name).ToList();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            ingredientDataGridView.Columns[0].Visible = false;

            ingredientDataGridView.Columns[1].FillWeight = 20;
            ingredientDataGridView.Columns[4].FillWeight = 20;
        }

        private void ingredientDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ingredient = ingredientDataGridView.CurrentRow.DataBoundItem as WorkIngredientModel;

            nameTextBox.Text = ingredient.Name;
            quantitiesComboBox.SelectedItem = ingredient.Quantities;
            countNumericUpDown.Value = ConstantName.MinValue;
            idIngredientLabel.Text = ingredient.Id.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var idIngredient = int.Parse(idIngredientLabel.Text);
            var ingredient = new WorkIngredientModel();
            if (idIngredient != ConstantName.MinValue)
            {
                ingredient = _workIngredientRepository.GetWorkIngredientsList().FirstOrDefault(x => x.Id == idIngredient);
            }
            else
            {
                ingredient = ingredientDataGridView.CurrentRow.DataBoundItem as WorkIngredientModel;
            }
            ingredient.Count += countNumericUpDown.Value;
            _workIngredientRepository.AddOrUpdateWorkIngredient(ingredient);
            InitializeGrid();
            MessageBox.Show(ConstantName.SucessfulAddMessage, ConstantName.Attention);
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchIngredient();
        }

        private void codeSearchIngredientNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                SearchIngredient();
            }
        }

        private void SearchIngredient()
        {
            var code = (int)codeSearchIngredientNumericUpDown.Value;
            if (_workIngredientRepository.GetWorkIngredientsList().Any(x => x.CodeIngredient == code))
            {
                var ingredient = _workIngredientRepository.GetWorkIngredient(code);
                nameTextBox.Text = ingredient.Name;
                quantitiesComboBox.Text = ingredient.Quantities;
                idIngredientLabel.Text = ingredient.Id.ToString();
            }
            else
            {
                MessageBox.Show(ConstantName.ValidSearchMessage, ConstantName.Attention);
            }
        }
    }
}
