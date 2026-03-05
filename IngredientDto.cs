namespace RecipeCost.Shared;

public record IngredientDto
{
    public int Id { get; init; } // 'init' allows setting only during creation
    public string Name { get; init; } = string.Empty;
    public UnitType BaseUnit { get; init; } = UnitType.Gram;
    public decimal CostPerBaseUnit { get; init; }
}