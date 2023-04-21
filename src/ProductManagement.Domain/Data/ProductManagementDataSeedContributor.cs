using ProductManagement.Categories;

using System;
using System.Threading.Tasks;

using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace ProductManagement.Data;

public class ProductManagementDataSeedContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Category, Guid> _categoryRepository;
    private readonly IRepository<Product, Guid> _productRepository;

    public ProductManagementDataSeedContributor(
        IRepository<Category, Guid> categoryRepository,
        IRepository<ProductManagement, Guid> productRepository)
    {
        _productRepository = _productRepository;
        _categoryRepository = _categoryRepository;
    }

    public Task SeedAsync(DataSeedContext context)
    {

        return Task.CompletedTask;
    }
}
