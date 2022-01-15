using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Simulei_Anca_Lab12_xamarin.Models;

namespace Simulei_Anca_Lab12_xamarin.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
