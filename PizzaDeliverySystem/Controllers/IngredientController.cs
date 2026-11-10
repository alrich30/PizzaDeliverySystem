using Microsoft.AspNetCore.Mvc;
using PizzaDeliverySystem.Application.Contract;
using PizzaDeliverySystem.Application.Dtos;
using PizzaDeliverySystem.Application.Service;

namespace PizzaDeliverySystem.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientController : ControllerBase
{
    private readonly IIngredientService _ingredientService;

    public IngredientController(IIngredientService ingredientService)
    {
        _ingredientService = ingredientService;
    }

    // GET: api/ingredient
    [HttpGet]
    public async Task<ActionResult<IEnumerable<IngredientDto>>> GetAll(CancellationToken ct)
    {
        var ingredients = await _ingredientService.GetAllAsync(ct);
        return Ok(ingredients);
    }

    // GET: api/ingredient/{id}
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<IngredientDto>> GetById(Guid id, CancellationToken ct)
    {
        var ingredient = await _ingredientService.GetByIdAsync(id, ct);
        if (ingredient is null)
            return NotFound();

        return Ok(ingredient);
    }

    // POST: api/ingredient
    [HttpPost]
    public async Task<ActionResult<IngredientDto>> Create(
        [FromBody] CreateIngredientRequest request,
        CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var created = await _ingredientService.CreateAsync(request, ct);

        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    // PUT: api/ingredient/{id}
    [HttpPut("{id:guid}")]
    public async Task<ActionResult<IngredientDto>> Update(
        Guid id,
        [FromBody] UpdateIngredientRequest request,
        CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var updated = await _ingredientService.UpdateAsync(id, request, ct);
        if (updated is null)
            return NotFound();

        return Ok(updated);
    }

    // DELETE: api/ingredient/{id}
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id, CancellationToken ct)
    {
        var deleted = await _ingredientService.DeleteAsync(id, ct);
        if (!deleted)
            return NotFound();

        return NoContent();
    }
}
