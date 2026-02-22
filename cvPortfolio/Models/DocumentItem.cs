namespace cvPortfolio.Models;

public class DocumentItem
{
    public string Id { get; set; } = "";
    public string FileName { get; set; } = "";
    public string RelativePath { get; set; } = "";
    public int DownloadCount { get; set; }
    public DateTime UploadedAt { get; set; }
}