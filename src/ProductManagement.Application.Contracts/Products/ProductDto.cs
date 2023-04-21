using System;

using Volo.Abp.Application.Dtos;

namespace ProductManagement.Products;

public class ProductDto : AuditedEntityDto<Guid>
{
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsFreeCargo { get; set; }
    public DateTime ReleaseDate { get; set; }
    public ProductStockState StockState { get; set; }
}
