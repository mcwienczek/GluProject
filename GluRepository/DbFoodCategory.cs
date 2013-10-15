using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public class DbFoodCategory
    {
        public int DbFoodCategoryId { get; set; }
        [MaxLength(100)]
        public string FoodCategoryName { get; set; }
    }
}
