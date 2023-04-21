﻿using ProductManagement.Categories;
using ProductManagement.Products;

using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        IRepository<Product, Guid> productRepository)
    {
        _productRepository = _productRepository;
        _categoryRepository = _categoryRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _categoryRepository.CountAsync() > 0)
            return;
        var monitors = new Category { Name = "Monitors" };
        var printers = new Category { Name = "Printers" };
        await _categoryRepository.InsertManyAsync(new[] { monitors, printers });
        var monitor1 = new Product
        {
            Category = monitors,
            Name = "XP VH240a 23.8-Inch Full HD 1080p IPS LED               Monitor",
            Price = 163,
            ReleaseDate = new DateTime(2019, 05, 24),
            StockState = ProductStockState.InStock
        };
        var monitor2 = new Product
        {
            Category = monitors,
            Name = "Clips 328E1CA 32-Inch Curved Monitor, 4K UHD",
            Price = 349,
            IsFreeCargo = true,
            ReleaseDate = new DateTime(2022, 02, 01),
            StockState = ProductStockState.Preorder
        };
        var printer1 = new Product
        {
            Category = monitors,
            Name = "Acme Monochrome Laser Printer, Compact All-In           One",
            Price = 199,
            ReleaseDate = new DateTime(2020, 11, 16),
            StockState = ProductStockState.NotAvailable
        };

        await _productRepository.InsertManyAsync(new[] { printer1, monitor1, monitor2 });
    }
}
