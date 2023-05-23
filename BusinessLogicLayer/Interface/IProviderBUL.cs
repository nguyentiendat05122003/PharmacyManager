using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interface
{
    public interface IProviderBUL
    {
        int Insert(Provider cls);
        int Delete(int mancc);
        int Update(Provider cls);
        IList<Provider> getAll();
        int checkNCC_ID(int mancc);
        IList<Provider> SearchLinq(string cls);

        IList<Provider> GetProviderIsContact();

        string GetProviderName(int mancc);
    }
}
