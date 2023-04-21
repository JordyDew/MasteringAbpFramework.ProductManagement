namespace ProductManagement.Products;

public class ProductAppService_Tests
    :ProductManagementApplicationTestBase
{
    private readonly IProductAppService _productAppService;

    public ProductAppService_Tests()
    {
            _productAppService=GetRequiredService<IProductAppService>();
    }
}
