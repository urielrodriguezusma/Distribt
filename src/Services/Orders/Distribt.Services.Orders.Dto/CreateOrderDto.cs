using Distribt.Services.Products.Dto;

namespace Distribt.Services.Orders.Dto;


public record OrderDto(Guid orderId, OrderAddress orderAddress, PersonalDetails PersonalDetails, List<ProductDto> Products);
public record CreateOrderDto(OrderAddress orderAddress, PersonalDetails PersonalDetails, List<ProductDto> Products);
