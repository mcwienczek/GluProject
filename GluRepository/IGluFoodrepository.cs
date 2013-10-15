using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public interface IGluFoodRepository : IDisposable
    {
        List<DbFoodProduct> FindFoodProduct(string productName);
        List<DbFoodProduct> GetAllFoodProducts();
        List<DbFoodCategory> GetAllFoodCategory();

    }
}