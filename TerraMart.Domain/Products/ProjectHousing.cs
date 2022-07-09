namespace TerraMart.Domain.Products
{
    public class ProjectHousing : HousingUnit
    {
        public int? TotalUnits { get; set; }
        public decimal Price { get; set; }
        public List<Document>? Media { get; set; }
        public bool IsSubscribed { get; set; }
    }
}
