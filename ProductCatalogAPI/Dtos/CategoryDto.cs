namespace ProductCatalogAPI.Dtos;

public record CategoryDto(
    int CategoryId,
    string CategoryName,
    string? CategoryDescription);
