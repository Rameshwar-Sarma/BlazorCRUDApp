using BlazorCRUDApp.Shared.Models;

namespace BlazorCRUDApp.Server.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetItemsAsync();
        Task<Product> GetItemByIdAsync(int id);
        Task AddItemAsync(Product item);
        Task UpdateItemAsync(Product item);
        Task DeleteItemAsync(int id);
    }
}
