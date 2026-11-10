using System;

namespace PizzaDeliverySystem.Application.Dtos
{
    public class CreateIngredientRequest
    {
        public string Name { get; set; } = string.Empty;
        public decimal ExtraPrice { get; set; }
    }
}
