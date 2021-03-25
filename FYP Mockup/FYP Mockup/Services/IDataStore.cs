using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FYP_Mockup.Services
{
    public interface IDataStore<T>
    {
        Task<bool> AddItemAsync(T item);
        Task<bool> UpdateItemAsync(T item);
        Task<bool> DeleteItemAsync(string id);
        Task<T> GetItemAsync(string id);
        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);
        Task<bool> AddProductAsync(T product);
        Task<bool> UpdateProductAsync(T product);
        Task<bool> DeleteProductAsync(string id);
        Task<T> GetProductAsync(string id);
        Task<IEnumerable<T>> GetProductsAsync(bool forceRefresh = false);
    }
}
