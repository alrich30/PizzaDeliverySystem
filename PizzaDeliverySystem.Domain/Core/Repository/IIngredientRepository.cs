using PizzaDeliverySystem.Domain.Core.Repository;
using PizzaDeliverySystem.Domain.Entities;

public interface IIngredientRepository : IRepository<Ingredient>
{
    Task<List<Ingredient>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken ct = default);
 
}
