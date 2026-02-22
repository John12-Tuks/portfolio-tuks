using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using cvPortfolio.Models;
using System.Text.Json;

namespace cvPortfolio.Controllers;

public class ResumeController : Controller
{
     private readonly IWebHostEnvironment _env;

    private readonly string _dataDir;
    private readonly string _jsonPath;
    private static readonly object _fileLock = new();

     private readonly ILogger<ResumeController> _logger;

    public ResumeController(IWebHostEnvironment env,ILogger<ResumeController> logger)
    {
        _logger = logger;
        _env = env;
        _dataDir = Path.Combine(_env.ContentRootPath, "App_Data");
        _jsonPath = Path.Combine(_dataDir, "magazine.json");
    }

    public IActionResult Resume(string? id)
    {
        var docs = LoadDocs()
            .OrderByDescending(d => d.UploadedAt)
            .ToList();

        var selected = (!string.IsNullOrWhiteSpace(id))
            ? docs.FirstOrDefault(d => d.Id == id)
            : docs.FirstOrDefault();

        ViewBag.Docs = docs;
        ViewBag.SelectedId = selected?.Id ?? "";
        ViewBag.SelectedFile = selected?.FileName ?? "";

        return View();
    }

    private List<DocumentItem> LoadDocs()
    {
        lock (_fileLock)
        {
            Directory.CreateDirectory(_dataDir);

            if (!System.IO.File.Exists(_jsonPath))
                return new List<DocumentItem>();

            var json = System.IO.File.ReadAllText(_jsonPath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<DocumentItem>();

            return JsonSerializer.Deserialize<List<DocumentItem>>(json) ?? new List<DocumentItem>();
        }
    }

   
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}