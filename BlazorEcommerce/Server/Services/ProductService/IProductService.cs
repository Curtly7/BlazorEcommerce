namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductAsync(int productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategoryAsync(string categoryId);

        Task<ServiceResponse<List<Product>>> SearchProducts(string searchText);

        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);
    }
}
