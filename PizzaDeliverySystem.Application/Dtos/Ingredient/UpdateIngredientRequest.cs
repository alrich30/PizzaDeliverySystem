using System;

namespace PizzaDeliverySystem.Application.Dtos
{
    public class UpdateIngredientRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal ExtraPrice { get; set; }
    }
}
