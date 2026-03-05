namespace RecipeCost.Shared;

public class IngredientDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string BaseUnit { get; set; } = "Gram"; // e.g., Gram, oz, cup
    public decimal CostPerBaseUnit { get; set; }
}