using DocumentFormat.OpenXml.Drawing.Charts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IProductBUL
    {
        int Insert(Product pro);
        int Delete(int Masanpham);
        int Update(Product pro);

        IList<Product> getAll();

        int checkProduct_ID(int Masanpham);
        IList<Product> SearchLinq(Product pro);

        List<dynamic> getAllJoin(IProviderBUL provider, IDonViTinhBUL donvi);
    }
}
