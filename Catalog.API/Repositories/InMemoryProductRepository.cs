using Catalog.API.Models;

namespace Catalog.API.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly Dictionary<int, Product> _products = new();
    private int _nextId = 1;

    public Task<IEnumerable<Product>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<Product>>(_products.Values);
    }

    public Task<Product?> GetByIdAsync(int id)
    {
        _products.TryGetValue(id, out var product);
        return Task.FromResult(product);
    }

    public Task<Product> CreateAsync(CreateProductDto dto)
    {
        var product = new Product(_nextId++, dto.Name, dto.Price, dto.Category);
        _products[product.Id] = product;
        return Task.FromResult(product);
    }

    public Task<Product?> UpdateAsync(int id, Product product)
    {
        if (!_products.ContainsKey(id))
        {
            return Task.FromResult<Product?>(null);
        }

        var updatedProduct = product with { Id = id };
        _products[id] = updatedProduct;
        return Task.FromResult<Product?>(updatedProduct);
    }

    public Task<bool> DeleteAsync(int id)
    {
        return Task.FromResult(_products.Remove(id));
    }
}
