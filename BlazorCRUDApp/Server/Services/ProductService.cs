using BlazorCRUDApp.Server.Data;
using BlazorCRUDApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDApp.Server.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetItemsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetItemByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddItemAsync(Product item)
        {
            _context.Products.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateItemAsync(Product item)
        {
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteItemAsync(int id)
        {
            var item = await _context.Products.FindAsync(id);
            if (item != null)
            {
                _context.Products.Remove(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
