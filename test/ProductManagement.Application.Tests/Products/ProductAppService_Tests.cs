using Shouldly;

using System.Threading.Tasks;

using Xunit;

namespace ProductManagement.Products;

public class ProductAppService_Tests
    : ProductManagementApplicationTestBase
{
    private readonly IProductAppService _productAppService;

    public ProductAppService_Tests()
    {
        _productAppService = GetRequiredService<IProductAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Products()
    {
        //Act
        var output = await _productAppService.GetListAsync(new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto());
        //arrange
        output.TotalCount.ShouldBe(3);
        output.Items.ShouldContain(
    x => x.Name.Contains("Acme Monochrome Laser Printer")
);

    }
}
