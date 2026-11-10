namespace PizzaDeliverySystem.Infrastructure.Models;

public class UserModel
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string PasswordHash { get; set; } = string.Empty;

    public string Role { get; set; } = "Customer";

    public bool IsActive { get; set; } = true;
}
