using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterokCompany.DAL.Migrations;
using VeterokCompany.DAL.Model;
using VeterokCompany.DAL.Repository;

namespace VeterokCompany
{
    public partial class StatisticSale : Form
    {
        private readonly WorkProductRepository _workProductRepository;
        public StatisticSale(WorkProductRepository workProductRepository)
        {
            InitializeComponent();
            _workProductRepository = workProductRepository;

            InitializeFirst();
        }

        private void InitializeFirst()
        {
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            var workProducts = _workProductRepository.GetWorkProductsList().Where(x => x.TimeAdding.Date == DateTime.Today).ToList();
            GetStatistic(workProducts);
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            workProductDataGridView.Columns[0].Visible = false;
            workProductDataGridView.Columns[2].Visible = false;

            workProductDataGridView.Columns[1].FillWeight = 40;
            workProductDataGridView.Columns[3].FillWeight = 80;
            workProductDataGridView.Columns[4].FillWeight = 240;
            workProductDataGridView.Columns[5].FillWeight = 50;
            workProductDataGridView.Columns[6].FillWeight = 55;
            workProductDataGridView.Columns[7].FillWeight = 50;
        }

        private void dayCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            var day = sender as MonthCalendar;
            var workProducts = _workProductRepository.GetWorkProductsList().Where(x => x.TimeAdding.Date == day.SelectionStart.Date).ToList();

            GetStatistic(workProducts);

        }

        private void SettingsRadioButtonPeriod( bool statisticDayGroupBoxVisible,bool statisticPeriodGroupBoxVisible)
        {
            statisticDayGroupBox.Visible = statisticDayGroupBoxVisible;
            statisticPeriodGroupBox.Visible = statisticPeriodGroupBoxVisible;
        }

        private void dayRadioButton_Click(object sender, EventArgs e)
        {
            SettingsRadioButtonPeriod(true, false);
        }

        private void periodRadioButton_Click(object sender, EventArgs e)
        {
            SettingsRadioButtonPeriod(false, true);
        }

        private void showStatisticButton_Click(object sender, EventArgs e)
        {
            var startDay = startDateTimePicker.Value;
            var endDay = endDateTimePicker.Value;
            var workProducts =
                    _workProductRepository.GetWorkProductsList().Where(x => x.TimeAdding.Date >= startDay.Date && 
                    x.TimeAdding.Date <= endDay.Date).ToList();

            GetStatistic(workProducts);
        }

        private void GetStatistic(IEnumerable<WorkProductModel> workProducts)
        {

            var productList = new List<WorkProductModel>();
            foreach (var product in workProducts)
            {
                if (
                    !productList.Any(
                        x => x.NameProduct == product.NameProduct && x.NameCategory == product.NameCategory))
                {
                    var newProduts =
                        workProducts.Where(
                            x => x.NameCategory == product.NameCategory && x.NameProduct == product.NameProduct)
                            .ToList();
                    productList.Add(new WorkProductModel()
                    {
                        CodeProduct = product.CodeProduct,
                        NameCategory = product.NameCategory,
                        NameProduct = product.NameProduct,
                        Сost = product.Сost,
                        Count = newProduts.Where(x => x.NameProduct == product.NameProduct).Sum(x => x.Count),
                        TotalSum = newProduts.Where(x => x.NameProduct == product.NameProduct).Sum(x => x.TotalSum)
                    });
                }
            }
            workProductDataGridView.DataSource = productList;

           


            incomeLabel.Text = workProducts.Sum(x => x.TotalSum).ToString();

        }

    }
}
