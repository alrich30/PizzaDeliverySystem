using PizzaDeliverySystem.Application.Dtos;

namespace PizzaDeliverySystem.Application.Contract;

public interface IIngredientService
{
    Task<IngredientDto?> GetByIdAsync(Guid id, CancellationToken ct = default);
    Task<IReadOnlyList<IngredientDto>> GetAllAsync(CancellationToken ct = default);
    Task<IngredientDto> CreateAsync(CreateIngredientRequest request, CancellationToken ct = default);
    Task<IngredientDto?> UpdateAsync(Guid id, UpdateIngredientRequest request, CancellationToken ct = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
}
