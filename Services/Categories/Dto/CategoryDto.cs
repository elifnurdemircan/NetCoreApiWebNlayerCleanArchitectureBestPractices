using App.Services.Products;

namespace App.Services.Categories.Dto
{
    public record CategoryDto(int Id , string Name, List<ProductDto> Products);
    
}
