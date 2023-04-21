﻿using ProductManagement.Categories;

using System;

using Volo.Abp.Domain.Entities.Auditing;

namespace ProductManagement.Products;

public class Product : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsFreeCargo { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ProductStockState StockState { get; set; }

    public Category Category { get; set; }
    public Guid CategoryId { get; set; }
}
