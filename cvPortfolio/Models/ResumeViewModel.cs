namespace MyWebsite.Models
{
    public class MagazineViewModel
    {
        public List<string> Files { get; set; } = new();
        public string? Selected { get; set; }
    }
}