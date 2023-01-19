using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DestinationsController : ControllerBase
{
  private readonly TravelApiContext _db;

  public DestinationsController(TravelApiContext db)
  {
    _db = db;
  }

  // GET api/destinations
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Destination>>> Get()
  {
    return await _db.Destinations.ToListAsync();
  }

  // GET: api/destinations/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Destination>> GetDestination(int id)
  {
    Destination destination = await _db.Destinations.FindAsync(id);

    if (destination == null)
    {
      return NotFound();
    }
    return destination;
  }

  // POST api/destinations
  [HttpPost]
  public async Task<ActionResult<Destination>> Post([FromBody] Destination destination)
  {
    _db.Destinations.Add(destination);
    await _db.SaveChangesAsync();
    return CreatedAtAction(nameof(GetDestination), new { id = destination.DestinationId }, destination);
  }

  // PUT: api/destinations/5
  [HttpPut("{id}")]
  public async Task<ActionResult> Put(int id, Destination destination)
  {
    if (id != destination.DestinationId)
    {
      return BadRequest();
    }

    _db.Destinations.Update(destination);

    try
    {
      await _db.SaveChangesAsync();
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!DestinationExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }

  private bool DestinationExists(int id)
  {
    return _db.Destinations.Any(e => e.DestinationId == id);
  }

  // DELETE: api/destinations/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteDestination(int id)
  {
    Destination destination = await _db.Destinations.FindAsync(id);
    if (destination == null)
    {
      return NotFound();
    }
    _db.Destinations.Remove(destination);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}