namespace Core.Entites
{
    public class PortofolioItem : EntityBase
    { 
        public string? ProjectName { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
