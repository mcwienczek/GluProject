using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public class DbFoodProduct
    {
        public virtual int DbFoodProductId { get; set; }
        [MaxLength(100)]
        public virtual string FoodProductName { get; set; }
        public virtual int Calories { get; set; }
        public virtual int FoodCategoryId { get; set; }
        [ForeignKey("FoodCategoryId")]
        public virtual DbFoodCategory FoodCategory { get; set; }
    }
}