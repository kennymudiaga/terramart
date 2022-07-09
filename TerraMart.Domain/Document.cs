namespace TerraMart.Domain
{
    public class Document
    {
        public Document()
        {
            Id = DateTime.UtcNow.ToFileTime().ToString();
        }
        public string Id { get; private set; }
        public string? Name { get; set; }
        public string? Uri { get; set; }
        public string? Type { get; set; }
    }
}
