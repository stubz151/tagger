using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Mvc;
using Tagger.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Tagger.Controllers;

[Route("api/[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    // GET api/person/john
    [HttpGet("{userName}")]
    public Person GetPerson(string userName)
    {
        LambdaLogger.Log($"Get Person for {userName}");
        return new Person
        {
            userName = userName,
            tags = new List<Tag> { new Tag { description = "test", name = "c#" } }
        };
    }

    /// <summary>
    /// Creates a person.
    /// </summary>
    /// <param name="person"></param>
    /// <returns>A newly created TodoItem</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /person
    ///     {
    ///        "userName": "stubbs",
    ///     }
    ///
    /// </remarks>
    /// <response code="201">Returns the newly created item</response>
    /// <response code="400">If the item is null</response>
    [HttpPost]
    public Person Post([FromBody]Person person)
    {
        LambdaLogger.Log($"Create Person for {JsonSerializer.Serialize(person)}");
        return person;
    }
}
