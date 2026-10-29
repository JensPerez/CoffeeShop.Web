namespace CoffeeShop.Web.ViewModels;

public class KoffieDetailVm
{
    public int Id { get; set; }
    public string Naam { get; set; }
    public string Beschrijving { get; set; }
    public decimal Prijs { get; set; }
    public bool IsVegan { get; set; }
    public string ImageUrl { get; set; }
    public List<IngredientVm> Ingredienten { get; set; } = new List<IngredientVm>();
}