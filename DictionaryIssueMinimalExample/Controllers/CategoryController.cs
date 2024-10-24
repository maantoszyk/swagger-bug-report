using DictionaryIssueMinimalExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace DictionaryIssueMinimalExample.Controllers;

[ApiController]
[Route("[controller]")]
public class CategoryController : ControllerBase
{
    private static readonly List<CategoryModel> values =
    [
        new()
        {
            Id = 1,
            Fee = 10.0m,
            Localization = new()
            {
                { "en", new() { Name = "Clothes" } },
                { "de", new() { Name = "Kleidung" } },
                { "es", new() { Name = "Ropa" } }
            }
        },
        new()
        {
            Id = 2,
            Fee = 5.0m,
            Localization = new()
            {
                { "en", new() { Name = "Cell phones" } },
                { "de", new() { Name = "Mobiltelefone" } },
                { "es", new() { Name = "Teléfonos celulares" } }
            }
        },
    ];


    [HttpGet]
    public IEnumerable<CategoryModel> Get() => values;
}
