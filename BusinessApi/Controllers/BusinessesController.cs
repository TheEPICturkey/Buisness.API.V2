using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessApi.Models;

namespace BusinessApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private readonly BusinessApiContext _db;

    public BusinessesController(BusinessApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<List<Business>> Get([FromQuery] PaginationParams @params)
    {
      IQueryable<Business> query = _db.Businesses.AsQueryable();

      int skip = (@params.Page - 1) * @params.ItemsPerPage;
      query = query.Skip(skip).Take(@params.ItemsPerPage);

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Business>> GetBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);

      if (business == null)
      {
        return NotFound();
      }

      return business;
    }

    [HttpPost]
    public async Task<ActionResult<Business>> Post(Business business)
    {
      _db.Businesses.Add(business);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetBusiness), new { id = business.BusinessId }, business);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Business business)
    {
      if (id != business.BusinessId)
      {
        return BadRequest();
      }

      _db.Businesses.Update(business);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!BusinessExists(id))
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

    private bool BusinessExists(int id)
    {
      return _db.Businesses.Any(e => e.BusinessId == id);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBusiness(int id)
    {
      Business business = await _db.Businesses.FindAsync(id);
      if (business == null)
      {
        return NotFound();
      }

      _db.Businesses.Remove(business);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
