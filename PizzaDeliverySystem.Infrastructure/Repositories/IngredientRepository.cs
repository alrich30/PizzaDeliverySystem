using Microsoft.EntityFrameworkCore;
using PizzaDeliverySystem.Domain.Entities;
using PizzaDeliverySystem.Domain.Core.Repository;
using PizzaDeliverySystem.Infrastructure.Context;
using PizzaDeliverySystem.Infrastructure.Models;

namespace PizzaDeliverySystem.Infrastructure.Repositories;

public class IngredientRepository
    : BaseRepository<IngredientModel, Ingredient>, IIngredientRepository
{
    public IngredientRepository(PizzaDbContext context) : base(context) { }

    // ---------- Get by Ids (many) ----------
    public async Task<List<Ingredient>> GetByIdsAsync(IEnumerable<Guid> ids, CancellationToken ct = default)
    {
        // Evitamos null y duplicados
        var idList = ids?
            .Where(x => x != Guid.Empty)
            .Distinct()
            .ToList() ?? new List<Guid>();

        if (idList.Count == 0)
            return new List<Ingredient>();

        var models = await _dbSet
            .AsNoTracking()
            .Where(i => idList.Contains(i.Id))
            .ToListAsync(ct);

        return models
            .Select(MapToDomain)
            .ToList();
    }

    protected override Ingredient MapToDomain(IngredientModel model)
        => new Ingredient(model.Id, model.Name, model.ExtraPrice);

    protected override IngredientModel MapToModel(Ingredient entity)
        => new IngredientModel
        {
            Id = entity.Id,
            Name = entity.Name,
            ExtraPrice = entity.ExtraPrice
        };

    public override void Update(Ingredient entity)
    {
        var model = MapToModel(entity);
        _context.Entry(model).State = EntityState.Modified;
    }

    
}
