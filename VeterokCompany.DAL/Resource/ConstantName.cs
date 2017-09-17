using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterokCompany.DAL.Resource
{
    public static class ConstantName
    {
        public static string AddProduct = "Добавить товар";
        public static string AddCategory = "Добавить категорию";
        public static string AddIngredient = "Добавить ингридиент";
        public static string Add = "Добавить";
        public static string Edit = "Редактировать";
        public static string Save = "Сохранить";
        public static string Yes = "Yes";
        public static string Attention = "Внимание";

        public const string Litr = "Литр";
        public const string Kg = "Кг";
        public const string Count = "Шт";

        public static string DeleteCategoryMessage = "В категории содержатся товары, вы точно хотите удалить?";
        public static string DeleteIngredientMessage = "Не выбран ингридиент для удаления";
        public static string ValidNameCategoryMessage = "Название уже существует, введите другое название";
        public static string ValidNameMessage = "Наименования является обязательным для заполнения";
        public static string ValidProductMessage = "Выберите наименование товара";
        public static string SucessfulSaveMessage = "Успешно сохранено";
        public static string SucessfulAddMessage = "Операция прошла успешно";
        public static string DontSearchProductMessage = "Товар не найден";
        public static string ValidSearchMessage = "Поиск не дал результата";
        
        public static int MinValue = 0;
        public static int MinValueIngredient = 1;

        public static string NameCategoryAndProduct = "{0}>{1}";
    }
}
