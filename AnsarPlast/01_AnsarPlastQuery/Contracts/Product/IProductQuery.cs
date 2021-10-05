using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AnsarPlastQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetailsBy(string slug);
        List<ProductQueryModel> GetLatesProducts();
        List<ProductQueryModel> Search(string value);
    }
}
