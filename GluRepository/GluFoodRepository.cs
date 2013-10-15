using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GluRepository
{
    public class GluFoodRepository : IGluFoodRepository
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        public List<DbFoodProduct> FindFoodProduct(string productName)
        {
            throw new NotImplementedException();
        }

        public List<DbFoodProduct> GetAllFoodProducts()
        {
            throw new NotImplementedException();
        }

        public List<DbFoodCategory> GetAllFoodCategory()
        {
            throw new NotImplementedException();
        }
    }
}
