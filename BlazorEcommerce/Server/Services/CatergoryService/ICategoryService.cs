namespace BlazorEcommerce.Server.Services.CatergoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCatergories();
    }
}
