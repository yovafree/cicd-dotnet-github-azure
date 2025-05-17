using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using StarWars.MVC.Models;

namespace StarWars.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly HttpClient _httpClient = new HttpClient();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public async Task<IActionResult> Movies()
    {
        var response = await _httpClient.GetStringAsync("https://swapi.info/api/films/");
        var movies = JsonSerializer.Deserialize<List<StarWarsMovie>>(response, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return View(movies);
    }

    public async Task<IActionResult> Planets()
    {
        var response = await _httpClient.GetStringAsync("https://swapi.info/api/planets/");
        var planets = JsonSerializer.Deserialize<List<Planet>>(response, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return View(planets);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
